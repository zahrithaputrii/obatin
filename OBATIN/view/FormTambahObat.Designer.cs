namespace OBATIN.view
{
    partial class FormTambahObat
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
            this.header_pnl = new System.Windows.Forms.Panel();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.judul_lbl = new System.Windows.Forms.Label();
            this.namaObat_lbl = new System.Windows.Forms.Label();
            this.namaObat_txt = new System.Windows.Forms.TextBox();
            this.harga_lbl = new System.Windows.Forms.Label();
            this.harga_txt = new System.Windows.Forms.TextBox();
            this.stok_lbl = new System.Windows.Forms.Label();
            this.stok_txt = new System.Windows.Forms.TextBox();
            this.kategori_lbl = new System.Windows.Forms.Label();
            this.kategori_cb = new System.Windows.Forms.ComboBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_pnl
            // 
            this.header_pnl.BackColor = System.Drawing.Color.LightCyan;
            this.header_pnl.Controls.Add(this.desc_lbl);
            this.header_pnl.Controls.Add(this.judul_lbl);
            this.header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_pnl.Location = new System.Drawing.Point(0, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(430, 80);
            this.header_pnl.TabIndex = 0;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.desc_lbl.Location = new System.Drawing.Point(20, 48);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(364, 22);
            this.desc_lbl.TabIndex = 1;
            this.desc_lbl.Text = "Masukkan data obat baru untuk ditambahkan";
            // 
            // judul_lbl
            // 
            this.judul_lbl.AutoSize = true;
            this.judul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.judul_lbl.Location = new System.Drawing.Point(18, 12);
            this.judul_lbl.Name = "judul_lbl";
            this.judul_lbl.Size = new System.Drawing.Size(262, 32);
            this.judul_lbl.TabIndex = 0;
            this.judul_lbl.Text = "Tambah Obat Baru";
            // 
            // namaObat_lbl
            // 
            this.namaObat_lbl.AutoSize = true;
            this.namaObat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaObat_lbl.Location = new System.Drawing.Point(20, 95);
            this.namaObat_lbl.Name = "namaObat_lbl";
            this.namaObat_lbl.Size = new System.Drawing.Size(109, 22);
            this.namaObat_lbl.TabIndex = 1;
            this.namaObat_lbl.Text = "Nama Obat";
            // 
            // namaObat_txt
            // 
            this.namaObat_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namaObat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaObat_txt.Location = new System.Drawing.Point(24, 120);
            this.namaObat_txt.Name = "namaObat_txt";
            this.namaObat_txt.Size = new System.Drawing.Size(380, 30);
            this.namaObat_txt.TabIndex = 2;
            // 
            // harga_lbl
            // 
            this.harga_lbl.AutoSize = true;
            this.harga_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_lbl.Location = new System.Drawing.Point(20, 165);
            this.harga_lbl.Name = "harga_lbl";
            this.harga_lbl.Size = new System.Drawing.Size(108, 22);
            this.harga_lbl.TabIndex = 3;
            this.harga_lbl.Text = "Harga (Rp)";
            // 
            // harga_txt
            // 
            this.harga_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.harga_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_txt.Location = new System.Drawing.Point(24, 190);
            this.harga_txt.Name = "harga_txt";
            this.harga_txt.Size = new System.Drawing.Size(380, 30);
            this.harga_txt.TabIndex = 4;
            // 
            // stok_lbl
            // 
            this.stok_lbl.AutoSize = true;
            this.stok_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_lbl.Location = new System.Drawing.Point(20, 235);
            this.stok_lbl.Name = "stok_lbl";
            this.stok_lbl.Size = new System.Drawing.Size(117, 22);
            this.stok_lbl.TabIndex = 5;
            this.stok_lbl.Text = "Stok Awal";
            // 
            // stok_txt
            // 
            this.stok_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stok_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_txt.Location = new System.Drawing.Point(24, 260);
            this.stok_txt.Name = "stok_txt";
            this.stok_txt.Size = new System.Drawing.Size(380, 30);
            this.stok_txt.TabIndex = 6;
            // 
            // kategori_lbl
            // 
            this.kategori_lbl.AutoSize = true;
            this.kategori_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategori_lbl.Location = new System.Drawing.Point(20, 305);
            this.kategori_lbl.Name = "kategori_lbl";
            this.kategori_lbl.Size = new System.Drawing.Size(85, 22);
            this.kategori_lbl.TabIndex = 7;
            this.kategori_lbl.Text = "Kategori";
            // 
            // kategori_cb
            // 
            this.kategori_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategori_cb.FormattingEnabled = true;
            this.kategori_cb.Location = new System.Drawing.Point(24, 330);
            this.kategori_cb.Name = "kategori_cb";
            this.kategori_cb.Size = new System.Drawing.Size(380, 33);
            this.kategori_cb.TabIndex = 8;
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.simpan_btn.FlatAppearance.BorderSize = 0;
            this.simpan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.ForeColor = System.Drawing.Color.White;
            this.simpan_btn.Location = new System.Drawing.Point(184, 385);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(105, 36);
            this.simpan_btn.TabIndex = 9;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.Color.Gray;
            this.batal_btn.FlatAppearance.BorderSize = 0;
            this.batal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.ForeColor = System.Drawing.Color.White;
            this.batal_btn.Location = new System.Drawing.Point(299, 385);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(105, 36);
            this.batal_btn.TabIndex = 10;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // FormTambahObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 440);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.kategori_cb);
            this.Controls.Add(this.kategori_lbl);
            this.Controls.Add(this.stok_txt);
            this.Controls.Add(this.stok_lbl);
            this.Controls.Add(this.harga_txt);
            this.Controls.Add(this.harga_lbl);
            this.Controls.Add(this.namaObat_txt);
            this.Controls.Add(this.namaObat_lbl);
            this.Controls.Add(this.header_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tambah Obat Baru - OBATIN";
            this.Load += new System.EventHandler(this.FormTambahObat_Load);
            this.header_pnl.ResumeLayout(false);
            this.header_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label judul_lbl;
        private System.Windows.Forms.Label namaObat_lbl;
        private System.Windows.Forms.TextBox namaObat_txt;
        private System.Windows.Forms.Label harga_lbl;
        private System.Windows.Forms.TextBox harga_txt;
        private System.Windows.Forms.Label stok_lbl;
        private System.Windows.Forms.TextBox stok_txt;
        private System.Windows.Forms.Label kategori_lbl;
        private System.Windows.Forms.ComboBox kategori_cb;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button batal_btn;
    }
}
