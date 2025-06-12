using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormAdminValidasi : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;
        private int selectedPemesananId = 0;
        private int selectedKamarId = 0;

        public FormAdminValidasi()
        {
            InitializeComponent();
        }

        private void FormAdminValidasi_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadPendingPayments();
        }

        private void SetupDataGridView()
        {
            dataGridViewValidasi.AutoGenerateColumns = false;
            dataGridViewValidasi.Columns.Clear();

            // Menambahkan kolom ke DataGridView
            AddGridColumn("id_pemesanan", "ID Pesanan");
            AddGridColumn("username", "Username");
            AddGridColumn("nomor_kamar", "No. Kamar");
            AddGridColumn("tanggal_pesan", "Tgl. Pesan");
            AddGridColumn("status_pembayaran", "Status");
        }

        private void AddGridColumn(string dataPropertyName, string headerText)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = "col" + dataPropertyName
            };
            dataGridViewValidasi.Columns.Add(column);
        }

        private void LoadPendingPayments()
        {
            string query = @"
                SELECT 
                    p.id_pemesanan,
                    a.username,
                    k.nomor_kamar,
                    p.tanggal_pesan,
                    p.status_pembayaran,
                    p.id_kamar
                FROM pemesanan p
                JOIN admin a ON p.id_admin = a.id
                JOIN kamar k ON p.id_kamar = k.id_kamar
                WHERE p.status_pembayaran = 'Menunggu Validasi'";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    dataGridViewValidasi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearSelectionDetails();
        }

        private void dataGridViewValidasi_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewValidasi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewValidasi.SelectedRows[0];
                selectedPemesananId = Convert.ToInt32(selectedRow.Cells["colid_pemesanan"].Value);
                selectedKamarId = Convert.ToInt32(selectedRow.Cells["id_kamar"].Value); // id_kamar tidak ditampilkan tapi datanya ada

                txtIdPemesanan.Text = selectedRow.Cells["colid_pemesanan"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["colusername"].Value.ToString();
                txtNomorKamar.Text = selectedRow.Cells["colnomor_kamar"].Value.ToString();
                txtTanggalPesan.Text = Convert.ToDateTime(selectedRow.Cells["coltanggal_pesan"].Value).ToString("dd MMMM yyyy");
            }
        }

        private void btnValidasi_Click(object sender, EventArgs e)
        {
            if (selectedPemesananId == 0)
            {
                MessageBox.Show("Pilih pemesanan yang akan divalidasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // 1. Ubah status pembayaran
                    string updatePemesananQuery = "UPDATE pemesanan SET status_pembayaran = 'Lunas' WHERE id_pemesanan = @idPemesanan";
                    using (SqlCommand cmd1 = new SqlCommand(updatePemesananQuery, conn, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@idPemesanan", selectedPemesananId);
                        cmd1.ExecuteNonQuery();
                    }

                    // 2. Ubah status kamar menjadi 'Terisi'
                    string updateKamarQuery = "UPDATE kamar SET status = 'T' WHERE id_kamar = @idKamar";
                    using (SqlCommand cmd2 = new SqlCommand(updateKamarQuery, conn, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@idKamar", selectedKamarId);
                        cmd2.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Pembayaran berhasil divalidasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Gagal melakukan validasi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadPendingPayments();
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            if (selectedPemesananId == 0)
            {
                MessageBox.Show("Pilih pemesanan yang akan ditolak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE pemesanan SET status_pembayaran = 'Ditolak' WHERE id_pemesanan = @idPemesanan";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@idPemesanan", selectedPemesananId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pemesanan telah ditolak.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menolak pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadPendingPayments();
        }

        private void ClearSelectionDetails()
        {
            selectedPemesananId = 0;
            selectedKamarId = 0;
            txtIdPemesanan.Clear();
            txtUsername.Clear();
            txtNomorKamar.Clear();
            txtTanggalPesan.Clear();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void FormAdminValidasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Mengakhiri sesi sebelum keluar
                    UserSession.EndSession();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true; // Batalkan penutupan
                }
            }
        }
    }
}
