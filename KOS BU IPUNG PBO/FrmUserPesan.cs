using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserPesan : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        private string selectedKamarId = null;
        private string selectedKamarNomor = null;

        private Color primaryColor = Color.FromArgb(116, 86, 174);
        private Color lightPrimaryColor = Color.FromArgb(136, 106, 194);
        private Color formBackColor = Color.FromArgb(245, 245, 245);
        private Color inputBackColor = Color.FromArgb(230, 231, 233);
        private Color darkTextColor = Color.FromArgb(50, 50, 50);

        public FrmUserPesan()
        {
            InitializeComponent();
            ApplyModernStyles();
            LoadAvailableRooms();
        }

        private void ApplyModernStyles()
        {
            // Form
            this.BackColor = formBackColor;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Pesan Kamar";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Size = new Size(800, 600);

            // Header
            Panel headerPanel = new Panel { BackColor = primaryColor, Dock = DockStyle.Top, Height = 60 };
            this.Controls.Add(headerPanel);
            Label headerLabel = new Label
            {
                Text = "Pilih Kamar dan Isi Data Diri",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Location = new Point(20, 15),
                AutoSize = true
            };
            headerPanel.Controls.Add(headerLabel);

            // Styling Judul Daftar Kamar
            lblDaftarKamarTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDaftarKamarTitle.ForeColor = darkTextColor;
            lblDaftarKamarTitle.Location = new Point(30, 80);
            lblDaftarKamarTitle.BackColor = Color.Transparent;

            // Styling DataGridView (Panel Kiri)
            StyleDataGridView(dgvKamar);
            dgvKamar.Location = new Point(30, 110);
            dgvKamar.Size = new Size(340, this.ClientSize.Height - 180);
            dgvKamar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            // Styling Panel Pemesanan (Panel Kanan)
            pnlPemesanan.BackColor = Color.White;
            pnlPemesanan.Location = new Point(400, 80);
            pnlPemesanan.Size = new Size(this.ClientSize.Width - 430, this.ClientSize.Height - 150);
            pnlPemesanan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Styling kontrol di dalam Panel Kanan
            StyleLabel(label1, "Nama Lengkap", 20, 20);
            StyleTextBox(tb_nama, 20, 50);
            StyleLabel(label2, "Nomor Telepon", 20, 100);
            StyleTextBox(tb_nohp, 20, 130);
            StyleLabel(label3, "Alamat Asal", 20, 180);
            StyleTextBox(tb_alamat, 20, 210);
            tb_alamat.Multiline = true;
            tb_alamat.Height = 80;

            StyleLabel(lblSelectedKamar, "Kamar Dipilih:", 20, 310);
            lblSelectedKamarValue.Text = "Belum ada";
            lblSelectedKamarValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSelectedKamarValue.ForeColor = primaryColor;
            lblSelectedKamarValue.Location = new Point(20, 340);

            StyleButton(btnPesan, "PESAN SEKARANG", true);
            btnPesan.Dock = DockStyle.Bottom;
            btnPesan.Height = 50;

            // Terapkan tema pada tombol kembali
            StyleButton(btnKembali, "KEMBALI", false);
            btnKembali.Size = new Size(120, 40);
            btnKembali.Location = new Point(this.ClientSize.Width - 150, this.ClientSize.Height - 60);
            btnKembali.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        // --- Helper Methods untuk Styling ---
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = lightPrimaryColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 40;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void StyleLabel(Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl.ForeColor = darkTextColor;
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
        }

        private void StyleTextBox(TextBox tb, int x, int y)
        {
            tb.Location = new Point(x, y);
            tb.Width = pnlPemesanan.ClientSize.Width - 40;
            tb.BackColor = inputBackColor;
            tb.BorderStyle = BorderStyle.None;
            tb.Font = new Font("Segoe UI", 11F);
        }

        private void StyleButton(Button btn, string text, bool isPrimary)
        {
            btn.Text = text;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            if (isPrimary)
            {
                btn.BackColor = primaryColor;
                btn.ForeColor = Color.White;
                btn.MouseEnter += (s, e) => btn.BackColor = lightPrimaryColor;
                btn.MouseLeave += (s, e) => btn.BackColor = primaryColor;
            }
            else
            {
                btn.BackColor = Color.WhiteSmoke;
                btn.ForeColor = darkTextColor;
                btn.MouseEnter += (s, e) => btn.BackColor = Color.Gainsboro;
                btn.MouseLeave += (s, e) => btn.BackColor = Color.WhiteSmoke;
            }
        }

        // --- Logika Aplikasi ---
        private void LoadAvailableRooms()
        {
            string query = "SELECT id_kamar, nomor_kamar AS 'Nomor Kamar', harga AS 'Harga' FROM kamar WHERE status = 'k' ORDER BY nomor_kamar";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvKamar.DataSource = dt;
                    if (dgvKamar.Columns["Harga"] != null)
                    {
                        dgvKamar.Columns["Harga"].DefaultCellStyle.Format = "c0";
                        dgvKamar.Columns["Harga"].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
                    }
                    if (dgvKamar.Columns["id_kamar"] != null)
                    {
                        dgvKamar.Columns["id_kamar"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat daftar kamar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKamar.Rows[e.RowIndex];
                selectedKamarId = row.Cells["id_kamar"].Value.ToString();
                selectedKamarNomor = row.Cells["Nomor Kamar"].Value.ToString();
                lblSelectedKamarValue.Text = $"Kamar Nomor {selectedKamarNomor}";
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_nama.Text) || string.IsNullOrWhiteSpace(tb_nohp.Text) || string.IsNullOrWhiteSpace(tb_alamat.Text))
            {
                MessageBox.Show("Harap isi semua data diri Anda.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(selectedKamarId))
            {
                MessageBox.Show("Harap pilih kamar dari daftar di sebelah kiri.", "Kamar Belum Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string insertQuery = @"INSERT INTO Pemesanan (nama_pemesan, no_hp, alamat, tanggal_pemesanan, id_kamar, status_pemesanan) VALUES (@nama, @nohp, @alamat, @tanggal, @idkamar, @status)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@nama", tb_nama.Text.Trim());
                        cmd.Parameters.AddWithValue("@nohp", tb_nohp.Text.Trim());
                        cmd.Parameters.AddWithValue("@alamat", tb_alamat.Text.Trim());
                        cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                        cmd.Parameters.AddWithValue("@idkamar", selectedKamarId);
                        cmd.Parameters.AddWithValue("@status", "Menunggu Pembayaran");
                        cmd.ExecuteNonQuery();
                    }

                    string updateQuery = "UPDATE kamar SET status = 't' WHERE id_kamar = @idkamar_update";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@idkamar_update", selectedKamarId);
                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show($"Pemesanan untuk Kamar {selectedKamarNomor} berhasil! Silakan segera lakukan pembayaran.", "Pemesanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    new frmMain().Show();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Terjadi kesalahan saat memproses pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler untuk tombol kembali
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }

        private void FrmUserPesan_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}