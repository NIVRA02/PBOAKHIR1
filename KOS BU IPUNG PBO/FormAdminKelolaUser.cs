using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormAdminKelolaUser : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;
        private int selectedUserId = -1; // To store the ID of the selected user for update/delete

        public FormAdminKelolaUser()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void FormAdminKelolaUser_Load(object sender, EventArgs e)
        {
            // Initial data load when the form loads
            LoadUserData();
        }

        private void LoadUserData()
        {
            string query = "SELECT id, email, username, passowrd, date_created FROM admin"; // Select all admin users
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dataGridViewUsers.DataSource = dt;

            // Optional: Hide password column for security
            if (dataGridViewUsers.Columns.Contains("passowrd"))
            {
                dataGridViewUsers.Columns["passowrd"].Visible = false;
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewUsers.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["id"].Value);
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                // For security, do not load password into the textbox
                txtPassword.Text = ""; // Clear password field when selecting a user
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Semua kolom (Username, Email, Password) harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username or email already exists
            string checkQuery = "SELECT COUNT(*) FROM admin WHERE username = @username OR email = @email";
            SqlParameter[] checkParams = {
                new SqlParameter("@username", txtUsername.Text.Trim()),
                new SqlParameter("@email", txtEmail.Text.Trim())
            };

            int existingCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddRange(checkParams);
                        conn.Open();
                        existingCount = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memeriksa data duplikat: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (existingCount > 0)
            {
                MessageBox.Show("Username atau Email sudah terdaftar. Gunakan yang lain.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = "INSERT INTO admin (email, username, passowrd, date_created) VALUES (@email, @username, @password, @date_created)";
            SqlParameter[] parameters = {
                new SqlParameter("@email", txtEmail.Text.Trim()),
                new SqlParameter("@username", txtUsername.Text.Trim()),
                new SqlParameter("@password", txtPassword.Text.Trim()),
                new SqlParameter("@date_created", DateTime.Now)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                MessageBox.Show("Pengguna berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadUserData();
            }
            catch (Exception ex)
            {
                // DatabaseHelper already shows a generic error, but you can add specific handling here if needed
                MessageBox.Show("Gagal menambahkan pengguna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Pilih pengguna yang akan diupdate dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Username dan Email harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = "";
            SqlParameter[] parameters;

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // Update username and email only if password field is empty
                updateQuery = "UPDATE admin SET email = @email, username = @username WHERE id = @id";
                parameters = new SqlParameter[] {
                    new SqlParameter("@email", txtEmail.Text.Trim()),
                    new SqlParameter("@username", txtUsername.Text.Trim()),
                    new SqlParameter("@id", selectedUserId)
                };
            }
            else
            {
                // Update username, email, and password
                updateQuery = "UPDATE admin SET email = @email, username = @username, passowrd = @password WHERE id = @id";
                parameters = new SqlParameter[] {
                    new SqlParameter("@email", txtEmail.Text.Trim()),
                    new SqlParameter("@username", txtUsername.Text.Trim()),
                    new SqlParameter("@password", txtPassword.Text.Trim()),
                    new SqlParameter("@id", selectedUserId)
                };
            }

            try
            {
                DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);
                MessageBox.Show("Pengguna berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate pengguna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Pilih pengguna yang akan dihapus dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUsername.Text.ToLower() == "admin")
            {
                MessageBox.Show("Akun 'admin' tidak bisa dihapus.", "Tidak Diizinkan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult confirmResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus pengguna '{txtUsername.Text}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM admin WHERE id = @id";
                SqlParameter[] parameters = { new SqlParameter("@id", selectedUserId) };

                try
                {
                    DatabaseHelper.ExecuteNonQuery(deleteQuery, parameters);
                    MessageBox.Show("Pengguna berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadUserData();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign Key Violation error number
                    {
                        MessageBox.Show("Tidak dapat menghapus pengguna ini karena terkait dengan data lain (misalnya, pemesanan). Harap hapus data terkait terlebih dahulu.", "Error Integritas Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus pengguna: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus pengguna: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            selectedUserId = -1;
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdminKelola formAdminKelola = new FormAdminKelola();
            formAdminKelola.Show();
            this.Hide();
        }
    }
}