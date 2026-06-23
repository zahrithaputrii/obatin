namespace OBATIN.view
{
    partial class FormStokObat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stok_panel = new System.Windows.Forms.Panel();
            this.header_panel = new System.Windows.Forms.Panel();
            this.judul_lbl = new System.Windows.Forms.Label();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.cari_lbl = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.obat_dgv = new System.Windows.Forms.DataGridView();
            this.tambahStok_btn = new System.Windows.Forms.Button();
            this.tambahObat_btn = new System.Windows.Forms.Button();
            this.detailObat_btn = new System.Windows.Forms.Button();
            this.stok_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // stok_panel
            // 
            this.stok_panel.BackColor = System.Drawing.Color.White;
            this.stok_panel.Controls.Add(this.header_panel);
            this.stok_panel.Controls.Add(this.cari_lbl);
            this.stok_panel.Controls.Add(this.cari_txt);
            this.stok_panel.Controls.Add(this.obat_dgv);
            this.stok_panel.Controls.Add(this.tambahStok_btn);
            this.stok_panel.Controls.Add(this.tambahObat_btn);
            this.stok_panel.Controls.Add(this.detailObat_btn);
            this.stok_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stok_panel.Location = new System.Drawing.Point(0, 0);
            this.stok_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stok_panel.Name = "stok_panel";
            this.stok_panel.Size = new System.Drawing.Size(533, 325);
            this.stok_panel.TabIndex = 0;
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.LightCyan;
            this.header_panel.Controls.Add(this.judul_lbl);
            this.header_panel.Controls.Add(this.desc_lbl);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(533, 52);
            this.header_panel.TabIndex = 10;
            // 
            // judul_lbl
            // 
            this.judul_lbl.AutoSize = true;
            this.judul_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.judul_lbl.Location = new System.Drawing.Point(13, 8);
            this.judul_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.judul_lbl.Name = "judul_lbl";
            this.judul_lbl.Size = new System.Drawing.Size(175, 26);
            this.judul_lbl.TabIndex = 0;
            this.judul_lbl.Text = "Data Stok Obat";
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.desc_lbl.Location = new System.Drawing.Point(15, 34);
            this.desc_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(199, 15);
            this.desc_lbl.TabIndex = 1;
            this.desc_lbl.Text = "Kelola dan pantau persediaan obat";
            // 
            // cari_lbl
            // 
            this.cari_lbl.AutoSize = true;
            this.cari_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cari_lbl.Location = new System.Drawing.Point(13, 65);
            this.cari_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cari_lbl.Name = "cari_lbl";
            this.cari_lbl.Size = new System.Drawing.Size(68, 17);
            this.cari_lbl.TabIndex = 3;
            this.cari_lbl.Text = "Cari Obat";
            // 
            // cari_txt
            // 
            this.cari_txt.BackColor = System.Drawing.Color.White;
            this.cari_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cari_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txt.ForeColor = System.Drawing.Color.Black;
            this.cari_txt.Location = new System.Drawing.Point(13, 81);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(507, 26);
            this.cari_txt.TabIndex = 1;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // obat_dgv
            // 
            this.obat_dgv.AllowUserToAddRows = false;
            this.obat_dgv.AllowUserToDeleteRows = false;
            this.obat_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.obat_dgv.BackgroundColor = System.Drawing.Color.White;
            this.obat_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.obat_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.obat_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obat_dgv.EnableHeadersVisualStyles = false;
            this.obat_dgv.Location = new System.Drawing.Point(13, 114);
            this.obat_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obat_dgv.Name = "obat_dgv";
            this.obat_dgv.ReadOnly = true;
            this.obat_dgv.RowHeadersVisible = false;
            this.obat_dgv.RowHeadersWidth = 62;
            this.obat_dgv.RowTemplate.Height = 30;
            this.obat_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.obat_dgv.Size = new System.Drawing.Size(507, 166);
            this.obat_dgv.TabIndex = 4;
            // 
            // tambahStok_btn
            // 
            this.tambahStok_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.tambahStok_btn.FlatAppearance.BorderSize = 0;
            this.tambahStok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahStok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahStok_btn.ForeColor = System.Drawing.Color.White;
            this.tambahStok_btn.Location = new System.Drawing.Point(13, 289);
            this.tambahStok_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tambahStok_btn.Name = "tambahStok_btn";
            this.tambahStok_btn.Size = new System.Drawing.Size(120, 26);
            this.tambahStok_btn.TabIndex = 5;
            this.tambahStok_btn.Text = "TAMBAH STOK";
            this.tambahStok_btn.UseVisualStyleBackColor = false;
            this.tambahStok_btn.Visible = false;
            this.tambahStok_btn.Click += new System.EventHandler(this.tambahStok_btn_Click);
            // 
            // tambahObat_btn
            // 
            this.tambahObat_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.tambahObat_btn.FlatAppearance.BorderSize = 0;
            this.tambahObat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahObat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahObat_btn.ForeColor = System.Drawing.Color.White;
            this.tambahObat_btn.Location = new System.Drawing.Point(140, 289);
            this.tambahObat_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tambahObat_btn.Name = "tambahObat_btn";
            this.tambahObat_btn.Size = new System.Drawing.Size(131, 26);
            this.tambahObat_btn.TabIndex = 6;
            this.tambahObat_btn.Text = "TAMBAH OBAT";
            this.tambahObat_btn.UseVisualStyleBackColor = false;
            this.tambahObat_btn.Visible = false;
            this.tambahObat_btn.Click += new System.EventHandler(this.tambahObat_btn_Click);
            // 
            // detailObat_btn
            // 
            this.detailObat_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.detailObat_btn.FlatAppearance.BorderSize = 0;
            this.detailObat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailObat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailObat_btn.ForeColor = System.Drawing.Color.White;
            this.detailObat_btn.Location = new System.Drawing.Point(295, 289);
            this.detailObat_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailObat_btn.Name = "detailObat_btn";
            this.detailObat_btn.Size = new System.Drawing.Size(120, 26);
            this.detailObat_btn.TabIndex = 7;
            this.detailObat_btn.Text = "DETAIL OBAT";
            this.detailObat_btn.UseVisualStyleBackColor = false;
            this.detailObat_btn.Click += new System.EventHandler(this.detailObat_btn_Click);
            // 
            // FormStokObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 325);
            this.Controls.Add(this.stok_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStokObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Obat - OBATIN";
            this.Load += new System.EventHandler(this.FormStokObat_Load);
            this.stok_panel.ResumeLayout(false);
            this.stok_panel.PerformLayout();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obat_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stok_panel;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label judul_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label cari_lbl;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.DataGridView obat_dgv;
        private System.Windows.Forms.Button tambahStok_btn;
        private System.Windows.Forms.Button tambahObat_btn;
        private System.Windows.Forms.Button detailObat_btn;
    }
}