namespace OBATIN.view
{
    partial class FormObat
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
            this.cariobat_lbl = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.kadaluarsa_dt = new System.Windows.Forms.DateTimePicker();
            this.obat_dgv = new System.Windows.Forms.DataGridView();
            this.stok_txt = new System.Windows.Forms.TextBox();
            this.harga_txt = new System.Windows.Forms.TextBox();
            this.kategori_txt = new System.Windows.Forms.TextBox();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.namaobat_txt = new System.Windows.Forms.TextBox();
            this.kadaluarsa_lbl = new System.Windows.Forms.Label();
            this.stok_lbl = new System.Windows.Forms.Label();
            this.harga_lbl = new System.Windows.Forms.Label();
            this.kategori_lbl = new System.Windows.Forms.Label();
            this.namaobat_lbl = new System.Windows.Forms.Label();
            this.dataobat_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cariobat_lbl);
            this.panel1.Controls.Add(this.cari_txt);
            this.panel1.Controls.Add(this.kadaluarsa_dt);
            this.panel1.Controls.Add(this.obat_dgv);
            this.panel1.Controls.Add(this.stok_txt);
            this.panel1.Controls.Add(this.harga_txt);
            this.panel1.Controls.Add(this.kategori_txt);
            this.panel1.Controls.Add(this.tambah_btn);
            this.panel1.Controls.Add(this.namaobat_txt);
            this.panel1.Controls.Add(this.kadaluarsa_lbl);
            this.panel1.Controls.Add(this.stok_lbl);
            this.panel1.Controls.Add(this.harga_lbl);
            this.panel1.Controls.Add(this.kategori_lbl);
            this.panel1.Controls.Add(this.namaobat_lbl);
            this.panel1.Controls.Add(this.dataobat_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 599);
            this.panel1.TabIndex = 0;
            // 
            // cariobat_lbl
            // 
            this.cariobat_lbl.AutoSize = true;
            this.cariobat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariobat_lbl.ForeColor = System.Drawing.Color.Black;
            this.cariobat_lbl.Location = new System.Drawing.Point(2, 424);
            this.cariobat_lbl.Name = "cariobat_lbl";
            this.cariobat_lbl.Size = new System.Drawing.Size(68, 17);
            this.cariobat_lbl.TabIndex = 21;
            this.cariobat_lbl.Text = "Cari Obat";
            // 
            // cari_txt
            // 
            this.cari_txt.BackColor = System.Drawing.Color.White;
            this.cari_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cari_txt.Location = new System.Drawing.Point(3, 446);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cari_txt.Multiline = true;
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(706, 37);
            this.cari_txt.TabIndex = 20;
            // 
            // kadaluarsa_dt
            // 
            this.kadaluarsa_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kadaluarsa_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kadaluarsa_dt.Location = new System.Drawing.Point(261, 298);
            this.kadaluarsa_dt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kadaluarsa_dt.Name = "kadaluarsa_dt";
            this.kadaluarsa_dt.Size = new System.Drawing.Size(277, 28);
            this.kadaluarsa_dt.TabIndex = 19;
            // 
            // obat_dgv
            // 
            this.obat_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obat_dgv.BackgroundColor = System.Drawing.Color.Silver;
            this.obat_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obat_dgv.Location = new System.Drawing.Point(3, 494);
            this.obat_dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obat_dgv.Name = "obat_dgv";
            this.obat_dgv.RowHeadersVisible = false;
            this.obat_dgv.RowHeadersWidth = 62;
            this.obat_dgv.RowTemplate.Height = 28;
            this.obat_dgv.Size = new System.Drawing.Size(708, 104);
            this.obat_dgv.TabIndex = 18;
            this.obat_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stok_txt
            // 
            this.stok_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stok_txt.Location = new System.Drawing.Point(261, 239);
            this.stok_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stok_txt.Multiline = true;
            this.stok_txt.Name = "stok_txt";
            this.stok_txt.Size = new System.Drawing.Size(277, 37);
            this.stok_txt.TabIndex = 14;
            // 
            // harga_txt
            // 
            this.harga_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.harga_txt.Location = new System.Drawing.Point(261, 180);
            this.harga_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.harga_txt.Multiline = true;
            this.harga_txt.Name = "harga_txt";
            this.harga_txt.Size = new System.Drawing.Size(277, 37);
            this.harga_txt.TabIndex = 13;
            // 
            // kategori_txt
            // 
            this.kategori_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kategori_txt.Location = new System.Drawing.Point(261, 122);
            this.kategori_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kategori_txt.Multiline = true;
            this.kategori_txt.Name = "kategori_txt";
            this.kategori_txt.Size = new System.Drawing.Size(277, 37);
            this.kategori_txt.TabIndex = 12;
            // 
            // tambah_btn
            // 
            this.tambah_btn.BackColor = System.Drawing.Color.Teal;
            this.tambah_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.ForeColor = System.Drawing.Color.White;
            this.tambah_btn.Location = new System.Drawing.Point(429, 355);
            this.tambah_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(112, 45);
            this.tambah_btn.TabIndex = 11;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = false;
            // 
            // namaobat_txt
            // 
            this.namaobat_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namaobat_txt.Location = new System.Drawing.Point(261, 67);
            this.namaobat_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namaobat_txt.Multiline = true;
            this.namaobat_txt.Name = "namaobat_txt";
            this.namaobat_txt.Size = new System.Drawing.Size(277, 37);
            this.namaobat_txt.TabIndex = 6;
            // 
            // kadaluarsa_lbl
            // 
            this.kadaluarsa_lbl.AutoSize = true;
            this.kadaluarsa_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kadaluarsa_lbl.ForeColor = System.Drawing.Color.Black;
            this.kadaluarsa_lbl.Location = new System.Drawing.Point(123, 302);
            this.kadaluarsa_lbl.Name = "kadaluarsa_lbl";
            this.kadaluarsa_lbl.Size = new System.Drawing.Size(93, 20);
            this.kadaluarsa_lbl.TabIndex = 5;
            this.kadaluarsa_lbl.Text = "Kadaluarsa";
            // 
            // stok_lbl
            // 
            this.stok_lbl.AutoSize = true;
            this.stok_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_lbl.ForeColor = System.Drawing.Color.Black;
            this.stok_lbl.Location = new System.Drawing.Point(122, 253);
            this.stok_lbl.Name = "stok_lbl";
            this.stok_lbl.Size = new System.Drawing.Size(42, 20);
            this.stok_lbl.TabIndex = 4;
            this.stok_lbl.Text = "Stok";
            // 
            // harga_lbl
            // 
            this.harga_lbl.AutoSize = true;
            this.harga_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_lbl.ForeColor = System.Drawing.Color.Black;
            this.harga_lbl.Location = new System.Drawing.Point(123, 192);
            this.harga_lbl.Name = "harga_lbl";
            this.harga_lbl.Size = new System.Drawing.Size(55, 20);
            this.harga_lbl.TabIndex = 3;
            this.harga_lbl.Text = "Harga";
            // 
            // kategori_lbl
            // 
            this.kategori_lbl.AutoSize = true;
            this.kategori_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategori_lbl.ForeColor = System.Drawing.Color.Black;
            this.kategori_lbl.Location = new System.Drawing.Point(122, 130);
            this.kategori_lbl.Name = "kategori_lbl";
            this.kategori_lbl.Size = new System.Drawing.Size(71, 20);
            this.kategori_lbl.TabIndex = 2;
            this.kategori_lbl.Text = "Kategori";
            // 
            // namaobat_lbl
            // 
            this.namaobat_lbl.AutoSize = true;
            this.namaobat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaobat_lbl.ForeColor = System.Drawing.Color.Black;
            this.namaobat_lbl.Location = new System.Drawing.Point(124, 77);
            this.namaobat_lbl.Name = "namaobat_lbl";
            this.namaobat_lbl.Size = new System.Drawing.Size(94, 20);
            this.namaobat_lbl.TabIndex = 1;
            this.namaobat_lbl.Text = "Nama Obat";
            // 
            // dataobat_lbl
            // 
            this.dataobat_lbl.AutoSize = true;
            this.dataobat_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataobat_lbl.ForeColor = System.Drawing.Color.Teal;
            this.dataobat_lbl.Location = new System.Drawing.Point(287, 21);
            this.dataobat_lbl.Name = "dataobat_lbl";
            this.dataobat_lbl.Size = new System.Drawing.Size(202, 26);
            this.dataobat_lbl.TabIndex = 0;
            this.dataobat_lbl.Text = "Tambah Stock Obat";
            // 
            // FormObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 599);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormObat";
            this.Text = "FormObat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dataobat_lbl;
        private System.Windows.Forms.Label namaobat_lbl;
        private System.Windows.Forms.TextBox namaobat_txt;
        private System.Windows.Forms.Label kadaluarsa_lbl;
        private System.Windows.Forms.Label stok_lbl;
        private System.Windows.Forms.Label harga_lbl;
        private System.Windows.Forms.Label kategori_lbl;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.TextBox stok_txt;
        private System.Windows.Forms.TextBox harga_txt;
        private System.Windows.Forms.TextBox kategori_txt;
        private System.Windows.Forms.DataGridView obat_dgv;
        private System.Windows.Forms.DateTimePicker kadaluarsa_dt;
        private System.Windows.Forms.Label cariobat_lbl;
        private System.Windows.Forms.TextBox cari_txt;
    }
}