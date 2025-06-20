using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormAdminTagihan : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        public FormAdminTagihan()
        {
            InitializeComponent();
        }

        private void FormAdminTagihan_Load(object sender, EventArgs e)
        {
            LoadUnpaidBills();
        }

        private void LoadUnpaidBills()
        {
            string query = @"
                SELECT
                    p.id_pemesanan,
                    p.username,
                    k.nomor_kamar,
                    k.harga,
                    p.tanggal_pemesanan,
                    p.status_validasi
                    FROM
                    pemesanan p JOIN kamar k ON p.id_kamar = k.id_kamar
                    WHERE p.status_validasi = 'A'
                    ORDER BY p.tanggal_pemesanan ASC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvUnpaidBills.DataSource = dt;

            if (dgvUnpaidBills.Columns.Contains("id_pemesanan")) dgvUnpaidBills.Columns["id_pemesanan"].Visible = false;
            if (dgvUnpaidBills.Columns.Contains("username")) dgvUnpaidBills.Columns["username"].HeaderText = "Username";
            if (dgvUnpaidBills.Columns.Contains("nomor_kamar")) dgvUnpaidBills.Columns["nomor_kamar"].HeaderText = "No. Kamar";
            if (dgvUnpaidBills.Columns.Contains("harga")) dgvUnpaidBills.Columns["harga"].HeaderText = "Jumlah Tagihan";
            if (dgvUnpaidBills.Columns.Contains("tanggal_pemesanan")) dgvUnpaidBills.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Tagihan";
            if (dgvUnpaidBills.Columns.Contains("status_validasi")) dgvUnpaidBills.Columns["status_validasi"].HeaderText = "Status";

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnSendWarning_Click_1(object sender, EventArgs e)
        {
            if (dgvUnpaidBills.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Pilih tagihan yang akan dikirim peringatan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }

            foreach (DataGridViewRow row in dgvUnpaidBills.SelectedRows) 
            {
                string username = row.Cells["username"].Value.ToString(); 
                string nomorKamar = row.Cells["nomor_kamar"].Value.ToString(); 
                decimal jumlahTagihan = Convert.ToDecimal(row.Cells["harga"].Value); 

                MessageBox.Show($"Peringatan telah dikirim kepada {username} untuk tagihan kamar {nomorKamar} sejumlah {jumlahTagihan.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID"))}. Harap segera melakukan pembayaran.", 
                                "Peringatan Terkirim", MessageBoxButtons.OK, MessageBoxIcon.Information); 

              
            }
        }
    }
}