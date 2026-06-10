using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.konfigurasi;

namespace OBATIN.view
{
    public partial class FormRiwayat : Form
    {
        private Koneksi kon = new Koneksi();

        public FormRiwayat()
        {
            InitializeComponent();
            this.Load += FormRiwayat_Load;
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            LoadData();
            cari_dt.ValueChanged += cari_dt_ValueChanged;
            this.FormClosed += FormRiwayat_FormClosed;
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT id_penjualan AS `ID Penjualan`, no_nota AS `No Nota`, tanggal AS `Tanggal`, kasir AS `Kasir`, total_bayar AS `Total Bayar` FROM penjualan ORDER BY tanggal DESC";
                DataTable dt = kon.eksekusiQuery(query);
                riwayat_dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data riwayat: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cari_dt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string selectDate = cari_dt.Value.ToString("yyyy-MM-dd");
                string query = $"SELECT id_penjualan AS `ID Penjualan`, no_nota AS `No Nota`, tanggal AS `Tanggal`, kasir AS `Kasir`, total_bayar AS `Total Bayar` " +
                               $"FROM penjualan WHERE DATE(tanggal) = '{selectDate}' ORDER BY tanggal DESC";
                DataTable dt = kon.eksekusiQuery(query);
                riwayat_dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyaring data: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRiwayat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
