using MySql.Data.MySqlClient;
using System.Configuration;

namespace BackBone
{
    public class DatabaseConnection
    {
        public MySqlConnection Connection { get; private set; }

        public DatabaseConnection()
        {
            Connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
        }
    }
}
