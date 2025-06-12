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
    public partial class FormHapusKamar : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;


        public FormHapusKamar()
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
                dataGridHapusKamar.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormHapusKamar_load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputNomorHapus.Text))
            {
                MessageBox.Show("Harap masukkan Nomor Kamar yang akan dihapus.",
                                "Input Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus kamar nomor '{InputNomorHapus.Text}'?",
                                                         "Konfirmasi Hapus",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string connString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

                using (SqlConnection connect = new SqlConnection(connString))
                {
                    string query = "DELETE FROM kamar WHERE nomor_kamar = @nomor";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@nomor", InputNomorHapus.Text);

                        try
                        {
                            connect.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Kamar berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                InputNomorHapus.Clear();
                                LoadKamarData();
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus kamar. Nomor kamar tidak ditemukan.",
                                                "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 547)
                            {
                                MessageBox.Show("Gagal menghapus kamar. Kamar ini sedang digunakan dalam data pemesanan.", "Error Referensi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                MessageBox.Show("Error Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
    }
}
