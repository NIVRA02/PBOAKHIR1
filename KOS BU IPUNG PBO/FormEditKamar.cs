using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace KOS_BU_IPUNG_PBO
{
    public partial class FormEditKamar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;


        public FormEditKamar()
        {
            InitializeComponent();
            LoadKamarData();
        }

        private void LoadKamarData()
        {
            string connString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;
            using (SqlConnection connect = new SqlConnection(connString))
            {
                string query = "SELECT * FROM kamar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridEditKamar.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormEditKamar_load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
            {
            if (string.IsNullOrWhiteSpace(InputNomorLama.Text) ||
                string.IsNullOrWhiteSpace(InputNomorBaru.Text) ||
                string.IsNullOrWhiteSpace(InputHargaBaru.Text))
            {
                MessageBox.Show("Harap isi semua kolom: Nomor Kamar Lama, Nomor Baru, dan Harga Baru.",
                                "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

            using (SqlConnection connect = new SqlConnection(connString))
            {
                string query = "UPDATE kamar SET nomor_kamar = @nomorBaru, harga = @hargaBaru WHERE nomor_kamar = @nomorLama";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@nomorBaru", InputNomorBaru.Text);
                    cmd.Parameters.AddWithValue("@hargaBaru", int.Parse(InputHargaBaru.Text));
                    cmd.Parameters.AddWithValue("@nomorLama", InputNomorLama.Text);

                    try
                    {
                        connect.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data kamar berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InputNomorLama.Clear();
                            InputNomorBaru.Clear();
                            InputHargaBaru.Clear();
                            LoadKamarData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah data. Pastikan Nomor Kamar Lama yang Anda masukkan sudah benar.",
                                            "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminKelola formAdminKelola = new FormAdminKelola();
            formAdminKelola.Show();
        }

        private void FormEditKamar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
