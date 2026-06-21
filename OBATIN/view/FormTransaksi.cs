using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormTransaksi : Form
    {
        // Nama kasir yang login
        private string kasirName;

        // Service untuk penjualan dan obat
        private Penjualan_service penjualanService = new Penjualan_service();
        private Obat_service obatService = new Obat_service();

        public FormTransaksi(string username = "kasir")
        {
            InitializeComponent();
            this.kasirName = username;
            this.Load += FormTransaksi_Load;
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            // Set info nota dan kasir
            kasir_txt.Text = kasirName;
            nota_txt.Text = penjualanService.generateNoNota();
            dateTimePicker1.Value = DateTime.Now;

            // Muat data obat ke ComboBox
            MuatDataObat();

            // Daftarkan event handler
            obat_cb.SelectedIndexChanged += obat_cb_SelectedIndexChanged;
            tambah_btn.Click += tambah_btn_Click;
            simpannota_btn.Click += simpannota_btn_Click;
            dashboard_btn.Click += dashboard_btn_Click;
        }

        // Muat semua obat ke ComboBox pilihan
        private void MuatDataObat()
        {
            DataTable dt = obatService.viewAll();
            obat_cb.DataSource = dt;
            obat_cb.DisplayMember = "nama_obat";
            obat_cb.ValueMember = "id_obat";

            if (dt.Rows.Count > 0)
            {
                obat_cb.SelectedIndex = 0;
            }
        }

        // Saat obat dipilih di ComboBox, tampilkan harga
        private void obat_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (obat_cb.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)obat_cb.SelectedItem;
                harga_txt.Text = drv["harga"].ToString();
            }
        }

        // Tombol Tambah → masukkan obat ke DataGridView
        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (obat_cb.SelectedItem == null)
            {
                MessageBox.Show("Pilih obat terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView drv = (DataRowView)obat_cb.SelectedItem;
            int idObat = Convert.ToInt32(drv["id_obat"]);
            string namaObat = drv["nama_obat"].ToString();
            double harga = Convert.ToDouble(drv["harga"]);
            int jumlah = (int)jumlah_num.Value;
            int stok = Convert.ToInt32(drv["stok"]);

            // Cek apakah obat ini sudah ada di grid
            int jumlahDiGrid = 0;
            int indexBaris = -1;

            for (int i = 0; i < transaksi_dgv.Rows.Count; i++)
            {
                DataGridViewRow row = transaksi_dgv.Rows[i];
                if (row.Cells["id_obat"].Value != null &&
                    Convert.ToInt32(row.Cells["id_obat"].Value) == idObat)
                {
                    jumlahDiGrid = Convert.ToInt32(row.Cells["jumlah_beli"].Value);
                    indexBaris = i;
                    break;
                }
            }

            // Cek kecukupan stok
            if (jumlah + jumlahDiGrid > stok)
            {
                MessageBox.Show(
                    "Stok tidak cukup!\nStok tersedia: " + stok +
                    "\nJumlah yang diminta: " + (jumlah + jumlahDiGrid),
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double subtotal = harga * (jumlah + jumlahDiGrid);

            // Update baris jika sudah ada, atau tambah baris baru
            if (indexBaris >= 0)
            {
                transaksi_dgv.Rows[indexBaris].Cells["jumlah_beli"].Value = jumlah + jumlahDiGrid;
                transaksi_dgv.Rows[indexBaris].Cells["subtotal"].Value = subtotal;
            }
            else
            {
                transaksi_dgv.Rows.Add(idObat, namaObat, harga, jumlah, subtotal);
            }

            HitungTotal();
        }

        // Hitung dan tampilkan total bayar
        private void HitungTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in transaksi_dgv.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                    total += Convert.ToDouble(row.Cells["subtotal"].Value);
            }
            byr_lbl.Text = "Rp " + total.ToString("N0");
        }

        // Tombol Simpan Nota → simpan transaksi ke database
        private void simpannota_btn_Click(object sender, EventArgs e)
        {
            // Hitung jumlah baris valid
            int jumlahBaris = 0;
            foreach (DataGridViewRow row in transaksi_dgv.Rows)
            {
                if (row.Cells["id_obat"].Value != null) jumlahBaris++;
            }

            if (jumlahBaris == 0)
            {
                MessageBox.Show("Belum ada obat yang dipilih!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string noNota = nota_txt.Text;
                string tanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string kasir = kasir_txt.Text;

                // Hitung total bayar
                double totalBayar = 0;
                foreach (DataGridViewRow row in transaksi_dgv.Rows)
                {
                    if (row.Cells["subtotal"].Value != null)
                        totalBayar += Convert.ToDouble(row.Cells["subtotal"].Value);
                }

                // Simpan ke tabel penjualan
                int idPenjualan = penjualanService.simpanPenjualan(noNota, tanggal, kasir, totalBayar);

                if (idPenjualan > 0)
                {
                    // Simpan detail dan kurangi stok per obat
                    foreach (DataGridViewRow row in transaksi_dgv.Rows)
                    {
                        if (row.Cells["id_obat"].Value == null) continue;

                        int idObat = Convert.ToInt32(row.Cells["id_obat"].Value);
                        string namaObat = row.Cells["nama_obat"].Value.ToString();
                        double harga = Convert.ToDouble(row.Cells["harga"].Value);
                        int jumlah = Convert.ToInt32(row.Cells["jumlah_beli"].Value);
                        double subtotal = Convert.ToDouble(row.Cells["subtotal"].Value);

                        // Simpan ke detail_penjualan
                        penjualanService.simpanDetail(idPenjualan, idObat, namaObat, harga, jumlah, subtotal);

                        // Kurangi stok obat
                        penjualanService.kurangiStok(idObat, jumlah);
                    }

                    MessageBox.Show("Transaksi berhasil disimpan!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset form untuk transaksi berikutnya
                    transaksi_dgv.Rows.Clear();
                    nota_txt.Text = penjualanService.generateNoNota();
                    byr_lbl.Text = "Rp 0";
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan transaksi!", "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol Dashboard → tutup form ini (kembali ke dashboard yang masih terbuka)
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event placeholder dari designer
        private void transaksi_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void FormTransaksi_Load_1(object sender, EventArgs e) { }
    }
}
