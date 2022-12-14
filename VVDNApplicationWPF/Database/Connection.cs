using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Database
{
    public static class Connection
    {
        static MySqlConnection connection;
        public static MySqlConnection CreateSqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["VVDNConnectionString"].ConnectionString;
            if (connection == null)
                connection = new MySqlConnection(connectionString);

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            return connection;
        }
    }
}
