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
using System.Runtime.Remoting.Contexts;

namespace KOS_BU_IPUNG_PBO
{
    public partial class frmRegister: Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\LENOVO\source\repos\PBOAKHIR1\KOS BU IPUNG PBO\DatabasePBO.mdf"";Integrated Security=True;Connect Timeout=30");

        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin")
            {
               MessageBox.Show("You cannot register with admin credentials", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "" || txtusername.Text == ""
             || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string txtcheckusername = "SELECT * FROM admin WHERE username = '"
                            + txtusername.Text.Trim() + "' "; // admin is our table name 

                        using (SqlCommand checckUser = new SqlCommand(txtcheckusername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checckUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 1)
                            {
                                MessageBox.Show(txtusername.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, passowrd, date_created) " +
                                        "VALUES(@email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmLogin lfrmlogin = new frmLogin();
                                    lfrmlogin.Show();
                                    this.Hide();
                                }


                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error coonectiong Database: " + ex, "Error MEssage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
          
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtusername.Text = "";
            txtPassword.Text = "";
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
