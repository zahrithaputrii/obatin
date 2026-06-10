namespace OBATIN.view
{
    partial class FormLogin
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
            this.panelkiri = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.usernzme_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.panelkiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelkiri
            // 
            this.panelkiri.BackColor = System.Drawing.Color.LightCyan;
            this.panelkiri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelkiri.Controls.Add(this.logo);
            this.panelkiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelkiri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelkiri.Location = new System.Drawing.Point(0, 0);
            this.panelkiri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelkiri.Name = "panelkiri";
            this.panelkiri.Size = new System.Drawing.Size(282, 315);
            this.panelkiri.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = global::OBATIN.Properties.Resources.obatin;
            this.logo.Location = new System.Drawing.Point(68, 90);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(133, 120);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // usernzme_txt
            // 
            this.usernzme_txt.BackColor = System.Drawing.Color.White;
            this.usernzme_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernzme_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernzme_txt.ForeColor = System.Drawing.Color.Black;
            this.usernzme_txt.Location = new System.Drawing.Point(426, 97);
            this.usernzme_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernzme_txt.Multiline = true;
            this.usernzme_txt.Name = "usernzme_txt";
            this.usernzme_txt.Size = new System.Drawing.Size(242, 32);
            this.usernzme_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.White;
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txt.Location = new System.Drawing.Point(426, 163);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(242, 32);
            this.password_txt.TabIndex = 2;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Teal;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btn.Location = new System.Drawing.Point(426, 241);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(137, 39);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(330, 104);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(70, 16);
            this.username_lbl.TabIndex = 4;
            this.username_lbl.Text = "Username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(334, 170);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(67, 16);
            this.password_lbl.TabIndex = 5;
            this.password_lbl.Text = "Password";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.Teal;
            this.login_lbl.Location = new System.Drawing.Point(428, 36);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(140, 26);
            this.login_lbl.TabIndex = 6;
            this.login_lbl.Text = "Login Apotek";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 315);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.usernzme_txt);
            this.Controls.Add(this.panelkiri);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelkiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelkiri;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox usernzme_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label login_lbl;
    }
}