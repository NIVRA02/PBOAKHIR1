using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserStatus : Form
    {
        public FrmUserStatus()
        {
            InitializeComponent();
            LoadBookingStatus();
        }

        private void LoadBookingStatus()
        {
            string currentUser = UserSession.Username;
            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("Sesi tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
                SELECT 
                    p.id_pemesanan,
                    p.id_kamar,
                    k.nomor_kamar, 
                    p.tanggal_pemesanan, 
                    CASE p.status_validasi 
                        WHEN 'P' THEN 'Pending'
                        WHEN 'A' THEN 'Menunggu Pembayaran'
                        WHEN 'L' THEN 'Lunas'
                        WHEN 'T' THEN 'Ditolak'
                        WHEN 'B' THEN 'Dibatalkan'
                        ELSE p.status_validasi 
                    END AS status
                FROM pemesanan p
                JOIN kamar k ON p.id_kamar = k.id_kamar
                WHERE p.username = @Username";

            SqlParameter[] parameters = { new SqlParameter("@Username", currentUser) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dataGridStatus.DataSource = dt;

            if (dataGridStatus.Columns.Contains("id_pemesanan"))
            {
                dataGridStatus.Columns["id_pemesanan"].Visible = false;
            }
            if (dataGridStatus.Columns.Contains("id_kamar"))
            {
                dataGridStatus.Columns["id_kamar"].Visible = false;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (dataGridStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih pesanan yang ingin dibatalkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridStatus.SelectedRows[0];
            int idPemesanan = Convert.ToInt32(selectedRow.Cells["id_pemesanan"].Value);
            int idKamar = Convert.ToInt32(selectedRow.Cells["id_kamar"].Value);

            string statusAsli = GetOriginalStatus(idPemesanan);

            if (statusAsli != "P" && statusAsli != "A")
            {
                MessageBox.Show("Hanya pesanan dengan status 'Pending' atau 'Menunggu Pembayaran' yang dapat dibatalkan.", "Tidak Dapat Dibatalkan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin membatalkan pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string queryUpdateKamar = "UPDATE kamar SET status = 'K' WHERE id_kamar = @id_kamar";
                    DatabaseHelper.ExecuteNonQuery(queryUpdateKamar, new[] { new SqlParameter("@id_kamar", idKamar) });

                    string queryBatalPemesanan = "UPDATE pemesanan SET status_validasi = 'B' WHERE id_pemesanan = @id_pemesanan";
                    DatabaseHelper.ExecuteNonQuery(queryBatalPemesanan, new[] { new SqlParameter("@id_pemesanan", idPemesanan) });

                    MessageBox.Show("Pemesanan berhasil dibatalkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookingStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membatalkan pesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetOriginalStatus(int idPemesanan)
        {
            string status = "";
            string query = "SELECT status_validasi FROM pemesanan WHERE id_pemesanan = @id_pemesanan";
            DataTable dt = DatabaseHelper.ExecuteQuery(query, new[] { new SqlParameter("@id_pemesanan", idPemesanan) });
            if (dt.Rows.Count > 0)
            {
                status = dt.Rows[0]["status_validasi"].ToString();
            }
            return status;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnHubungiAdmin_Click(object sender, EventArgs e)
        {
            if (dataGridStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih pesanan yang ingin Anda diskusikan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPemesanan = Convert.ToInt32(dataGridStatus.SelectedRows[0].Cells["id_pemesanan"].Value);

            FrmKomunikasiUser frmKomunikasi = new FrmKomunikasiUser(idPemesanan);
            frmKomunikasi.ShowDialog();
        }
    }
}