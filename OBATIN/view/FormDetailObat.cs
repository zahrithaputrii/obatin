using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormDetailObat : Form
    {
        private int idObat;
        private string namaObat;
        private string role;

        private DetailObat_service detailService = new DetailObat_service();

        public FormDetailObat(int idObat, string namaObat, string role)
        {
            InitializeComponent();
            this.idObat = idObat;
            this.namaObat = namaObat;
            this.role = role;
        }

        private void FormDetailObat_Load(object sender, EventArgs e)
        {
            namaObat_txt.Text = namaObat;

            // Atur mode edit berdasarkan role
            if (role != "apoteker")
            {
                // Jika bukan apoteker (misalnya kasir/owner), atur form jadi read-only
                manfaat_txt.ReadOnly = true;
                dosis_txt.ReadOnly = true;
                efekSamping_txt.ReadOnly = true;
                kontraindikasi_txt.ReadOnly = true;

                manfaat_txt.BackColor = SystemColors.Control;
                dosis_txt.BackColor = SystemColors.Control;
                efekSamping_txt.BackColor = SystemColors.Control;
                kontraindikasi_txt.BackColor = SystemColors.Control;

                simpan_btn.Visible = false;
                tutup_btn.Left = simpan_btn.Left; // Geser tombol tutup ke posisi simpan
                desc_lbl.Text = "Mode Lihat: Hanya apoteker yang dapat mengedit data ini.";
            }

            // Muat data dari database
            MuatDetailObat();
        }

        private void MuatDetailObat()
        {
            try
            {
                DataTable dt = detailService.getByObatId(idObat);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    manfaat_txt.Text = row["manfaat"].ToString();
                    dosis_txt.Text = row["dosis"].ToString();
                    efekSamping_txt.Text = row["efek_samping"].ToString();
                    kontraindikasi_txt.Text = row["kontraindikasi"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat detail obat: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            string manfaat = manfaat_txt.Text.Trim();
            string dosis = dosis_txt.Text.Trim();
            string efekSamping = efekSamping_txt.Text.Trim();
            string kontraindikasi = kontraindikasi_txt.Text.Trim();

            // Validasi: Manfaat tidak boleh kosong
            if (string.IsNullOrEmpty(manfaat))
            {
                MessageBox.Show("Kolom Manfaat harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                manfaat_txt.Focus();
                return;
            }

            try
            {
                int hasil = detailService.simpanDetail(idObat, manfaat, dosis, efekSamping, kontraindikasi);

                if (hasil > 0)
                {
                    MessageBox.Show("Detail informasi obat berhasil disimpan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan detail obat. Silakan coba lagi.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
