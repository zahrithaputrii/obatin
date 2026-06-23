using System;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormTambahObat : Form
    {
        private Obat_service obatService = new Obat_service();

        public FormTambahObat()
        {
            InitializeComponent();
        }

        private void FormTambahObat_Load(object sender, EventArgs e)
        {
            // Daftar kategori bawaan untuk ComboBox
            string[] kategoriList = {
                "Analgetik & Antipiretik",
                "Antibiotik",
                "Vitamin & Suplemen",
                "Obat Batuk & Pilek",
                "Antihistamin (Alergi)",
                "Antasida (Obat Lambung)",
                "Mukolitik (Pengencer Dahak)",
                "H2 Blocker (Obat Lambung)",
                "PPI (Obat Lambung)",
                "Antidiare",
                "Cairan Rehidrasi",
                "Antitusif (Batuk Kering)",
                "Dekongestan (Hidung Tersumbat)",
                "Ekspektoran (Batuk Berdahak)",
                "Antijamur",
                "Antihipertensi",
                "Antidiabetes",
                "Kortikosteroid Topikal",
                "Obat Luka Bakar"
            };

            kategori_cb.Items.AddRange(kategoriList);
            if (kategori_cb.Items.Count > 0)
            {
                kategori_cb.SelectedIndex = 0;
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            string nama = namaObat_txt.Text.Trim();
            string hargaInput = harga_txt.Text.Trim();
            string stokInput = stok_txt.Text.Trim();
            string kategori = kategori_cb.Text.Trim();

            // 1. Validasi Nama Obat
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama Obat tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                namaObat_txt.Focus();
                return;
            }

            // 2. Validasi Harga
            decimal harga;
            if (!decimal.TryParse(hargaInput, out harga))
            {
                MessageBox.Show("Harga harus berupa angka decimal!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                harga_txt.Focus();
                return;
            }
            if (harga < 0)
            {
                MessageBox.Show("Harga tidak boleh negatif!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                harga_txt.Focus();
                return;
            }

            // 3. Validasi Stok
            int stok;
            if (!int.TryParse(stokInput, out stok))
            {
                MessageBox.Show("Stok harus berupa angka bulat!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                stok_txt.Focus();
                return;
            }
            if (stok < 0)
            {
                MessageBox.Show("Stok tidak boleh negatif!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                stok_txt.Focus();
                return;
            }

            // 4. Validasi Kategori
            if (string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Kategori tidak boleh kosong!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kategori_cb.Focus();
                return;
            }

            // 5. Simpan ke database
            try
            {
                int hasil = obatService.tambahObat(nama, harga, stok, kategori);

                if (hasil > 0)
                {
                    MessageBox.Show("Obat baru berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan obat. Silakan coba lagi.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
