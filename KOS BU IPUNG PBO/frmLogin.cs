using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace KOS_BU_IPUNG_PBO
{

    public partial class frmLogin: Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frmRegister = new frmRegister();   
            frmRegister.ShowDialog();

        }

        // Di dalam file: frmLogin.cs

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtPassword.Text == "admin1234")
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide();
            }

            else if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Harap isi Username dan Password.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;
            using (SqlConnection connect = new SqlConnection(connString))
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM admin WHERE username = @user AND passowrd = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@user", txtusername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // --- BARIS PENTING: Memulai Sesi Pengguna ---
                            UserSession.StartSession(txtusername.Text.Trim());
                            // ---------------------------------------------

                            // Arahkan ke form yang sesuai
                            if (txtusername.Text.Trim().ToLower() == "admin")
                            {
                                new FormAdmin().Show();
                            }
                            else
                            {
                                new frmMain().Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi database gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtPassword.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
