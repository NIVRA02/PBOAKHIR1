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

        public FormAdminValidasi()
        {
            InitializeComponent();
            LoadPendingBookings();
        }

        private void LoadPendingBookings()
        {
            string query = @"SELECT 
                                p.id_pemesanan, 
                                p.username, 
                                p.id_kamar,
                                k.nomor_kamar, 
                                p.tanggal_pemesanan, 
                                p.status_validasi 
                            FROM pemesanan p
                            JOIN kamar k ON p.id_kamar = k.id_kamar
                            WHERE p.status_validasi = 'P'";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvPemesanan.DataSource = dt;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (dgvPemesanan.CurrentRow == null)
            {
                MessageBox.Show("Pilih pemesanan yang akan divalidasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pemesananId = Convert.ToInt32(dgvPemesanan.CurrentRow.Cells["id_pemesanan"].Value);
            DateTime tanggalMasuk = Convert.ToDateTime(dgvPemesanan.CurrentRow.Cells["tanggal_pemesanan"].Value);
            DateTime tanggalKeluar = tanggalMasuk.AddMonths(1);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string updatePemesananQuery = "UPDATE pemesanan SET status_validasi = 'S' WHERE id_pemesanan = @PemesananID";
                    DatabaseHelper.ExecuteNonQuery(updatePemesananQuery, new[] { new SqlParameter("@PemesananID", pemesananId) });

                    string insertPenghuniQuery = "INSERT INTO penghuni (id_pemesanan, tanggal_masuk, tanggal_keluar) VALUES (@PemesananID, @TglMasuk, @TglKeluar)";
                    DatabaseHelper.ExecuteNonQuery(insertPenghuniQuery, new[] {
                        new SqlParameter("@PemesananID", pemesananId),
                        new SqlParameter("@TglMasuk", tanggalMasuk),
                        new SqlParameter("@TglKeluar", tanggalKeluar)
                    });

                    transaction.Commit();
                    MessageBox.Show("Pemesanan berhasil divalidasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingBookings();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Gagal memvalidasi pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvPemesanan.CurrentRow == null)
            {
                MessageBox.Show("Pilih pemesanan yang akan ditolak.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pemesananId = Convert.ToInt32(dgvPemesanan.CurrentRow.Cells["id_pemesanan"].Value);
            int kamarId = Convert.ToInt32(dgvPemesanan.CurrentRow.Cells["id_kamar"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string deletePemesananQuery = "DELETE FROM pemesanan WHERE id_pemesanan = @PemesananID";
                    DatabaseHelper.ExecuteNonQuery(deletePemesananQuery, new[] { new SqlParameter("@PemesananID", pemesananId) });

                    string updateKamarQuery = "UPDATE kamar SET status = 'K' WHERE id_kamar = @KamarID";
                    DatabaseHelper.ExecuteNonQuery(updateKamarQuery, new[] { new SqlParameter("@KamarID", kamarId) });

                    transaction.Commit();
                    MessageBox.Show("Pemesanan berhasil ditolak dan kamar kembali tersedia.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingBookings();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Gagal menolak pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }
    }
}