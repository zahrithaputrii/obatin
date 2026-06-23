namespace OBATIN.view
{
    partial class FormDetailObat
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
            this.manfaat_lbl = new System.Windows.Forms.Label();
            this.manfaat_txt = new System.Windows.Forms.TextBox();
            this.dosis_lbl = new System.Windows.Forms.Label();
            this.dosis_txt = new System.Windows.Forms.TextBox();
            this.efekSamping_lbl = new System.Windows.Forms.Label();
            this.efekSamping_txt = new System.Windows.Forms.TextBox();
            this.kontraindikasi_lbl = new System.Windows.Forms.Label();
            this.kontraindikasi_txt = new System.Windows.Forms.TextBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.tutup_btn = new System.Windows.Forms.Button();
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
            this.header_pnl.Size = new System.Drawing.Size(520, 80);
            this.header_pnl.TabIndex = 0;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.desc_lbl.Location = new System.Drawing.Point(20, 48);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(370, 22);
            this.desc_lbl.TabIndex = 1;
            this.desc_lbl.Text = "Informasi kegunaan, dosis, dan efek samping";
            // 
            // judul_lbl
            // 
            this.judul_lbl.AutoSize = true;
            this.judul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.judul_lbl.Location = new System.Drawing.Point(18, 12);
            this.judul_lbl.Name = "judul_lbl";
            this.judul_lbl.Size = new System.Drawing.Size(288, 32);
            this.judul_lbl.TabIndex = 0;
            this.judul_lbl.Text = "Detail Informasi Obat";
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
            this.namaObat_txt.BackColor = System.Drawing.SystemColors.Control;
            this.namaObat_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namaObat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaObat_txt.Location = new System.Drawing.Point(24, 120);
            this.namaObat_txt.Name = "namaObat_txt";
            this.namaObat_txt.ReadOnly = true;
            this.namaObat_txt.Size = new System.Drawing.Size(470, 30);
            this.namaObat_txt.TabIndex = 2;
            // 
            // manfaat_lbl
            // 
            this.manfaat_lbl.AutoSize = true;
            this.manfaat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manfaat_lbl.Location = new System.Drawing.Point(20, 160);
            this.manfaat_lbl.Name = "manfaat_lbl";
            this.manfaat_lbl.Size = new System.Drawing.Size(81, 22);
            this.manfaat_lbl.TabIndex = 3;
            this.manfaat_lbl.Text = "Manfaat";
            // 
            // manfaat_txt
            // 
            this.manfaat_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manfaat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manfaat_txt.Location = new System.Drawing.Point(24, 185);
            this.manfaat_txt.Multiline = true;
            this.manfaat_txt.Name = "manfaat_txt";
            this.manfaat_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.manfaat_txt.Size = new System.Drawing.Size(470, 75);
            this.manfaat_txt.TabIndex = 4;
            // 
            // dosis_lbl
            // 
            this.dosis_lbl.AutoSize = true;
            this.dosis_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosis_lbl.Location = new System.Drawing.Point(20, 270);
            this.dosis_lbl.Name = "dosis_lbl";
            this.dosis_lbl.Size = new System.Drawing.Size(60, 22);
            this.dosis_lbl.TabIndex = 5;
            this.dosis_lbl.Text = "Dosis";
            // 
            // dosis_txt
            // 
            this.dosis_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dosis_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosis_txt.Location = new System.Drawing.Point(24, 295);
            this.dosis_txt.Name = "dosis_txt";
            this.dosis_txt.Size = new System.Drawing.Size(470, 30);
            this.dosis_txt.TabIndex = 6;
            // 
            // efekSamping_lbl
            // 
            this.efekSamping_lbl.AutoSize = true;
            this.efekSamping_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efekSamping_lbl.Location = new System.Drawing.Point(20, 335);
            this.efekSamping_lbl.Name = "efekSamping_lbl";
            this.efekSamping_lbl.Size = new System.Drawing.Size(132, 22);
            this.efekSamping_lbl.TabIndex = 7;
            this.efekSamping_lbl.Text = "Efek Samping";
            // 
            // efekSamping_txt
            // 
            this.efekSamping_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.efekSamping_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efekSamping_txt.Location = new System.Drawing.Point(24, 360);
            this.efekSamping_txt.Multiline = true;
            this.efekSamping_txt.Name = "efekSamping_txt";
            this.efekSamping_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.efekSamping_txt.Size = new System.Drawing.Size(470, 75);
            this.efekSamping_txt.TabIndex = 8;
            // 
            // kontraindikasi_lbl
            // 
            this.kontraindikasi_lbl.AutoSize = true;
            this.kontraindikasi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontraindikasi_lbl.Location = new System.Drawing.Point(20, 445);
            this.kontraindikasi_lbl.Name = "kontraindikasi_lbl";
            this.kontraindikasi_lbl.Size = new System.Drawing.Size(135, 22);
            this.kontraindikasi_lbl.TabIndex = 9;
            this.kontraindikasi_lbl.Text = "Kontraindikasi";
            // 
            // kontraindikasi_txt
            // 
            this.kontraindikasi_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kontraindikasi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontraindikasi_txt.Location = new System.Drawing.Point(24, 470);
            this.kontraindikasi_txt.Multiline = true;
            this.kontraindikasi_txt.Name = "kontraindikasi_txt";
            this.kontraindikasi_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kontraindikasi_txt.Size = new System.Drawing.Size(470, 75);
            this.kontraindikasi_txt.TabIndex = 10;
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.simpan_btn.FlatAppearance.BorderSize = 0;
            this.simpan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.ForeColor = System.Drawing.Color.White;
            this.simpan_btn.Location = new System.Drawing.Point(274, 562);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(105, 36);
            this.simpan_btn.TabIndex = 11;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // tutup_btn
            // 
            this.tutup_btn.BackColor = System.Drawing.Color.Gray;
            this.tutup_btn.FlatAppearance.BorderSize = 0;
            this.tutup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutup_btn.ForeColor = System.Drawing.Color.White;
            this.tutup_btn.Location = new System.Drawing.Point(389, 562);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(105, 36);
            this.tutup_btn.TabIndex = 12;
            this.tutup_btn.Text = "Tutup";
            this.tutup_btn.UseVisualStyleBackColor = false;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // FormDetailObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 620);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.kontraindikasi_txt);
            this.Controls.Add(this.kontraindikasi_lbl);
            this.Controls.Add(this.efekSamping_txt);
            this.Controls.Add(this.efekSamping_lbl);
            this.Controls.Add(this.dosis_txt);
            this.Controls.Add(this.dosis_lbl);
            this.Controls.Add(this.manfaat_txt);
            this.Controls.Add(this.manfaat_lbl);
            this.Controls.Add(this.namaObat_txt);
            this.Controls.Add(this.namaObat_lbl);
            this.Controls.Add(this.header_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetailObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail Informasi Obat - OBATIN";
            this.Load += new System.EventHandler(this.FormDetailObat_Load);
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
        private System.Windows.Forms.Label manfaat_lbl;
        private System.Windows.Forms.TextBox manfaat_txt;
        private System.Windows.Forms.Label dosis_lbl;
        private System.Windows.Forms.TextBox dosis_txt;
        private System.Windows.Forms.Label efekSamping_lbl;
        private System.Windows.Forms.TextBox efekSamping_txt;
        private System.Windows.Forms.Label kontraindikasi_lbl;
        private System.Windows.Forms.TextBox kontraindikasi_txt;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button tutup_btn;
    }
}
