namespace OBATIN.view
{
    partial class FormTransaksi
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
            this.transaksi_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.simpannota_btn = new System.Windows.Forms.Button();
            this.byr_lbl = new System.Windows.Forms.Label();
            this.totalbyr_lbl = new System.Windows.Forms.Label();
            this.transaksi_dgv = new System.Windows.Forms.DataGridView();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.jumlah_num = new System.Windows.Forms.NumericUpDown();
            this.harga_txt = new System.Windows.Forms.TextBox();
            this.obat_cb = new System.Windows.Forms.ComboBox();
            this.jmlbeli_lbl = new System.Windows.Forms.Label();
            this.harga_lbl = new System.Windows.Forms.Label();
            this.pilihobat_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tanggal_lbl = new System.Windows.Forms.Label();
            this.kasir_txt = new System.Windows.Forms.TextBox();
            this.nota_txt = new System.Windows.Forms.TextBox();
            this.kasir_lbl = new System.Windows.Forms.Label();
            this.nota_lbl = new System.Windows.Forms.Label();
            this.id_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_beli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksi_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaksi_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_num)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transaksi_panel
            // 
            this.transaksi_panel.Controls.Add(this.panel2);
            this.transaksi_panel.Controls.Add(this.transaksi_dgv);
            this.transaksi_panel.Controls.Add(this.tambah_btn);
            this.transaksi_panel.Controls.Add(this.jumlah_num);
            this.transaksi_panel.Controls.Add(this.harga_txt);
            this.transaksi_panel.Controls.Add(this.obat_cb);
            this.transaksi_panel.Controls.Add(this.jmlbeli_lbl);
            this.transaksi_panel.Controls.Add(this.harga_lbl);
            this.transaksi_panel.Controls.Add(this.pilihobat_lbl);
            this.transaksi_panel.Controls.Add(this.panel1);
            this.transaksi_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaksi_panel.Location = new System.Drawing.Point(0, 0);
            this.transaksi_panel.Name = "transaksi_panel";
            this.transaksi_panel.Size = new System.Drawing.Size(800, 715);
            this.transaksi_panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.simpannota_btn);
            this.panel2.Controls.Add(this.byr_lbl);
            this.panel2.Controls.Add(this.totalbyr_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 116);
            this.panel2.TabIndex = 15;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.Teal;
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(199, 63);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(127, 41);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // simpannota_btn
            // 
            this.simpannota_btn.BackColor = System.Drawing.Color.Teal;
            this.simpannota_btn.ForeColor = System.Drawing.Color.White;
            this.simpannota_btn.Location = new System.Drawing.Point(48, 63);
            this.simpannota_btn.Name = "simpannota_btn";
            this.simpannota_btn.Size = new System.Drawing.Size(127, 41);
            this.simpannota_btn.TabIndex = 2;
            this.simpannota_btn.Text = "Simpan Nota";
            this.simpannota_btn.UseVisualStyleBackColor = false;
            // 
            // byr_lbl
            // 
            this.byr_lbl.AutoSize = true;
            this.byr_lbl.Location = new System.Drawing.Point(151, 28);
            this.byr_lbl.Name = "byr_lbl";
            this.byr_lbl.Size = new System.Drawing.Size(43, 20);
            this.byr_lbl.TabIndex = 1;
            this.byr_lbl.Text = "Rp 0";
            // 
            // totalbyr_lbl
            // 
            this.totalbyr_lbl.AutoSize = true;
            this.totalbyr_lbl.Location = new System.Drawing.Point(44, 28);
            this.totalbyr_lbl.Name = "totalbyr_lbl";
            this.totalbyr_lbl.Size = new System.Drawing.Size(101, 20);
            this.totalbyr_lbl.TabIndex = 0;
            this.totalbyr_lbl.Text = "Total Bayar : ";
            // 
            // transaksi_dgv
            // 
            this.transaksi_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transaksi_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.transaksi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaksi_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_obat,
            this.nama_obat,
            this.harga,
            this.jumlah_beli,
            this.subtotal});
            this.transaksi_dgv.Location = new System.Drawing.Point(50, 353);
            this.transaksi_dgv.Name = "transaksi_dgv";
            this.transaksi_dgv.RowHeadersVisible = false;
            this.transaksi_dgv.RowHeadersWidth = 62;
            this.transaksi_dgv.RowTemplate.Height = 28;
            this.transaksi_dgv.Size = new System.Drawing.Size(728, 211);
            this.transaksi_dgv.TabIndex = 13;
            // 
            // tambah_btn
            // 
            this.tambah_btn.BackColor = System.Drawing.Color.Teal;
            this.tambah_btn.ForeColor = System.Drawing.Color.White;
            this.tambah_btn.Location = new System.Drawing.Point(169, 287);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(99, 38);
            this.tambah_btn.TabIndex = 12;
            this.tambah_btn.Text = "Tambah";
            this.tambah_btn.UseVisualStyleBackColor = false;
            // 
            // jumlah_num
            // 
            this.jumlah_num.Location = new System.Drawing.Point(169, 236);
            this.jumlah_num.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.jumlah_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlah_num.Name = "jumlah_num";
            this.jumlah_num.Size = new System.Drawing.Size(208, 26);
            this.jumlah_num.TabIndex = 11;
            this.jumlah_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // harga_txt
            // 
            this.harga_txt.BackColor = System.Drawing.Color.White;
            this.harga_txt.Location = new System.Drawing.Point(169, 183);
            this.harga_txt.Multiline = true;
            this.harga_txt.Name = "harga_txt";
            this.harga_txt.ReadOnly = true;
            this.harga_txt.Size = new System.Drawing.Size(208, 35);
            this.harga_txt.TabIndex = 10;
            // 
            // obat_cb
            // 
            this.obat_cb.BackColor = System.Drawing.Color.White;
            this.obat_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obat_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obat_cb.FormattingEnabled = true;
            this.obat_cb.Location = new System.Drawing.Point(169, 134);
            this.obat_cb.Name = "obat_cb";
            this.obat_cb.Size = new System.Drawing.Size(208, 30);
            this.obat_cb.TabIndex = 9;
            // 
            // jmlbeli_lbl
            // 
            this.jmlbeli_lbl.AutoSize = true;
            this.jmlbeli_lbl.Location = new System.Drawing.Point(46, 238);
            this.jmlbeli_lbl.Name = "jmlbeli_lbl";
            this.jmlbeli_lbl.Size = new System.Drawing.Size(90, 20);
            this.jmlbeli_lbl.TabIndex = 8;
            this.jmlbeli_lbl.Text = "Jumlah Beli";
            // 
            // harga_lbl
            // 
            this.harga_lbl.AutoSize = true;
            this.harga_lbl.Location = new System.Drawing.Point(46, 190);
            this.harga_lbl.Name = "harga_lbl";
            this.harga_lbl.Size = new System.Drawing.Size(109, 20);
            this.harga_lbl.TabIndex = 7;
            this.harga_lbl.Text = "Harga Satuan";
            // 
            // pilihobat_lbl
            // 
            this.pilihobat_lbl.AutoSize = true;
            this.pilihobat_lbl.Location = new System.Drawing.Point(46, 137);
            this.pilihobat_lbl.Name = "pilihobat_lbl";
            this.pilihobat_lbl.Size = new System.Drawing.Size(76, 20);
            this.pilihobat_lbl.TabIndex = 6;
            this.pilihobat_lbl.Text = "Pilih Obat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.tanggal_lbl);
            this.panel1.Controls.Add(this.kasir_txt);
            this.panel1.Controls.Add(this.nota_txt);
            this.panel1.Controls.Add(this.kasir_lbl);
            this.panel1.Controls.Add(this.nota_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 104);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // tanggal_lbl
            // 
            this.tanggal_lbl.AutoSize = true;
            this.tanggal_lbl.Location = new System.Drawing.Point(357, 22);
            this.tanggal_lbl.Name = "tanggal_lbl";
            this.tanggal_lbl.Size = new System.Drawing.Size(66, 20);
            this.tanggal_lbl.TabIndex = 4;
            this.tanggal_lbl.Text = "Tanggal";
            // 
            // kasir_txt
            // 
            this.kasir_txt.BackColor = System.Drawing.Color.White;
            this.kasir_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kasir_txt.Location = new System.Drawing.Point(105, 64);
            this.kasir_txt.Multiline = true;
            this.kasir_txt.Name = "kasir_txt";
            this.kasir_txt.ReadOnly = true;
            this.kasir_txt.Size = new System.Drawing.Size(129, 26);
            this.kasir_txt.TabIndex = 3;
            // 
            // nota_txt
            // 
            this.nota_txt.BackColor = System.Drawing.Color.White;
            this.nota_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nota_txt.Location = new System.Drawing.Point(105, 20);
            this.nota_txt.Multiline = true;
            this.nota_txt.Name = "nota_txt";
            this.nota_txt.ReadOnly = true;
            this.nota_txt.Size = new System.Drawing.Size(129, 26);
            this.nota_txt.TabIndex = 2;
            // 
            // kasir_lbl
            // 
            this.kasir_lbl.AutoSize = true;
            this.kasir_lbl.Location = new System.Drawing.Point(46, 64);
            this.kasir_lbl.Name = "kasir_lbl";
            this.kasir_lbl.Size = new System.Drawing.Size(44, 20);
            this.kasir_lbl.TabIndex = 1;
            this.kasir_lbl.Text = "Kasir";
            // 
            // nota_lbl
            // 
            this.nota_lbl.AutoSize = true;
            this.nota_lbl.Location = new System.Drawing.Point(23, 20);
            this.nota_lbl.Name = "nota_lbl";
            this.nota_lbl.Size = new System.Drawing.Size(67, 20);
            this.nota_lbl.TabIndex = 0;
            this.nota_lbl.Text = "No Nota";
            // 
            // id_obat
            // 
            this.id_obat.HeaderText = "ID";
            this.id_obat.MinimumWidth = 8;
            this.id_obat.Name = "id_obat";
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "Nama Obat";
            this.nama_obat.MinimumWidth = 8;
            this.nama_obat.Name = "nama_obat";
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 8;
            this.harga.Name = "harga";
            // 
            // jumlah_beli
            // 
            this.jumlah_beli.HeaderText = "Jumlah";
            this.jumlah_beli.MinimumWidth = 8;
            this.jumlah_beli.Name = "jumlah_beli";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 8;
            this.subtotal.Name = "subtotal";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.transaksi_panel);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.transaksi_panel.ResumeLayout(false);
            this.transaksi_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaksi_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah_num)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel transaksi_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kasir_lbl;
        private System.Windows.Forms.Label nota_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label tanggal_lbl;
        private System.Windows.Forms.TextBox kasir_txt;
        private System.Windows.Forms.TextBox nota_txt;
        private System.Windows.Forms.TextBox harga_txt;
        private System.Windows.Forms.ComboBox obat_cb;
        private System.Windows.Forms.Label jmlbeli_lbl;
        private System.Windows.Forms.Label harga_lbl;
        private System.Windows.Forms.Label pilihobat_lbl;
        private System.Windows.Forms.DataGridView transaksi_dgv;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.NumericUpDown jumlah_num;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalbyr_lbl;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button simpannota_btn;
        private System.Windows.Forms.Label byr_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_beli;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}