using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormRiwayat : Form
    {
        // Service untuk mengakses data penjualan
        private Penjualan_service penjualanService = new Penjualan_service();

        public FormRiwayat()
        {
            InitializeComponent();
            this.Load += FormRiwayat_Load;
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            // Muat semua data saat pertama dibuka
            MuatSemuaData();

            // Daftarkan event pencarian tanggal
            cari_dt.ValueChanged += cari_dt_ValueChanged;
        }

        // Tampilkan semua riwayat transaksi
        private void MuatSemuaData()
        {
            DataTable dt = penjualanService.viewAll();
            riwayat_dgv.DataSource = dt;
        }

        // Filter riwayat berdasarkan tanggal yang dipilih
        private void cari_dt_ValueChanged(object sender, EventArgs e)
        {
            string tanggalTerpilih = cari_dt.Value.ToString("yyyy-MM-dd");
            DataTable dt = penjualanService.searchByTanggal(tanggalTerpilih);
            riwayat_dgv.DataSource = dt;
        }

        // Event placeholder dari designer
        private void FormRiwayat_Load_1(object sender, EventArgs e) { }
    }
}
