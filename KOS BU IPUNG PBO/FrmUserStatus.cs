using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserStatus : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        // Palet Warna
        private Color primaryColor = Color.FromArgb(116, 86, 174);
        private Color formBackColor = Color.FromArgb(245, 245, 245);
        private Color darkTextColor = Color.FromArgb(50, 50, 50);

        public FrmUserStatus()
        {
            InitializeComponent();
            ApplyModernStyles();
            LoadPemesananData();
        }

        private void ApplyModernStyles()
        {
            // Form
            this.BackColor = formBackColor;
            this.Text = "Status Pemesanan Anda";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.ClientSize = new Size(450, 420);

            // Header
            Panel headerPanel = new Panel { BackColor = primaryColor, Dock = DockStyle.Top, Height = 60 };
            this.Controls.Add(headerPanel);
            Label headerLabel = new Label
            {
                Text = "Status Pemesanan",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Location = new Point(20, 15),
                AutoSize = true
            };
            headerPanel.Controls.Add(headerLabel);

            // Panel Detail
            pnlDetails.BackColor = Color.White;
            pnlDetails.Location = new Point(25, 80);
            pnlDetails.Size = new Size(this.ClientSize.Width - 50, 250);

            // Panel Tidak Ditemukan
            pnlNotFound.Location = pnlDetails.Location;
            pnlNotFound.Size = pnlDetails.Size;
            pnlNotFound.BackColor = Color.White;
            labelNotFound.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            labelNotFound.ForeColor = darkTextColor;

            // Labels
            var labels = new[] { label1, label2, label3, label4, label5 };
            foreach (var lbl in labels)
            {
                lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                lbl.ForeColor = darkTextColor;
            }

            var valueLabels = new[] { lblNamaValue, lblNoKamarValue, lblTglPesanValue, lblHargaValue, lblStatusValue };
            foreach (var lbl in valueLabels)
            {
                lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                lbl.ForeColor = darkTextColor;
            }

            lblStatusValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Tombol Kembali
            StyleButton(btnKembali, "KEMBALI", false);
            btnKembali.Location = new Point(pnlDetails.Left, pnlDetails.Bottom + 15);
            btnKembali.Width = pnlDetails.Width;
        }

        private void StyleButton(Button btn, string text, bool isPrimary)
        {
            btn.Text = text;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Height = 40;
            // ... (logika style tombol lainnya jika ada)
        }

        private void LoadPemesananData()
        {
            // Ambil username dari sesi
            string username = UserSession.Username;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Sesi tidak ditemukan. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlDetails.Visible = false;
                pnlNotFound.Visible = true;
                return;
            }

            // Catatan: Desain saat ini mengasumsikan 'nama_pemesan' sama dengan 'username'.
            // Idealnya, tabel Pemesanan memiliki kolom id_user yang berelasi ke tabel admin.
            string query = @"SELECT p.nama_pemesan, p.tanggal_pemesanan, p.status_pemesanan, 
                                    k.nomor_kamar, k.harga 
                             FROM Pemesanan p
                             JOIN kamar k ON p.id_kamar = k.id_kamar
                             WHERE p.nama_pemesan = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Data ditemukan, tampilkan di panel detail
                                pnlDetails.Visible = true;
                                pnlNotFound.Visible = false;

                                lblNamaValue.Text = reader["nama_pemesan"].ToString();
                                lblNoKamarValue.Text = reader["nomor_kamar"].ToString();

                                DateTime tglPesan = (DateTime)reader["tanggal_pemesanan"];
                                lblTglPesanValue.Text = tglPesan.ToString("dd MMMM yyyy, HH:mm");

                                decimal harga = (decimal)reader["harga"];
                                lblHargaValue.Text = harga.ToString("C0", new CultureInfo("id-ID"));

                                lblStatusValue.Text = reader["status_pemesanan"].ToString();
                                // Beri warna pada status untuk kejelasan
                                if (lblStatusValue.Text.ToLower().Contains("lunas"))
                                {
                                    lblStatusValue.ForeColor = Color.MediumSeaGreen;
                                }
                                else
                                {
                                    lblStatusValue.ForeColor = Color.DarkOrange;
                                }
                            }
                            else
                            {
                                // Data tidak ditemukan
                                pnlDetails.Visible = false;
                                pnlNotFound.Visible = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data status: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnlDetails.Visible = false;
                    pnlNotFound.Visible = true;
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }
    }
}