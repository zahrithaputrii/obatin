namespace OBATIN.view
{
    partial class FormRiwayat
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
            this.riwayat_panel = new System.Windows.Forms.Panel();
            this.riwayat_dgv = new System.Windows.Forms.DataGridView();
            this.cari_dt = new System.Windows.Forms.DateTimePicker();
            this.cari_lbl = new System.Windows.Forms.Label();
            this.riwayat_lbl = new System.Windows.Forms.Label();
            this.riwayat_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riwayat_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // riwayat_panel
            // 
            this.riwayat_panel.BackColor = System.Drawing.Color.White;
            this.riwayat_panel.Controls.Add(this.riwayat_dgv);
            this.riwayat_panel.Controls.Add(this.cari_dt);
            this.riwayat_panel.Controls.Add(this.cari_lbl);
            this.riwayat_panel.Controls.Add(this.riwayat_lbl);
            this.riwayat_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riwayat_panel.Location = new System.Drawing.Point(0, 0);
            this.riwayat_panel.Name = "riwayat_panel";
            this.riwayat_panel.Size = new System.Drawing.Size(800, 450);
            this.riwayat_panel.TabIndex = 0;
            // 
            // riwayat_dgv
            // 
            this.riwayat_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.riwayat_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.riwayat_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.riwayat_dgv.GridColor = System.Drawing.Color.Black;
            this.riwayat_dgv.Location = new System.Drawing.Point(45, 179);
            this.riwayat_dgv.Name = "riwayat_dgv";
            this.riwayat_dgv.RowHeadersVisible = false;
            this.riwayat_dgv.RowHeadersWidth = 62;
            this.riwayat_dgv.RowTemplate.Height = 28;
            this.riwayat_dgv.Size = new System.Drawing.Size(721, 259);
            this.riwayat_dgv.TabIndex = 3;
            // 
            // cari_dt
            // 
            this.cari_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_dt.Location = new System.Drawing.Point(44, 129);
            this.cari_dt.Name = "cari_dt";
            this.cari_dt.Size = new System.Drawing.Size(721, 32);
            this.cari_dt.TabIndex = 2;
            // 
            // cari_lbl
            // 
            this.cari_lbl.AutoSize = true;
            this.cari_lbl.Location = new System.Drawing.Point(42, 101);
            this.cari_lbl.Name = "cari_lbl";
            this.cari_lbl.Size = new System.Drawing.Size(98, 20);
            this.cari_lbl.TabIndex = 1;
            this.cari_lbl.Text = "Cari Tanggal";
            // 
            // riwayat_lbl
            // 
            this.riwayat_lbl.AutoSize = true;
            this.riwayat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riwayat_lbl.ForeColor = System.Drawing.Color.Teal;
            this.riwayat_lbl.Location = new System.Drawing.Point(269, 38);
            this.riwayat_lbl.Name = "riwayat_lbl";
            this.riwayat_lbl.Size = new System.Drawing.Size(225, 29);
            this.riwayat_lbl.TabIndex = 0;
            this.riwayat_lbl.Text = "Riwayat Transaksi";
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.riwayat_panel);
            this.Name = "FormRiwayat";
            this.Text = "FormRiwayat";
            this.Load += new System.EventHandler(this.FormRiwayat_Load_1);
            this.riwayat_panel.ResumeLayout(false);
            this.riwayat_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riwayat_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel riwayat_panel;
        private System.Windows.Forms.DateTimePicker cari_dt;
        private System.Windows.Forms.Label cari_lbl;
        private System.Windows.Forms.Label riwayat_lbl;
        private System.Windows.Forms.DataGridView riwayat_dgv;
    }
}