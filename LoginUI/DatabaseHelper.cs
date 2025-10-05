using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseHelper
{
    // Quan trọng: Thay đổi "TEN_SERVER" bằng tên server SQL của bạn
    private static string connectionString = @"Data Source=DESKTOP-R0ML761;Initial Catalog=USERMANAGEMENT;Integrated Security=True";

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
                    // Tạm thời in lỗi ra màn hình console để debug
                    Console.WriteLine("Lỗi DatabaseHelper.ExecuteQuery: " + ex.Message);
                }
            }
        }
        return dataTable;
    }
}