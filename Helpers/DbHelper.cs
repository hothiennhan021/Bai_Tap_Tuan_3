using System;
using System.Data;
using Microsoft.Data.SqlClient;

public static class DbHelper
{
    private static string connectionString = "Server=localhost;Database=USERMANAGEMENT;Trusted_Connection=True;TrustServerCertificate=True;";

    public static bool IsUsernameExists(string username)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string sql = "SELECT COUNT(*) FROM UserAccounts WHERE Username = @username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }

    public static void InsertUser(string fullname, string emailOrPhone, string username, string passwordHash)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string sql = "INSERT INTO UserAccounts (FullName, EmailOrPhone, Username, Password) VALUES (@f, @e, @u, @p)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@f", fullname);
            cmd.Parameters.AddWithValue("@e", emailOrPhone);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", passwordHash);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static DataRow? GetUserByUsername(string username)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM UserAccounts WHERE Username = @username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}

