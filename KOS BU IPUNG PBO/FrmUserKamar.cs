using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization; // Diperlukan untuk format mata uang

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserKamar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        // --- Palet Warna Desain ---
        private Color primaryColor = Color.FromArgb(116, 86, 174);
        private Color lightPrimaryColor = Color.FromArgb(136, 106, 194);
        private Color formBackColor = Color.FromArgb(245, 245, 245);
        private Color gridHeaderBackColor = Color.FromArgb(116, 86, 174);
        private Color gridAlternatingRowColor = Color.FromArgb(230, 231, 233);

        public FrmUserKamar()
        {
            InitializeComponent();
            ApplyModernStyles(); // Terapkan gaya kustom saat form dibuat
            LoadKamarData();
        }

        private void ApplyModernStyles()
        {
            // 1. Pengaturan Form Utama
            this.BackColor = formBackColor;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Daftar Kamar Kos";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Size = new Size(730, 450); // Menyesuaikan ukuran form

            // 2. Sembunyikan Label Judul Asli
            label1.Visible = false;

            // 3. Membuat Header Panel Kustom
            Panel headerPanel = new Panel();
            headerPanel.BackColor = primaryColor;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;
            this.Controls.Add(headerPanel);

            Label headerLabel = new Label();
            headerLabel.Text = "Daftar Kamar Tersedia";
            headerLabel.ForeColor = Color.White;
            headerLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            headerLabel.Location = new Point(20, 15);
            headerLabel.AutoSize = true;
            headerPanel.Controls.Add(headerLabel);

            // 4. Memberi Gaya pada DataGridView
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false; // Sembunyikan kolom header di kiri
            dataGridView1.EnableHeadersVisualStyles = false; // Izinkan kustomisasi header
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.BackgroundColor = formBackColor; // Samakan dengan latar belakang form

            // Gaya Header Tabel
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = gridHeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 40;

            // Gaya Baris Tabel
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = gridAlternatingRowColor;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dataGridView1.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.RowTemplate.Height = 35;

            // Gaya saat baris dipilih
            dataGridView1.DefaultCellStyle.SelectionBackColor = lightPrimaryColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            // Atur posisi dan ukuran DataGridView
            dataGridView1.Location = new Point(30, 80);
            dataGridView1.Size = new Size(this.Width - 80, this.Height - 190);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 5. Memberi Gaya pada Tombol "Back"
            backButton.BackColor = primaryColor;
            backButton.ForeColor = Color.White;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            backButton.Cursor = Cursors.Hand;
            backButton.Text = "KEMBALI";
            backButton.Size = new Size(150, 40);

            // Atur posisi tombol di kanan bawah
            backButton.Location = new Point(this.Width - backButton.Width - 40, this.Height - backButton.Height - 50);
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // Tambahkan efek hover pada tombol
            backButton.MouseEnter += (sender, e) => backButton.BackColor = lightPrimaryColor;
            backButton.MouseLeave += (sender, e) => backButton.BackColor = primaryColor;
        }

        private void LoadKamarData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Ambil kolom yang relevan dan beri nama alias yang lebih baik
                string query = "SELECT id_kamar AS 'ID', nomor_kamar AS 'Nomor Kamar', harga AS 'Harga per Bulan' FROM kamar WHERE status LIKE 'k'";
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Atur format kolom harga ke Rupiah
                    if (dataGridView1.Columns.Contains("Harga per Bulan"))
                    {
                        dataGridView1.Columns["Harga per Bulan"].DefaultCellStyle.Format = "c0";
                        dataGridView1.Columns["Harga per Bulan"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
                    }

                    // Sembunyikan kolom ID jika tidak ingin ditampilkan ke pengguna
                    if (dataGridView1.Columns.Contains("ID"))
                    {
                        dataGridView1.Columns["ID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        // Event handler di bawah ini bisa dikosongkan jika tidak ada logika khusus
        private void FrmUserKamar_Load(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Hapus event handler ganda jika ada
        // private void backButton_Click(object sender, EventArgs e) { }
    }
}