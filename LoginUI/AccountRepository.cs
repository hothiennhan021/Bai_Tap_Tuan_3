// AccountRepository.cs
using System.Data;
using System.Data.SqlClient;
namespace LoginLogic;
public class AccountRepository
{
    public UserAccount GetAccountByUsername(string username)
    {
        string query = "SELECT * FROM dbo.UserAccounts WHERE Username = @username";

        SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@username", username)
        };

        // Gọi lớp Helper để chạy câu lệnh
        DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

        if (result.Rows.Count > 0)
        {
            DataRow row = result.Rows[0];
            return new UserAccount
            {
                UserId = (int)row["UserId"],
                FullName = row["FullName"].ToString(),
                Username = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                EmailOrPhone = row["EmailOrPhone"].ToString()
            };
        }

        return null;
    }
    public UserAccount GetAccountByEmailOrPhone(string emailOrPhone)
    {
        string query = "SELECT * FROM dbo.UserAccounts WHERE EmailOrPhone = @info";

        SqlParameter[] parameters = new SqlParameter[]
        {
        new SqlParameter("@info", emailOrPhone)
        };

        DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

        if (result.Rows.Count > 0)
        {
            DataRow row = result.Rows[0];
            return new UserAccount
            {
                UserId = (int)row["UserId"],
                FullName = row["FullName"].ToString(),
                Username = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                EmailOrPhone = row["EmailOrPhone"].ToString()
            };
        }

        return null;
    }
}