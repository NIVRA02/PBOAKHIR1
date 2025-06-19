using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FrmUserPayment : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        private int selectedPemesananId = -1;
        private int selectedKamarId = -1;
        private DateTime selectedTanggalPesan = DateTime.Now;
        private decimal totalPembayaran = 0;

        public FrmUserPayment()
        {
            InitializeComponent();
        }

        private void FrmUserPayment_Load(object sender, EventArgs e)
        {
            LoadBookingsForPayment();
            ClearSelection();
        }

        private void LoadBookingsForPayment()
        {
            string currentUser = UserSession.Username;
            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("Sesi pengguna tidak ditemukan. Harap login kembali.", "Error Sesi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string query = @"
                SELECT 
                    p.id_pemesanan, 
                    p.id_kamar,
                    k.nomor_kamar, 
                    k.harga,
                    p.tanggal_pemesanan
                FROM pemesanan p
                JOIN kamar k ON p.id_kamar = k.id_kamar
                WHERE p.username = @Username AND p.status_validasi = 'A'";

            SqlParameter[] parameters = { new SqlParameter("@Username", currentUser) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dgvPemesananPending.DataSource = dt;

            if (dgvPemesananPending.Columns.Count > 0)
            {
                dgvPemesananPending.Columns["id_pemesanan"].Visible = false;
                dgvPemesananPending.Columns["id_kamar"].Visible = false;
                dgvPemesananPending.Columns["nomor_kamar"].HeaderText = "Nomor Kamar";
                dgvPemesananPending.Columns["harga"].HeaderText = "Jumlah Tagihan";
                dgvPemesananPending.Columns["tanggal_pemesanan"].HeaderText = "Tanggal Tagihan";
            }
        }

        private void dgvPemesananPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPemesananPending.Rows[e.RowIndex];
                selectedPemesananId = Convert.ToInt32(row.Cells["id_pemesanan"].Value);
                selectedKamarId = Convert.ToInt32(row.Cells["id_kamar"].Value);
                selectedTanggalPesan = Convert.ToDateTime(row.Cells["tanggal_pemesanan"].Value);
                totalPembayaran = Convert.ToDecimal(row.Cells["harga"].Value);

                CultureInfo cultureID = new CultureInfo("id-ID");
                lblTotalPembayaran.Text = $"Total Pembayaran: {totalPembayaran:C0}";
                btnBayar.Enabled = true;
            }
        }

        private void ClearSelection()
        {
            selectedPemesananId = -1;
            selectedKamarId = -1;
            totalPembayaran = 0;
            lblTotalPembayaran.Text = "Total Pembayaran: -";
            cmbMetodePembayaran.SelectedIndex = -1;
            txtJumlahBayar.Clear();
            dgvPemesananPending.ClearSelection();
            btnBayar.Enabled = false;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (selectedPemesananId == -1)
            {
                MessageBox.Show("Harap pilih tagihan yang akan dibayar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMetodePembayaran.SelectedItem == null)
            {
                MessageBox.Show("Harap pilih metode pembayaran.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtJumlahBayar.Text, out decimal jumlahBayar) || jumlahBayar < totalPembayaran)
            {
                MessageBox.Show($"Jumlah bayar tidak valid atau kurang. Harap masukkan minimal {totalPembayaran:C0}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string updatePemesananQuery = "UPDATE pemesanan SET status_validasi = 'L', metode_pembayaran = @Metode, jumlah_bayar = @Jumlah WHERE id_pemesanan = @IdPemesanan";
                SqlParameter[] pemesananParams = {
                    new SqlParameter("@Metode", cmbMetodePembayaran.SelectedItem.ToString()),
                    new SqlParameter("@Jumlah", jumlahBayar),
                    new SqlParameter("@IdPemesanan", selectedPemesananId)
                };
                DatabaseHelper.ExecuteNonQuery(updatePemesananQuery, pemesananParams);

                int penghuniId = 0;
                string queryCekPenghuni = "SELECT id_penghuni FROM penghuni WHERE id_pemesanan IN (SELECT id_pemesanan FROM pemesanan WHERE id = @userId AND id_kamar = @kamarId) AND status_penghuni = 'Aktif'";
                SqlParameter[] cekParams = { new SqlParameter("@userId", UserSession.Id), new SqlParameter("@kamarId", selectedKamarId) };
                DataTable dtPenghuni = DatabaseHelper.ExecuteQuery(queryCekPenghuni, cekParams);

                if (dtPenghuni.Rows.Count > 0)
                {
                    penghuniId = Convert.ToInt32(dtPenghuni.Rows[0]["id_penghuni"]);

                    string queryUpdateTanggal = "UPDATE penghuni SET tanggal_keluar = DATEADD(month, 1, tanggal_keluar) WHERE id_penghuni = @idPenghuni";
                    DatabaseHelper.ExecuteNonQuery(queryUpdateTanggal, new[] { new SqlParameter("@idPenghuni", penghuniId) });

                    MessageBox.Show("Pembayaran perpanjangan sewa berhasil! Masa sewa Anda telah diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DateTime tanggalKeluar = selectedTanggalPesan.AddMonths(1);
                    string insertPenghuniQuery = "INSERT INTO penghuni (id_pemesanan, tanggal_masuk, tanggal_keluar, status_penghuni) VALUES (@IdPemesanan, @TglMasuk, @TglKeluar, 'Aktif')";
                    SqlParameter[] insertParams = {
                        new SqlParameter("@IdPemesanan", selectedPemesananId),
                        new SqlParameter("@TglMasuk", selectedTanggalPesan),
                        new SqlParameter("@TglKeluar", tanggalKeluar)
                    };
                    DatabaseHelper.ExecuteNonQuery(insertPenghuniQuery, insertParams);

                    MessageBox.Show("Pembayaran berhasil! Anda telah resmi menjadi penghuni.", "Pembayaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadBookingsForPayment();
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses pembayaran: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}