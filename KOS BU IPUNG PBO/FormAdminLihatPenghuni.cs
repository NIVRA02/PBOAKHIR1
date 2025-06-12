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
            string query = @"SELECT 
                                p.id_penghuni AS 'ID Penghuni', 
                                ps.username AS 'Username', 
                                k.nomor_kamar AS 'Nomor Kamar', 
                                p.tanggal_masuk AS 'Tanggal Masuk', 
                                p.tanggal_keluar AS 'Tanggal Keluar'
                            FROM penghuni p
                            JOIN pemesanan ps ON p.id_pemesanan = ps.id_pemesanan
                            JOIN kamar k ON ps.id_kamar = k.id_kamar
                            WHERE p.tanggal_keluar >= GETDATE()"; // Hanya tampilkan penghuni aktif

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
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