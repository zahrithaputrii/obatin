using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.konfigurasi;

namespace OBATIN.view
{
    public partial class FormLogin : Form
    {
        Koneksi kon = new Koneksi();

        public FormLogin()
        {
            InitializeComponent();
            login_btn.Click += login_btn_Click;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim().Replace("'", "''");
            string password = password_txt.Text.Trim().Replace("'", "''");

            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan Password harus diisi!");
                return;
            }

            string query =
                "SELECT * FROM users " +
                "WHERE username='" + username + "' " +
                "AND password='" + password + "'";

            DataTable dt = kon.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                // ambil role dari database
                string role = dt.Rows[0]["role"].ToString();

                MessageBox.Show("Login Berhasil!");

                FormDashboard dash = new FormDashboard(username, role);
                dash.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}