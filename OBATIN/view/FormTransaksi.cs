using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.konfigurasi;

namespace OBATIN.view
{
    public partial class FormTransaksi : Form
    {
        private string kasirName;
        private Koneksi kon = new Koneksi();

        public FormTransaksi(string username = "admin")
        {
            InitializeComponent();
            this.kasirName = username;
            this.Load += FormTransaksi_Load;
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            kasir_txt.Text = kasirName;
            GenerateNoNota();
            LoadObat();

            // Register event handlers
            obat_cb.SelectedIndexChanged += obat_cb_SelectedIndexChanged;
            tambah_btn.Click += tambah_btn_Click;
            simpannota_btn.Click += simpannota_btn_Click;
            dashboard_btn.Click += dashboard_btn_Click;
            this.FormClosed += FormTransaksi_FormClosed;
        }

        private void GenerateNoNota()
        {
            try
            {
                string dateStr = DateTime.Now.ToString("yyyyMMdd");
                string prefix = "NT" + dateStr;
                DataTable dt = kon.eksekusiQuery("SELECT no_nota FROM penjualan WHERE no_nota LIKE '" + prefix + "%' ORDER BY no_nota DESC LIMIT 1");
                if (dt.Rows.Count > 0)
                {
                    string lastNota = dt.Rows[0]["no_nota"].ToString();
                    if (lastNota.Length >= 13)
                    {
                        int lastNum = int.Parse(lastNota.Substring(10));
                        int nextNum = lastNum + 1;
                        nota_txt.Text = prefix + nextNum.ToString("D3");
                    }
                    else
                    {
                        nota_txt.Text = prefix + "001";
                    }
                }
                else
                {
                    nota_txt.Text = prefix + "001";
                }
            }
            catch (Exception ex)
            {
                nota_txt.Text = "NT" + DateTime.Now.ToString("yyyyMMdd") + "001";
            }
        }

