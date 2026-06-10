using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBATIN.konfigurasi;

namespace OBATIN.view
{
    public partial class FormLogin : Form
    {
        private Koneksi kon = new Koneksi();

        public FormLogin()
        {
            InitializeComponent();
            login_btn.Click += login_btn_Click;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = usernzme_txt.Text.Trim().Replace("'", "''");
            string password = password_txt.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'";
            DataTable dt = kon.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FormTransaksi formTransaksi = new FormTransaksi(username);
                formTransaksi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
