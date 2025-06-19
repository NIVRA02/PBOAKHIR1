using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormLaporanKeuangan : Form
    {
        public FormLaporanKeuangan()
        {
            InitializeComponent();
        }

        private void FormLaporanKeuangan_Load(object sender, EventArgs e)
        {
            LoadLaporanKeuangan();
        }

        private void LoadLaporanKeuangan()
        {
            DataTable dtLaporan = new DataTable();
            dtLaporan.Columns.Add("Bulan", typeof(string));
            dtLaporan.Columns.Add("Tahun", typeof(int));
            dtLaporan.Columns.Add("Pendapatan", typeof(string));

            decimal totalKeseluruhan = 0;

            string query = @"
                SELECT
                    DATENAME(month, tanggal_pemesanan) AS Bulan,
                    YEAR(tanggal_pemesanan) AS Tahun,
                    SUM(k.harga) AS PendapatanBulanan
                FROM
                    pemesanan p
                JOIN
                    kamar k ON p.id_kamar = k.id_kamar
                WHERE
                    p.status_validasi = 'L' -- UBAH DISINI: dari 'Completed' menjadi 'L' (Lunas)
                GROUP BY
                    DATENAME(month, tanggal_pemesanan), YEAR(tanggal_pemesanan), MONTH(tanggal_pemesanan)
                ORDER BY
                    Tahun, MONTH(tanggal_pemesanan);";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string bulan = reader["Bulan"].ToString();
                            int tahun = Convert.ToInt32(reader["Tahun"]);
                            decimal pendapatan = Convert.ToDecimal(reader["PendapatanBulanan"]);

                            string pendapatanFormatted = pendapatan.ToString("C", CultureInfo.GetCultureInfo("id-ID"));
                            dtLaporan.Rows.Add(bulan, tahun, pendapatanFormatted);

                            totalKeseluruhan += pendapatan;
                        }
                        reader.Close();
                    }
                }
                dataGridViewLaporan.DataSource = dtLaporan;

                lblTotalPendapatan.Text = $"Total Pendapatan Keseluruhan: {totalKeseluruhan.ToString("C", CultureInfo.GetCultureInfo("id-ID"))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat laporan keuangan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }
    }
}