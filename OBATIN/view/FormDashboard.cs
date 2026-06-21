using System;
using System.Drawing;
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
            this.Activated += FormDashboard_Activated;
            this.Resize += FormDashboard_Resize;
        }

        private void FormDashboard_Activated(object sender, EventArgs e)
        {
            MuatDataDashboard();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Atur dimensi Header dan Sidebar sesuai permintaan
            panel1.Width = 200;
            panel2.Height = 110;
            
            // Tampilkan header lebih proporsional
            welcome_lbl.Text = "Selamat Datang, " + (role.Length > 0 ? char.ToUpper(role[0]) + role.Substring(1) : role);
            desc_lbl.Text = "Kelola aktivitas apotek dengan mudah";
            welcome_lbl.Top = 30;
            desc_lbl.Top = 65;

            // Atur ukuran font card
            Font titleFont = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            Font valueFont = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);

            Label[] titleLabels = { judul_total_obat_lbl, judul_total_stok_lbl, judul_total_transaksi_lbl, judul_total_penjualan_lbl };
            Label[] valueLabels = { total_obat_lbl, total_stok_lbl, total_transaksi_lbl, total_penjualan_lbl };

            foreach (Label lbl in titleLabels)
            {
                lbl.Font = titleFont;
                lbl.AutoSize = true;
                lbl.AutoEllipsis = false;
            }
            foreach (Label lbl in valueLabels)
            {
                lbl.Font = valueFont;
                lbl.AutoSize = true;
                lbl.AutoEllipsis = false;
            }

            // Atur menu sesuai role
            dashboard_btn.Visible = false; // Sembunyikan tombol dashboard karena ini adalah halaman utama

            if (role == "owner")
            {
                stok_btn.Visible = false;
                transaksi_btn.Visible = false;
            }
            else if (role == "apoteker")
            {
                transaksi_btn.Visible = false;
            }

            // Rapikan posisi menu di sidebar dengan jarak konsisten 15px (tinggi tombol 45px)
            Button[] menus = { riwayat_btn, stok_btn, transaksi_btn };
            int currentY = 130; // Di bawah logo dengan jarak yang pas
            foreach (Button btn in menus)
            {
                if (btn.Visible)
                {
                    btn.Top = currentY;
                    btn.Left = (panel1.Width - btn.Width) / 2; // Rata tengah di sidebar
                    currentY += btn.Height + 15;
                }
            }

            // Anchor tombol logout agar selalu di bawah
            logout_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout_btn.Left = (panel1.Width - logout_btn.Width) / 2;

            // Tampilkan data dashboard
            MuatDataDashboard();

            // Panggil resize untuk menempatkan card di tengah
            FormDashboard_Resize(this, EventArgs.Empty);

            // Hubungkan tombol navigasi
            stok_btn.Click += stok_btn_Click;
            transaksi_btn.Click += transaksi_btn_Click;
            riwayat_btn.Click += riwayat_btn_Click;
        }

        public void MuatDataDashboard()
        {
            total_obat_lbl.Text = dashboard.totalObat().ToString();
            total_stok_lbl.Text = dashboard.totalStok().ToString();
            total_transaksi_lbl.Text = dashboard.totalTransaksi().ToString();
            total_penjualan_lbl.Text = "Rp " + dashboard.totalPenjualan().ToString("N0");

            // Pastikan teks ter-center setelah nominal berubah (agar tidak terpotong)
            CenterLabels();
        }

        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            if (panel1 == null || panel2 == null) return;

            // Lebarkan header
            panel2.Width = this.ClientSize.Width - panel1.Width;

            // Ukuran card sedikit diperbesar secara proporsional
            int cardWidth = 280;
            int cardHeight = 150;
            int padding = 40; // Jarak antar card

            // Hitung ukuran total dari kumpulan card (grid 2x2)
            int totalAreaWidth = (cardWidth * 2) + padding;

            // Hitung sisa ruang dashboard untuk diletakkan di tengah secara horizontal
            int availableWidth = this.ClientSize.Width - panel1.Width;

            int startX = panel1.Width + (availableWidth - totalAreaWidth) / 2;
            int startY = panel2.Bottom + 50; // Posisi tetap di atas, tepat di bawah header (tidak di tengah layar)

            // Cegah posisi minus jika window terlalu kecil
            if (startX < panel1.Width + 20) startX = panel1.Width + 20;
            if (startY < panel2.Bottom + 20) startY = panel2.Bottom + 20;

            if (totalObat_pnl != null)
                totalObat_pnl.Bounds = new Rectangle(startX, startY, cardWidth, cardHeight);
            
            if (totalStok_pnl != null)
                totalStok_pnl.Bounds = new Rectangle(startX + cardWidth + padding, startY, cardWidth, cardHeight);
            
            if (transaksi_pnl != null)
                transaksi_pnl.Bounds = new Rectangle(startX, startY + cardHeight + padding, cardWidth, cardHeight);
            
            if (penjualan_pnl != null)
                penjualan_pnl.Bounds = new Rectangle(startX + cardWidth + padding, startY + cardHeight + padding, cardWidth, cardHeight);

            CenterLabels();
        }

        private void CenterLabels()
        {
            CenterLabelInPanel(judul_total_obat_lbl, total_obat_lbl, totalObat_pnl);
            CenterLabelInPanel(judul_total_stok_lbl, total_stok_lbl, totalStok_pnl);
            CenterLabelInPanel(judul_total_transaksi_lbl, total_transaksi_lbl, transaksi_pnl);
            CenterLabelInPanel(judul_total_penjualan_lbl, total_penjualan_lbl, penjualan_pnl);
        }

        private void CenterLabelInPanel(Label title, Label value, Panel panel)
        {
            if (title == null || value == null || panel == null) return;
            
            title.Left = (panel.Width - title.Width) / 2;
            title.Top = 30; // Posisi atas yang tetap

            value.Left = (panel.Width - value.Width) / 2;
            value.Top = panel.Height - value.Height - 35; // Posisi bawah yang tetap
        }

        // Tombol Stok Obat → buka FormStokObat
        private void stok_btn_Click(object sender, EventArgs e)
        {
            FormStokObat formStok = new FormStokObat(role);
            formStok.Show();
        }

        // Tombol Transaksi → buka FormTransaksi (hanya kasir)
        private void transaksi_btn_Click(object sender, EventArgs e)
        {
            FormTransaksi formTransaksi = new FormTransaksi(username);
            formTransaksi.Show();
        }

        // Tombol Riwayat → buka FormRiwayat
        private void riwayat_btn_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat();
            formRiwayat.Show();
        }

        // Tombol Logout → kembali ke FormLogin
        private void logout_btn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        // Event placeholder dari designer (tidak dipakai)
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}