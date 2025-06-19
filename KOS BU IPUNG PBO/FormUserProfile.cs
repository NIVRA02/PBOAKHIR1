using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace KOS_BU_IPUNG_PBO
{
    public partial class FormUserProfil : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;
        private string initialUsername;
        private string initialEmail;

        public FormUserProfil()
        {
            InitializeComponent();
        }

        private void FormUserProfil_Load(object sender, EventArgs e)
        {
            // Tampilkan username dan email dari database ke TextBox
            LoadUserData();
        }

        private void LoadUserData()
        {
            string query = "SELECT username, email, passowrd FROM admin WHERE id = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", UserSession.Id) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                initialUsername = dt.Rows[0]["username"].ToString();
                initialEmail = dt.Rows[0]["email"].ToString();

                txtUsername.Text = initialUsername;
                txtEmail.Text = initialEmail;
            }
            else
            {
                MessageBox.Show("Data pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Tutup form jika data tidak ditemukan
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();
            string newEmail = txtEmail.Text.Trim();
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            // Validasi Input Username dan Email
            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Username dan Email tidak boleh kosong atau hanya berisi spasi.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi Duplikasi Username (jika berubah)
            if (newUsername != initialUsername)
            {
                if (IsUsernameExist(newUsername))
                {
                    MessageBox.Show("Username ini sudah digunakan. Silakan pilih username lain.", "Duplikasi Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validasi Duplikasi Email (jika berubah)
            if (newEmail != initialEmail)
            {
                if (IsEmailExist(newEmail))
                {
                    MessageBox.Show("Email ini sudah digunakan. Silakan gunakan email lain.", "Duplikasi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validasi Password (hanya jika ada perubahan password yang diminta)
            bool passwordChanged = !string.IsNullOrWhiteSpace(newPassword);

            if (passwordChanged)
            {
                if (string.IsNullOrWhiteSpace(oldPassword))
                {
                    MessageBox.Show("Password lama harus diisi untuk mengubah password.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("Password baru dan konfirmasi password tidak cocok.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (newPassword.Length < 6) // Contoh: minimal 6 karakter
                {
                    MessageBox.Show("Password baru minimal 6 karakter.", "Validasi Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string currentDbPassword = GetCurrentPasswordFromDatabase(UserSession.Id);
                if (currentDbPassword == null)
                {
                    MessageBox.Show("Terjadi kesalahan saat mengambil password lama dari database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Karena password di database disimpan sebagai teks biasa (tanpa hashing)
                // maka kita bandingkan langsung.
                if (oldPassword != currentDbPassword)
                {
                    MessageBox.Show("Password lama yang Anda masukkan salah.", "Password Lama Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            // Lakukan Update ke Database
            try
            {
                string updateQuery = "UPDATE admin SET username = @NewUsername, email = @NewEmail";
                if (passwordChanged)
                {
                    updateQuery += ", passowrd = @NewPassword";
                }
                updateQuery += " WHERE id = @UserId";

                SqlParameter[] parameters;
                if (passwordChanged)
                {
                    parameters = new SqlParameter[] {
                        new SqlParameter("@NewUsername", newUsername),
                        new SqlParameter("@NewEmail", newEmail),
                        new SqlParameter("@NewPassword", newPassword),
                        new SqlParameter("@UserId", UserSession.Id)
                    };
                }
                else
                {
                    parameters = new SqlParameter[] {
                        new SqlParameter("@NewUsername", newUsername),
                        new SqlParameter("@NewEmail", newEmail),
                        new SqlParameter("@UserId", UserSession.Id)
                    };
                }

                DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

                // Perbarui sesi pengguna jika username berubah
                if (newUsername != initialUsername)
                {
                    UserSession.StartSession(UserSession.Id, newUsername);
                }

                MessageBox.Show("Profil berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearPasswordFields();
                // Muat ulang data untuk memastikan TextBox menampilkan nilai terbaru jika ada perubahan
                LoadUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui profil: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUsernameExist(string username)
        {
            string query = "SELECT COUNT(*) FROM admin WHERE username = @Username AND id != @UserId";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username),
                new SqlParameter("@UserId", UserSession.Id)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        private bool IsEmailExist(string email)
        {
            string query = "SELECT COUNT(*) FROM admin WHERE email = @Email AND id != @UserId";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", email),
                new SqlParameter("@UserId", UserSession.Id)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        private string GetCurrentPasswordFromDatabase(int userId)
        {
            string query = "SELECT passowrd FROM admin WHERE id = @UserId";
            SqlParameter[] parameters = { new SqlParameter("@UserId", userId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["passowrd"].ToString();
            }
            return null; // Pengguna tidak ditemukan atau password tidak ada
        }

        private void ClearPasswordFields()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtNewPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
            txtConfirmNewPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}