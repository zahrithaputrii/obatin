using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormLogin : Form
    {
        // Pakai User_service untuk login
        User_service userService = new User_service();

        public FormLogin()
        {
            InitializeComponent();
            login_btn.Click += login_btn_Click;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim().Replace("'", "''");
            string password = password_txt.Text.Trim().Replace("'", "''");

            // Validasi input tidak boleh kosong
            if (username == "" || password == "")
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cek ke database via service
            DataTable dt = userService.login(username, password);

            if (dt.Rows.Count > 0)
            {
                // Ambil role dari database
                string role = dt.Rows[0]["role"].ToString();

                // Buka dashboard sesuai role
                FormDashboard dash = new FormDashboard(username, role);
                dash.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e) { }
    }
}