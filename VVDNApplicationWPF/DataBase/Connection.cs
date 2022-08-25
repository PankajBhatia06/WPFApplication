using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.DataBase
{
    public class Connection
    {
        public static MySqlConnection CreateSqlConnection()
           
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["VVDNConnectionString"].ConnectionString;
            MySqlConnection connection = new MySqlConnection();
            connection.Open();
            return connection;
        }
    }
}
