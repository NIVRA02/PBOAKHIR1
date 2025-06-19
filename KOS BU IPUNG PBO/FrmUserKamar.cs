using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserKamar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        public FrmUserKamar()
        {
            InitializeComponent();
            LoadKamarData();
        }

        private void LoadKamarData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT nomor_kamar, harga, tipe_kamar, fasilitas FROM kamar WHERE status = 'K'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                if (dataGridView1.Columns.Contains("fasilitas"))
                {
                    dataGridView1.Columns["fasilitas"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                if (dataGridView1.Columns.Count > 3)
                {
                    dataGridView1.Columns["nomor_kamar"].HeaderText = "Nomor Kamar";
                    dataGridView1.Columns["harga"].HeaderText = "Harga per Bulan";
                    dataGridView1.Columns["tipe_kamar"].HeaderText = "Tipe Kamar";
                    dataGridView1.Columns["fasilitas"].HeaderText = "Fasilitas";
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void FrmUserKamar_Load(object sender, EventArgs e)
        {
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
    }
}