using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserPayment : Form
    {
        private int selectedPemesananId = -1;
        private decimal totalPembayaran = 0;

        public FrmUserPayment()
        {
            InitializeComponent();
            LoadPendingBookingsForUser();
        }

        private void LoadPendingBookingsForUser()
        {
            string currentUser = UserSession.Username; // Assuming UserSession.Username holds the logged-in username
            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("Sesi pengguna tidak ditemukan. Harap login kembali.", "Error Sesi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"SELECT 
                                p.id_pemesanan, 
                                k.nomor_kamar, 
                                k.harga,
                                p.tanggal_pemesanan
                            FROM pemesanan p
                            JOIN kamar k ON p.id_kamar = k.id_kamar
                            WHERE p.username = @Username AND p.status_validasi = 'P'"; // 'P' for Pending

            SqlParameter[] parameters = { new SqlParameter("@Username", currentUser) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dgvPemesananPending.DataSource = dt;

            // Hide the ID column
            if (dgvPemesananPending.Columns.Contains("id_pemesanan"))
            {
                dgvPemesananPending.Columns["id_pemesanan"].Visible = false;
            }
        }

        private void dgvPemesananPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPemesananPending.Rows[e.RowIndex];
                selectedPemesananId = Convert.ToInt32(row.Cells["id_pemesanan"].Value);
                totalPembayaran = Convert.ToDecimal(row.Cells["harga"].Value);
                lblTotalPembayaran.Text = $"Total Pembayaran: Rp {totalPembayaran:N0}";
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (selectedPemesananId == -1)
            {
                MessageBox.Show("Harap pilih pemesanan yang akan dibayar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMetodePembayaran.SelectedItem == null)
            {
                MessageBox.Show("Harap pilih metode pembayaran.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtJumlahBayar.Text, out decimal jumlahBayar))
            {
                MessageBox.Show("Jumlah bayar tidak valid. Harap masukkan angka.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (jumlahBayar < totalPembayaran)
            {
                MessageBox.Show($"Jumlah pembayaran kurang. Total yang harus dibayar Rp {totalPembayaran:N0}.", "Pembayaran Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string metodePembayaran = cmbMetodePembayaran.SelectedItem.ToString();

            // In a real application, you would integrate with a payment gateway here.
            // For this example, we'll simply update the status to 'Completed' and add payment details.

            try
            {
                string updatePemesananQuery = "UPDATE pemesanan SET status_validasi = 'Completed', metode_pembayaran = @MetodePembayaran, jumlah_bayar = @JumlahBayar WHERE id_pemesanan = @PemesananID";
                SqlParameter[] updateParams = {
                    new SqlParameter("@MetodePembayaran", metodePembayaran),
                    new SqlParameter("@JumlahBayar", jumlahBayar),
                    new SqlParameter("@PemesananID", selectedPemesananId)
                };
                DatabaseHelper.ExecuteNonQuery(updatePemesananQuery, updateParams);

                MessageBox.Show("Pembayaran berhasil diproses! Status pemesanan Anda telah diperbarui.", "Pembayaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPendingBookingsForUser(); // Reload data after payment
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses pembayaran: " + ex.Message, "Error Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            selectedPemesananId = -1;
            totalPembayaran = 0;
            lblTotalPembayaran.Text = "Total Pembayaran: Rp 0";
            cmbMetodePembayaran.SelectedIndex = -1;
            txtJumlahBayar.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void FrmUserPayment_Load(object sender, EventArgs e)
        {
            // Any initialization needed when the form loads, if not already done in the constructor
        }
    }
}