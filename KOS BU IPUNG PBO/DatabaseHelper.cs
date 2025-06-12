using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

public static class DatabaseHelper
{
    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["KOS_BU_IPUNG_PBO.Properties.Settings.DatabasePBOConnectionString"].ConnectionString;
    }

    public static void ExecuteNonQuery(string query, SqlParameter[] parameters)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                MessageBox.Show("Operasi gagal karena data duplikat (misalnya, nomor kamar sudah ada).", "Error Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Terjadi error pada database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            throw;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Terjadi error yang tidak terduga: {ex.Message}", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }

    public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        DataTable dt = new DataTable();
        try
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Gagal mengambil data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dt;
    }
}
