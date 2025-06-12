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
                string query = "SELECT * FROM kamar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridKamarTambah.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTambahKamar_load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputNomorKamar.Text) || string.IsNullOrWhiteSpace(InputHargaKamar.Text))
            {
                MessageBox.Show("Nomor kamar dan harga tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

            using (SqlConnection connect = new SqlConnection(connString))
            {
                string query = "INSERT INTO Kamar (nomor_kamar, harga, status) VALUES (@nomor, @harga, @status)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@nomor", InputNomorKamar.Text);
                    cmd.Parameters.AddWithValue("@harga", InputHargaKamar.Text);
                    cmd.Parameters.AddWithValue("@status", "T");

                    try
                    {
                        connect.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kamar berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InputNomorKamar.Clear();
                            InputHargaKamar.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan kamar.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Nomor kamar sudah ada. Silakan gunakan nomor lain.", "Error Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Terjadi error pada database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void FormTambahKamar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
