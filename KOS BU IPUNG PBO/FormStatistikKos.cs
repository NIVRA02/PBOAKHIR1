using System;
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
        }

        private void FormStatistikKos_Load(object sender, EventArgs e)
        {
            LoadRoomStatistics();
            LoadFinancialStatistics();
        }

        private void LoadRoomStatistics()
        {
            int totalKamar = 0;
            int kamarTerisi = 0;
            int kamarKosong = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query untuk menghitung kamar terisi (status 'T')
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM kamar WHERE status = 'T'", conn))
                    {
                        kamarTerisi = (int)cmd.ExecuteScalar();
                    }
                    // Query untuk menghitung kamar kosong (status 'K')
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM kamar WHERE status = 'K'", conn))
                    {
                        kamarKosong = (int)cmd.ExecuteScalar();
                    }
                    totalKamar = kamarTerisi + kamarKosong;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil statistik kamar: " + ex.Message, "Error");
                    return;
                }
            }

            // Menampilkan hasil ke Label
            lblKamarTerisi.Text = kamarTerisi.ToString();
            lblKamarKosong.Text = kamarKosong.ToString();
            lblTotalKamar.Text = totalKamar.ToString();

            if (totalKamar > 0)
            {
                double okupansi = ((double)kamarTerisi / totalKamar) * 100;
                lblOkupansi.Text = $"{okupansi:F2} %"; // Format menjadi 2 angka desimal
            }
            else
            {
                lblOkupansi.Text = "0 %";
            }
        }

        private void LoadFinancialStatistics()
        {
            decimal pendapatanAktual = 0;

            // Query untuk menjumlahkan harga dari semua kamar yang terisi (status 'T')
            string query = @"
                SELECT SUM(k.harga) 
                FROM pemesanan p
                JOIN kamar k ON p.id_kamar = k.id_kamar
                WHERE p.status_pembayaran = 'Lunas'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            pendapatanAktual = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil statistik keuangan: " + ex.Message, "Error");
                    return;
                }
            }

            // Menampilkan hasil ke Label dengan format mata uang Rupiah
            lblPendapatanAktual.Text = pendapatanAktual.ToString("C", new System.Globalization.CultureInfo("id-ID"));
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void FormStatistikKos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
