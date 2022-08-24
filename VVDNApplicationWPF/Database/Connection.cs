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
        public static MySqlConnection CreateSqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["VVDNConnectionString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
