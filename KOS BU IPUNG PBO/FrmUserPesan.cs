using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserPesan : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        public FrmUserPesan()
        {
            InitializeComponent();
            LoadAvailableRooms();
        }

        private void LoadAvailableRooms()
        {
            string query = "SELECT id_kamar, nomor_kamar FROM kamar WHERE status = 'K'";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            comboNomorKamar.DataSource = dt;
            comboNomorKamar.DisplayMember = "nomor_kamar";
            comboNomorKamar.ValueMember = "id_kamar";
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
