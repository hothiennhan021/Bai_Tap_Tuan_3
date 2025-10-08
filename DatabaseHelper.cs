// DatabaseHelper.cs
using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
    // 1. L?u chu?i k?t n?i ? m?t n?i duy nh?t
    private static string connectionString = @"Data Source=TEN_SERVER;Initial Catalog=USERMANAGEMENT;Integrated Security=True";

    // 2. Ph??ng th?c ?? ch?y các câu l?nh SELECT (tr? v? d? li?u)
    public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
    {
        DataTable dataTable = new DataTable();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    // X? lý l?i
                    Console.WriteLine("L?i DatabaseHelper.ExecuteQuery: " + ex.Message);
                }
            }
        }
        return dataTable;
    }

    // 3. Ph??ng th?c ?? ch?y các câu l?nh INSERT, UPDATE, DELETE (không tr? v? d? li?u)
    public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
    {
        int rowsAffected = 0;
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                try
                {
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // X? lý l?i
                    Console.WriteLine("L?i DatabaseHelper.ExecuteNonQuery: " + ex.Message);
                    rowsAffected = -1; // Tr? v? -1 n?u có l?i
                }
            }
        }
        return rowsAffected;
    }
}