        private void LoadObat()
        {
            try
            {
                DataTable dt = kon.eksekusiQuery("SELECT id_obat, nama_obat, harga, stok FROM obat");
                obat_cb.DataSource = dt;
                obat_cb.DisplayMember = "nama_obat";
                obat_cb.ValueMember = "id_obat";

                if (dt.Rows.Count > 0)
                {
                    obat_cb.SelectedIndex = 0;
                    DataRowView drv = (DataRowView)dt.DefaultView[0];
                    harga_txt.Text = drv["harga"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data obat: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void obat_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (obat_cb.SelectedItem != null)
            {
                try
                {
                    DataRowView drv = (DataRowView)obat_cb.SelectedItem;
                    harga_txt.Text = drv["harga"].ToString();
                }
                catch { }
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (obat_cb.SelectedItem == null)
            {
                MessageBox.Show("Pilih obat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView drv = (DataRowView)obat_cb.SelectedItem;
            int idObat = Convert.ToInt32(drv["id_obat"]);
            string namaObat = drv["nama_obat"].ToString();
            double harga = Convert.ToDouble(harga_txt.Text);
            int jumlah = (int)jumlah_num.Value;
            int stok = Convert.ToInt32(drv["stok"]);

            // Check if already added to grid, and sum the quantity
            int existingQtyInGrid = 0;
            int existingRowIndex = -1;
            for (int i = 0; i < transaksi_dgv.Rows.Count; i++)
            {
                DataGridViewRow row = transaksi_dgv.Rows[i];
                if (row.Cells["id_obat"].Value != null && Convert.ToInt32(row.Cells["id_obat"].Value) == idObat)
                {
                    existingQtyInGrid = Convert.ToInt32(row.Cells["jumlah_beli"].Value);
                    existingRowIndex = i;
                    break;
                }
            }

            if (jumlah + existingQtyInGrid > stok)
            {
                MessageBox.Show($"Stok tidak mencukupi! Sisa stok di database: {stok}. Jumlah yang ingin dibeli: {jumlah + existingQtyInGrid}.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double subtotalVal = harga * (jumlah + existingQtyInGrid);

            if (existingRowIndex >= 0)
            {
                transaksi_dgv.Rows[existingRowIndex].Cells["jumlah_beli"].Value = jumlah + existingQtyInGrid;
                transaksi_dgv.Rows[existingRowIndex].Cells["subtotal"].Value = subtotalVal;
            }
            else
            {
                transaksi_dgv.Rows.Add(idObat, namaObat, harga, jumlah, subtotalVal);
            }

            HitungTotalBayar();
        }

        private void HitungTotalBayar()
        {
            double total = 0;
            foreach (DataGridViewRow row in transaksi_dgv.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["subtotal"].Value);
                }
            }
            byr_lbl.Text = "Rp " + total.ToString("N0");
        }

        private void simpannota_btn_Click(object sender, EventArgs e)
        {
            int validRowCount = 0;
            foreach (DataGridViewRow row in transaksi_dgv.Rows)
            {
                if (row.Cells["id_obat"].Value != null)
                {
                    validRowCount++;
                }
            }

            if (validRowCount == 0)
            {
                MessageBox.Show("Belum ada data obat yang ditambahkan ke transaksi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string noNota = nota_txt.Text;
                string tanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string kasir = kasir_txt.Text;

                double totalBayar = 0;
                foreach (DataGridViewRow row in transaksi_dgv.Rows)
                {
                    if (row.Cells["subtotal"].Value != null)
                    {
                        totalBayar += Convert.ToDouble(row.Cells["subtotal"].Value);
                    }
                }

                // Insert into penjualan
                string queryPenjualan = $"INSERT INTO penjualan (no_nota, tanggal, kasir, total_bayar) " +
                                        $"VALUES ('{noNota}', '{tanggal}', '{kasir}', {totalBayar})";
                int resPenjualan = kon.eksekusiNonQuery(queryPenjualan);

                if (resPenjualan > 0)
                {
                    // Get last insert ID
                    DataTable dtId = kon.eksekusiQuery("SELECT LAST_INSERT_ID() AS last_id");
                    int idPenjualan = Convert.ToInt32(dtId.Rows[0]["last_id"]);

                    // Insert details and update stock
                    foreach (DataGridViewRow row in transaksi_dgv.Rows)
                    {
                        if (row.Cells["id_obat"].Value == null) continue;

                        int idObat = Convert.ToInt32(row.Cells["id_obat"].Value);
                        string namaObat = row.Cells["nama_obat"].Value.ToString().Replace("'", "''");
                        double harga = Convert.ToDouble(row.Cells["harga"].Value);
                        int jumlah = Convert.ToInt32(row.Cells["jumlah_beli"].Value);
                        double subtotal = Convert.ToDouble(row.Cells["subtotal"].Value);

                        string queryDetail = $"INSERT INTO detail_penjualan (id_penjualan, id_obat, nama_obat, harga, jumlah, subtotal) " +
                                             $"VALUES ({idPenjualan}, {idObat}, '{namaObat}', {harga}, {jumlah}, {subtotal})";
                        kon.eksekusiNonQuery(queryDetail);

                        string queryUpdateStok = $"UPDATE obat SET stok = stok - {jumlah} WHERE id_obat = {idObat}";
                        kon.eksekusiNonQuery(queryUpdateStok);
                    }

                    MessageBox.Show("Transaksi berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open FormRiwayat
                    FormRiwayat formRiwayat = new FormRiwayat();
                    formRiwayat.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan transaksi!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan transaksi: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.Show();
            this.Close();
        }

        private void FormTransaksi_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool isRiwayatOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormRiwayat && f.Visible)
                {
                    isRiwayatOpen = true;
                    break;
                }
            }
            if (!isRiwayatOpen)
            {
                Application.Exit();
            }
        }

        private void transaksi_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
