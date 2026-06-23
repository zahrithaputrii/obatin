using System;
using System.Data;
using System.Windows.Forms;
using OBATIN.service;

namespace OBATIN.view
{
    public partial class FormStokObat : Form
    {
        // Service untuk mengakses data obat
        Obat_service obatService = new Obat_service();

        // Menyimpan role pengguna yang login
        string role;

        // Constructor menerima role dari FormDashboard
        public FormStokObat(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        // Saat form dibuka
        private void FormStokObat_Load(object sender, EventArgs e)
        {
            // Atur tampilan tombol berdasarkan role
            if (role == "apoteker")
            {
                tambahStok_btn.Visible = true;
                tambahObat_btn.Visible = true;
            }
            else
            {
                tambahStok_btn.Visible = false;
                tambahObat_btn.Visible = false;
                // Geser tombol detail obat ke kiri agar tidak ada ruang kosong
                detailObat_btn.Left = tambahStok_btn.Left;
            }

            // Tampilkan semua data obat
            tampilkanData();
        }

        // Method untuk merapikan nama kolom dan visibilitas
        private void formatColumns()
        {
            if (obat_dgv.Columns["id_obat"] != null)
                obat_dgv.Columns["id_obat"].Visible = false;

            if (obat_dgv.Columns["nama_obat"] != null)
                obat_dgv.Columns["nama_obat"].HeaderText = "Nama Obat";

            if (obat_dgv.Columns["harga"] != null)
                obat_dgv.Columns["harga"].HeaderText = "Harga";

            if (obat_dgv.Columns["stok"] != null)
                obat_dgv.Columns["stok"].HeaderText = "Stok";

            if (obat_dgv.Columns["kategori"] != null)
                obat_dgv.Columns["kategori"].HeaderText = "Kategori";
        }

        // Method untuk menampilkan data ke DataGridView
        private void tampilkanData()
        {
            DataTable dt = obatService.viewAll();
            obat_dgv.DataSource = dt;
            formatColumns();
        }

        // Pencarian obat saat TextBox berubah
        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            string keyword = cari_txt.Text.Trim();

            DataTable dt;

            if (keyword == "")
            {
                // Jika kosong, tampilkan semua data
                dt = obatService.viewAll();
            }
            else
            {
                // Cari berdasarkan nama obat
                dt = obatService.searchByName(keyword);
            }

            obat_dgv.DataSource = dt;
            formatColumns();
        }

        // Tombol Tambah Stok diklik (hanya apoteker)
        private void tambahStok_btn_Click(object sender, EventArgs e)
        {
            // Pastikan ada baris yang dipilih
            if (obat_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih obat terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data dari baris yang dipilih
            DataGridViewRow barisTerpilih = obat_dgv.SelectedRows[0];

            int idObat = Convert.ToInt32(barisTerpilih.Cells["id_obat"].Value);
            string namaObat = barisTerpilih.Cells["nama_obat"].Value.ToString();
            int stokSekarang = Convert.ToInt32(barisTerpilih.Cells["stok"].Value);

            // Dialog untuk input jumlah tambah stok (menggunakan Form WinForms)
            Form dialogForm = new Form();
            dialogForm.Text = "Tambah Stok";
            dialogForm.Width = 380;
            dialogForm.Height = 220;
            dialogForm.StartPosition = FormStartPosition.CenterParent;
            dialogForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialogForm.MaximizeBox = false;
            dialogForm.MinimizeBox = false;

            Label infoLbl = new Label();
            infoLbl.Text = "Nama Obat   : " + namaObat + "\r\nStok Sekarang : " + stokSekarang;
            infoLbl.Location = new System.Drawing.Point(15, 15);
            infoLbl.Size = new System.Drawing.Size(340, 40);
            dialogForm.Controls.Add(infoLbl);

            Label inputLbl = new Label();
            inputLbl.Text = "Jumlah yang ditambahkan:";
            inputLbl.Location = new System.Drawing.Point(15, 65);
            inputLbl.Size = new System.Drawing.Size(200, 20);
            dialogForm.Controls.Add(inputLbl);

            TextBox jumlahTxt = new TextBox();
            jumlahTxt.Text = "0";
            jumlahTxt.Location = new System.Drawing.Point(15, 88);
            jumlahTxt.Size = new System.Drawing.Size(340, 25);
            dialogForm.Controls.Add(jumlahTxt);

            Button simpanBtn = new Button();
            simpanBtn.Text = "Simpan";
            simpanBtn.Location = new System.Drawing.Point(190, 130);
            simpanBtn.Size = new System.Drawing.Size(80, 30);
            simpanBtn.DialogResult = DialogResult.OK;
            dialogForm.Controls.Add(simpanBtn);
            dialogForm.AcceptButton = simpanBtn;

            Button batalBtn = new Button();
            batalBtn.Text = "Batal";
            batalBtn.Location = new System.Drawing.Point(275, 130);
            batalBtn.Size = new System.Drawing.Size(80, 30);
            batalBtn.DialogResult = DialogResult.Cancel;
            dialogForm.Controls.Add(batalBtn);
            dialogForm.CancelButton = batalBtn;

            // Tampilkan dialog
            if (dialogForm.ShowDialog() != DialogResult.OK) return;

            string input = jumlahTxt.Text.Trim();

            // Jika user klik Cancel atau kosong
            if (input == "") return;

            // Validasi input harus angka
            int jumlahTambah;
            if (!int.TryParse(input, out jumlahTambah))
            {
                MessageBox.Show("Jumlah harus berupa angka!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi jumlah harus lebih dari 0
            if (jumlahTambah <= 0)
            {
                MessageBox.Show("Jumlah tambah harus lebih dari 0!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simpan ke database
            int hasil = obatService.tambahStok(idObat, jumlahTambah);

            if (hasil > 0)
            {
                int stokBaru = stokSekarang + jumlahTambah;
                MessageBox.Show(
                    "Stok berhasil ditambahkan!\n\n" +
                    "Nama Obat  : " + namaObat + "\n" +
                    "Stok Lama  : " + stokSekarang + "\n" +
                    "Ditambah   : " + jumlahTambah + "\n" +
                    "Stok Baru  : " + stokBaru,
                    "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView
                tampilkanData();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan stok. Coba lagi.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol Tambah Obat diklik
        private void tambahObat_btn_Click(object sender, EventArgs e)
        {
            FormTambahObat formTambah = new FormTambahObat();
            if (formTambah.ShowDialog() == DialogResult.OK)
            {
                // Refresh data setelah berhasil menambahkan obat baru
                tampilkanData();
            }
        }

        // Tombol Detail Obat diklik
        private void detailObat_btn_Click(object sender, EventArgs e)
        {
            if (obat_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih obat terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow barisTerpilih = obat_dgv.SelectedRows[0];
            int idObat = Convert.ToInt32(barisTerpilih.Cells["id_obat"].Value);
            string namaObat = barisTerpilih.Cells["nama_obat"].Value.ToString();

            FormDetailObat formDetail = new FormDetailObat(idObat, namaObat, role);
            formDetail.ShowDialog();
        }
    }
}
