using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserPesan : Form
    {
        public FrmUserPesan()
        {
            InitializeComponent();
        }

        private void FrmUserPesan_Load(object sender, EventArgs e)
        {
            LoadAvailableRooms();
            ClearDetails();
        }

        private void LoadAvailableRooms()
        {
            string query = "SELECT id_kamar, nomor_kamar FROM kamar WHERE status = 'K' ORDER BY nomor_kamar ASC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            comboNomorKamar.DataSource = dt;
            comboNomorKamar.DisplayMember = "nomor_kamar";
            comboNomorKamar.ValueMember = "id_kamar";
            comboNomorKamar.SelectedIndex = -1;
        }

        private void ClearDetails()
        {
            lblDetailHarga.Text = "-";
            lblDetailTipe.Text = "-";
            lblDetailFasilitas.Text = "-";
            panelDetail.Visible = false;
        }

        private void comboNomorKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNomorKamar.SelectedValue == null)
            {
                ClearDetails();
                return;
            }

            try
            {
                int selectedKamarId = (int)comboNomorKamar.SelectedValue;
                string query = "SELECT harga, tipe_kamar, fasilitas FROM kamar WHERE id_kamar = @idKamar";
                SqlParameter[] parameters = { new SqlParameter("@idKamar", selectedKamarId) };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    decimal harga = Convert.ToDecimal(row["harga"]);
                    lblDetailHarga.Text = harga.ToString("C", CultureInfo.GetCultureInfo("id-ID"));

                    lblDetailTipe.Text = row["tipe_kamar"].ToString();
                    lblDetailFasilitas.Text = row["fasilitas"].ToString();

                    panelDetail.Visible = true;
                }
            }
            catch (Exception)
            {
                ClearDetails();
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (comboNomorKamar.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih kamar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int currentUserId = UserSession.Id;
            string currentUsername = UserSession.Username;
            int selectedKamarId = (int)comboNomorKamar.SelectedValue;
            DateTime bookingDate = datePickerMulaiSewa.Value;

            DialogResult confirm = MessageBox.Show($"Anda akan memesan kamar nomor {comboNomorKamar.Text} untuk tanggal {bookingDate:D}?", "Konfirmasi Pemesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO pemesanan (id, username, id_kamar, tanggal_pemesanan, status_validasi) VALUES (@UserId, @Username, @KamarId, @TanggalPesan, 'P')";
                SqlParameter[] insertParams = {
                    new SqlParameter("@UserId", currentUserId),
                    new SqlParameter("@Username", currentUsername),
                    new SqlParameter("@KamarId", selectedKamarId),
                    new SqlParameter("@TanggalPesan", bookingDate)
                };
                DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                string updateQuery = "UPDATE kamar SET status = 'T' WHERE id_kamar = @KamarId";
                SqlParameter[] updateParams = { new SqlParameter("@KamarId", selectedKamarId) };
                DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                MessageBox.Show("Kamar berhasil dipesan! Mohon tunggu validasi dari admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                new frmMain().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}