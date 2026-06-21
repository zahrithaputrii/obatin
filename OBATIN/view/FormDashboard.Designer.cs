namespace OBATIN.view
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.stok_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.riwayat_btn = new System.Windows.Forms.Button();
            this.transaksi_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.totalObat_pnl = new System.Windows.Forms.Panel();
            this.total_obat_lbl = new System.Windows.Forms.Label();
            this.judul_total_obat_lbl = new System.Windows.Forms.Label();
            this.totalStok_pnl = new System.Windows.Forms.Panel();
            this.total_stok_lbl = new System.Windows.Forms.Label();
            this.judul_total_stok_lbl = new System.Windows.Forms.Label();
            this.transaksi_pnl = new System.Windows.Forms.Panel();
            this.total_transaksi_lbl = new System.Windows.Forms.Label();
            this.judul_total_transaksi_lbl = new System.Windows.Forms.Label();
            this.penjualan_pnl = new System.Windows.Forms.Panel();
            this.total_penjualan_lbl = new System.Windows.Forms.Label();
            this.judul_total_penjualan_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.totalObat_pnl.SuspendLayout();
            this.totalStok_pnl.SuspendLayout();
            this.transaksi_pnl.SuspendLayout();
            this.penjualan_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.stok_btn);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.riwayat_btn);
            this.panel1.Controls.Add(this.transaksi_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 506);
            this.panel1.TabIndex = 0;
            // 
            // stok_btn
            // 
            this.stok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stok_btn.ForeColor = System.Drawing.Color.Black;
            this.stok_btn.Location = new System.Drawing.Point(15, 288);
            this.stok_btn.Name = "stok_btn";
            this.stok_btn.Size = new System.Drawing.Size(190, 45);
            this.stok_btn.TabIndex = 7;
            this.stok_btn.Text = "Stok Obat";
            this.stok_btn.UseVisualStyleBackColor = true;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.DarkRed;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(10, 442);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(200, 45);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // riwayat_btn
            // 
            this.riwayat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.riwayat_btn.ForeColor = System.Drawing.Color.Black;
            this.riwayat_btn.Location = new System.Drawing.Point(15, 212);
            this.riwayat_btn.Name = "riwayat_btn";
            this.riwayat_btn.Size = new System.Drawing.Size(190, 45);
            this.riwayat_btn.TabIndex = 3;
            this.riwayat_btn.Text = "Riwayat";
            this.riwayat_btn.UseVisualStyleBackColor = true;
            // 
            // transaksi_btn
            // 
            this.transaksi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaksi_btn.ForeColor = System.Drawing.Color.Black;
            this.transaksi_btn.Location = new System.Drawing.Point(15, 361);
            this.transaksi_btn.Name = "transaksi_btn";
            this.transaksi_btn.Size = new System.Drawing.Size(190, 45);
            this.transaksi_btn.TabIndex = 2;
            this.transaksi_btn.Text = "Transaksi";
            this.transaksi_btn.UseVisualStyleBackColor = true;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.Black;
            this.dashboard_btn.Location = new System.Drawing.Point(15, 139);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(190, 45);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OBATIN.Properties.Resources.obatin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.desc_lbl);
            this.panel2.Controls.Add(this.welcome_lbl);
            this.panel2.Location = new System.Drawing.Point(219, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 100);
            this.panel2.TabIndex = 1;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.Color.Teal;
            this.desc_lbl.Location = new System.Drawing.Point(26, 58);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(460, 21);
            this.desc_lbl.TabIndex = 1;
            this.desc_lbl.Text = "Kelola dan pantau aktivitas apotek dengan mudah";
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.ForeColor = System.Drawing.Color.Teal;
            this.welcome_lbl.Location = new System.Drawing.Point(25, 22);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(252, 32);
            this.welcome_lbl.TabIndex = 0;
            this.welcome_lbl.Text = "Selamat Datang ";
            // 
            // totalObat_pnl
            // 
            this.totalObat_pnl.BackColor = System.Drawing.Color.CadetBlue;
            this.totalObat_pnl.Controls.Add(this.total_obat_lbl);
            this.totalObat_pnl.Controls.Add(this.judul_total_obat_lbl);
            this.totalObat_pnl.Location = new System.Drawing.Point(295, 139);
            this.totalObat_pnl.Name = "totalObat_pnl";
            this.totalObat_pnl.Size = new System.Drawing.Size(222, 128);
            this.totalObat_pnl.TabIndex = 2;
            // 
            // total_obat_lbl
            // 
            this.total_obat_lbl.AutoSize = true;
            this.total_obat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_obat_lbl.ForeColor = System.Drawing.Color.White;
            this.total_obat_lbl.Location = new System.Drawing.Point(99, 67);
            this.total_obat_lbl.Name = "total_obat_lbl";
            this.total_obat_lbl.Size = new System.Drawing.Size(25, 26);
            this.total_obat_lbl.TabIndex = 1;
            this.total_obat_lbl.Text = "0";
            // 
            // judul_total_obat_lbl
            // 
            this.judul_total_obat_lbl.AutoSize = true;
            this.judul_total_obat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_total_obat_lbl.ForeColor = System.Drawing.Color.White;
            this.judul_total_obat_lbl.Location = new System.Drawing.Point(60, 20);
            this.judul_total_obat_lbl.Name = "judul_total_obat_lbl";
            this.judul_total_obat_lbl.Size = new System.Drawing.Size(93, 20);
            this.judul_total_obat_lbl.TabIndex = 0;
            this.judul_total_obat_lbl.Text = "Total Obat";
            // 
            // totalStok_pnl
            // 
            this.totalStok_pnl.BackColor = System.Drawing.Color.CadetBlue;
            this.totalStok_pnl.Controls.Add(this.total_stok_lbl);
            this.totalStok_pnl.Controls.Add(this.judul_total_stok_lbl);
            this.totalStok_pnl.Location = new System.Drawing.Point(561, 139);
            this.totalStok_pnl.Name = "totalStok_pnl";
            this.totalStok_pnl.Size = new System.Drawing.Size(223, 128);
            this.totalStok_pnl.TabIndex = 4;
            // 
            // total_stok_lbl
            // 
            this.total_stok_lbl.AutoSize = true;
            this.total_stok_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_stok_lbl.ForeColor = System.Drawing.Color.White;
            this.total_stok_lbl.Location = new System.Drawing.Point(94, 67);
            this.total_stok_lbl.Name = "total_stok_lbl";
            this.total_stok_lbl.Size = new System.Drawing.Size(25, 26);
            this.total_stok_lbl.TabIndex = 2;
            this.total_stok_lbl.Text = "0";
            // 
            // judul_total_stok_lbl
            // 
            this.judul_total_stok_lbl.AutoSize = true;
            this.judul_total_stok_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_total_stok_lbl.ForeColor = System.Drawing.Color.White;
            this.judul_total_stok_lbl.Location = new System.Drawing.Point(61, 20);
            this.judul_total_stok_lbl.Name = "judul_total_stok_lbl";
            this.judul_total_stok_lbl.Size = new System.Drawing.Size(91, 20);
            this.judul_total_stok_lbl.TabIndex = 0;
            this.judul_total_stok_lbl.Text = "Total Stok";
            // 
            // transaksi_pnl
            // 
            this.transaksi_pnl.BackColor = System.Drawing.Color.CadetBlue;
            this.transaksi_pnl.Controls.Add(this.total_transaksi_lbl);
            this.transaksi_pnl.Controls.Add(this.judul_total_transaksi_lbl);
            this.transaksi_pnl.Location = new System.Drawing.Point(295, 298);
            this.transaksi_pnl.Name = "transaksi_pnl";
            this.transaksi_pnl.Size = new System.Drawing.Size(222, 128);
            this.transaksi_pnl.TabIndex = 3;
            // 
            // total_transaksi_lbl
            // 
            this.total_transaksi_lbl.AutoSize = true;
            this.total_transaksi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_transaksi_lbl.ForeColor = System.Drawing.Color.White;
            this.total_transaksi_lbl.Location = new System.Drawing.Point(99, 70);
            this.total_transaksi_lbl.Name = "total_transaksi_lbl";
            this.total_transaksi_lbl.Size = new System.Drawing.Size(25, 26);
            this.total_transaksi_lbl.TabIndex = 4;
            this.total_transaksi_lbl.Text = "0";
            // 
            // judul_total_transaksi_lbl
            // 
            this.judul_total_transaksi_lbl.AutoSize = true;
            this.judul_total_transaksi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_total_transaksi_lbl.ForeColor = System.Drawing.Color.White;
            this.judul_total_transaksi_lbl.Location = new System.Drawing.Point(42, 20);
            this.judul_total_transaksi_lbl.Name = "judul_total_transaksi_lbl";
            this.judul_total_transaksi_lbl.Size = new System.Drawing.Size(131, 20);
            this.judul_total_transaksi_lbl.TabIndex = 0;
            this.judul_total_transaksi_lbl.Text = "Total Transaksi";
            // 
            // penjualan_pnl
            // 
            this.penjualan_pnl.BackColor = System.Drawing.Color.CadetBlue;
            this.penjualan_pnl.Controls.Add(this.total_penjualan_lbl);
            this.penjualan_pnl.Controls.Add(this.judul_total_penjualan_lbl);
            this.penjualan_pnl.Location = new System.Drawing.Point(561, 298);
            this.penjualan_pnl.Name = "penjualan_pnl";
            this.penjualan_pnl.Size = new System.Drawing.Size(223, 128);
            this.penjualan_pnl.TabIndex = 5;
            // 
            // total_penjualan_lbl
            // 
            this.total_penjualan_lbl.AutoSize = true;
            this.total_penjualan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_penjualan_lbl.ForeColor = System.Drawing.Color.White;
            this.total_penjualan_lbl.Location = new System.Drawing.Point(94, 70);
            this.total_penjualan_lbl.Name = "total_penjualan_lbl";
            this.total_penjualan_lbl.Size = new System.Drawing.Size(25, 26);
            this.total_penjualan_lbl.TabIndex = 3;
            this.total_penjualan_lbl.Text = "0";
            // 
            // judul_total_penjualan_lbl
            // 
            this.judul_total_penjualan_lbl.AutoSize = true;
            this.judul_total_penjualan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_total_penjualan_lbl.ForeColor = System.Drawing.Color.White;
            this.judul_total_penjualan_lbl.Location = new System.Drawing.Point(44, 20);
            this.judul_total_penjualan_lbl.Name = "judul_total_penjualan_lbl";
            this.judul_total_penjualan_lbl.Size = new System.Drawing.Size(133, 20);
            this.judul_total_penjualan_lbl.TabIndex = 0;
            this.judul_total_penjualan_lbl.Text = "Total Penjualan";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 506);
            this.Controls.Add(this.penjualan_pnl);
            this.Controls.Add(this.transaksi_pnl);
            this.Controls.Add(this.totalStok_pnl);
            this.Controls.Add(this.totalObat_pnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.totalObat_pnl.ResumeLayout(false);
            this.totalObat_pnl.PerformLayout();
            this.totalStok_pnl.ResumeLayout(false);
            this.totalStok_pnl.PerformLayout();
            this.transaksi_pnl.ResumeLayout(false);
            this.transaksi_pnl.PerformLayout();
            this.penjualan_pnl.ResumeLayout(false);
            this.penjualan_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button riwayat_btn;
        private System.Windows.Forms.Button transaksi_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Panel totalObat_pnl;
        private System.Windows.Forms.Label judul_total_obat_lbl;
        private System.Windows.Forms.Panel totalStok_pnl;
        private System.Windows.Forms.Label judul_total_stok_lbl;
        private System.Windows.Forms.Button stok_btn;
        private System.Windows.Forms.Panel transaksi_pnl;
        private System.Windows.Forms.Label judul_total_transaksi_lbl;
        private System.Windows.Forms.Panel penjualan_pnl;
        private System.Windows.Forms.Label judul_total_penjualan_lbl;
        private System.Windows.Forms.Label total_obat_lbl;
        private System.Windows.Forms.Label total_stok_lbl;
        private System.Windows.Forms.Label total_transaksi_lbl;
        private System.Windows.Forms.Label total_penjualan_lbl;
    }
}