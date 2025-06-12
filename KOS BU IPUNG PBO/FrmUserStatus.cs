using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string query = "SELECT id_kamar, tanggal_pemesanan, status_validasi FROM pemesanan WHERE username = @Username";
            SqlParameter[] parameters = { new SqlParameter("@Username", currentUser) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dataGridStatus.DataSource = dt;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
