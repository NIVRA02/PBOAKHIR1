using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormStatistikKos : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        public FormStatistikKos()
        {
            InitializeComponent();
            LoadKamarStatistics();
        }

        private void LoadKamarStatistics()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Status Kamar", typeof(string));
            dt.Columns.Add("Jumlah", typeof(int));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Hitung kamar terisi
                    string queryTerisi = "SELECT COUNT(*) FROM kamar WHERE status = 'T'";
                    SqlCommand cmdTerisi = new SqlCommand(queryTerisi, conn);
                    int jumlahTerisi = (int)cmdTerisi.ExecuteScalar();
                    dt.Rows.Add("Terisi", jumlahTerisi);

                    // Hitung kamar kosong
                    string queryKosong = "SELECT COUNT(*) FROM kamar WHERE status = 'K'";
                    SqlCommand cmdKosong = new SqlCommand(queryKosong, conn);
                    int jumlahKosong = (int)cmdKosong.ExecuteScalar();
                    dt.Rows.Add("Kosong", jumlahKosong);

                    // Hitung total kamar
                    int totalKamar = jumlahTerisi + jumlahKosong;
                    dt.Rows.Add("Total Kamar", totalKamar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat statistik: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}