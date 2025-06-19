using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormTambahKamar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        public FormTambahKamar()
        {
            InitializeComponent();
            LoadKamarData();
        }

        private void LoadKamarData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_kamar, nomor_kamar, harga, tipe_kamar, fasilitas, status FROM kamar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridKamarTambah.DataSource = dt;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputNomorKamar.Text) || string.IsNullOrWhiteSpace(InputHargaKamar.Text) || string.IsNullOrWhiteSpace(txtTipeKamar.Text))
            {
                MessageBox.Show("Nomor, harga, dan tipe kamar tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Kamar (nomor_kamar, harga, status, tipe_kamar, fasilitas) VALUES (@nomor, @harga, 'K', @tipe, @fasilitas)";

            SqlParameter[] parameters = {
                new SqlParameter("@nomor", InputNomorKamar.Text),
                new SqlParameter("@harga", Convert.ToInt32(InputHargaKamar.Text)),
                new SqlParameter("@tipe", txtTipeKamar.Text),
                new SqlParameter("@fasilitas", txtFasilitas.Text)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Kamar berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadKamarData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan kamar. Pastikan nomor kamar belum ada.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            InputNomorKamar.Clear();
            InputHargaKamar.Clear();
            txtTipeKamar.Clear();
            txtFasilitas.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminKelola formAdminKelola = new FormAdminKelola();
            formAdminKelola.Show();
        }
    }
}