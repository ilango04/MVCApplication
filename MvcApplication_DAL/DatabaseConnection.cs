using System.Configuration;
using System.Data.SqlClient;
namespace MvcApplication_DAL
{
    public class DatabaseConnection
    {
        public static SqlConnection GetDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DataConnectivity"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}