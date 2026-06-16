using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormDashboard : Form
    {
        // Variabel untuk menyimpan username dan role
        string username;
        string role;

        // Memanggil Dashboard Service
        Dashboard_service dashboard = new Dashboard_service();

        // Constructor yang dipanggil dari FormLogin
        public FormDashboard(string user, string roleUser)
        {
            InitializeComponent();

            username = user;
            role = roleUser;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Selamat datang
            welcome_lbl.Text = "Selamat Datang, " + role;
            desc_lbl.Text = "Kelola dan pantau aktivitas apotek dengan mudah";

            // Atur menu sesuai role
            if (role == "owner")
            {
                stok_btn.Visible = false;
                transaksi_btn.Visible = false;
            }
            else if (role == "apoteker")
            {
                transaksi_btn.Visible = false;
            }
            else if (role == "kasir")
            {
                // Semua menu tampil
            }

            // Tampilkan data dashboard
            total_obat_lbl.Text = dashboard.totalObat().ToString();
            total_stok_lbl.Text = dashboard.totalStok().ToString();
            total_transaksi_lbl.Text = dashboard.totalTransaksi().ToString();
            total_penjualan_lbl.Text = "Rp " + dashboard.totalPenjualan().ToString("N0");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}