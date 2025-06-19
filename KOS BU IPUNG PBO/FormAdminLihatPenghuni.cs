using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormAdminLihatPenghuni : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        public FormAdminLihatPenghuni()
        {
            InitializeComponent();
            LoadPenghuniData();
        }

        private void LoadPenghuniData()
        {
            string query = @"
                SELECT 
                    h.id_penghuni, 
                    ps.id AS user_id,
                    ps.id_kamar,
                    ps.username AS 'Username', 
                    k.nomor_kamar AS 'Nomor Kamar', 
                    h.tanggal_masuk AS 'Tanggal Masuk', 
                    h.tanggal_keluar AS 'Tanggal Keluar'
                FROM penghuni h
                JOIN pemesanan ps ON h.id_pemesanan = ps.id_pemesanan
                JOIN kamar k ON ps.id_kamar = k.id_kamar
                WHERE h.status_penghuni = 'Aktif'";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dataGridView1.DataSource = dt;

            if (dataGridView1.Columns.Contains("id_penghuni")) dataGridView1.Columns["id_penghuni"].Visible = false;
            if (dataGridView1.Columns.Contains("user_id")) dataGridView1.Columns["user_id"].Visible = false;
            if (dataGridView1.Columns.Contains("id_kamar")) dataGridView1.Columns["id_kamar"].Visible = false;
        }

        private void btnPerpanjang_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih penghuni yang akan diperpanjang masa sewanya.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
            string username = selectedRow.Cells["Username"].Value.ToString();
            int idKamar = Convert.ToInt32(selectedRow.Cells["id_kamar"].Value);

            DialogResult confirm = MessageBox.Show($"Buat tagihan perpanjangan sewa untuk {username} di kamar {selectedRow.Cells["Nomor Kamar"].Value}?", "Konfirmasi Perpanjangan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "INSERT INTO pemesanan (id, username, id_kamar, tanggal_pemesanan, status_validasi) VALUES (@userId, @username, @idKamar, @tanggalPesan, 'A')";
                    SqlParameter[] parameters = {
                        new SqlParameter("@userId", userId),
                        new SqlParameter("@username", username),
                        new SqlParameter("@idKamar", idKamar),
                        new SqlParameter("@tanggalPesan", DateTime.Now)
                    };
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Tagihan perpanjangan berhasil dibuat. Pengguna dapat melihatnya di menu Pembayaran.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuat tagihan perpanjangan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih penghuni yang akan di-check-out.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int idPenghuni = Convert.ToInt32(selectedRow.Cells["id_penghuni"].Value);
            int idKamar = Convert.ToInt32(selectedRow.Cells["id_kamar"].Value);
            string username = selectedRow.Cells["Username"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Apakah Anda yakin ingin melakukan check-out untuk {username}? Status kamar akan kembali tersedia.", "Konfirmasi Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string queryUpdatePenghuni = "UPDATE penghuni SET status_penghuni = 'Non-Aktif' WHERE id_penghuni = @idPenghuni";
                    DatabaseHelper.ExecuteNonQuery(queryUpdatePenghuni, new[] { new SqlParameter("@idPenghuni", idPenghuni) });

                    string queryUpdateKamar = "UPDATE kamar SET status = 'K' WHERE id_kamar = @idKamar";
                    DatabaseHelper.ExecuteNonQuery(queryUpdateKamar, new[] { new SqlParameter("@idKamar", idKamar) });

                    MessageBox.Show("Proses check-out berhasil.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPenghuniData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal melakukan check-out: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }
    }
}