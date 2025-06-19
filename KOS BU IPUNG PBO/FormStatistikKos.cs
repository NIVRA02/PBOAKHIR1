using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

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
            int jumlahTerisi = 0;
            int jumlahKosong = 0;
            int totalKamar = 0;
            decimal pendapatanSaatIni = 0;
            decimal potensiPendapatan = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    jumlahTerisi = (int)new SqlCommand("SELECT COUNT(*) FROM kamar WHERE status = 'T'", conn).ExecuteScalar();
                    jumlahKosong = (int)new SqlCommand("SELECT COUNT(*) FROM kamar WHERE status = 'K'", conn).ExecuteScalar();
                    totalKamar = jumlahTerisi + jumlahKosong;

                    object resultPendapatan = new SqlCommand("SELECT SUM(harga) FROM kamar WHERE status = 'T'", conn).ExecuteScalar();
                    if (resultPendapatan != DBNull.Value)
                    {
                        pendapatanSaatIni = Convert.ToDecimal(resultPendapatan);
                    }

                    object resultPotensi = new SqlCommand("SELECT SUM(harga) FROM kamar", conn).ExecuteScalar();
                    if (resultPotensi != DBNull.Value)
                    {
                        potensiPendapatan = Convert.ToDecimal(resultPotensi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat statistik: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Status Kamar", typeof(string));
            dt.Columns.Add("Jumlah", typeof(int));
            dt.Rows.Add("Terisi", jumlahTerisi);
            dt.Rows.Add("Kosong", jumlahKosong);
            dt.Rows.Add("Total Kamar", totalKamar);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();

            if (totalKamar > 0)
            {
                double tingkatHunian = ((double)jumlahTerisi / totalKamar) * 100;
                lblTingkatHunian.Text = $"{tingkatHunian:F2} %";
            }
            else
            {
                lblTingkatHunian.Text = "0.00 %";
            }

            CultureInfo cultureID = new CultureInfo("id-ID");
            lblPendapatanSaatIni.Text = pendapatanSaatIni.ToString("C0", cultureID);
            lblPotensiPendapatan.Text = potensiPendapatan.ToString("C0", cultureID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }
    }
}