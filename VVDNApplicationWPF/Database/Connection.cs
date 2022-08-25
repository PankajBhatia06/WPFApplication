using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace VVDNApplicationWPF.Database
{
    public static class Connection
    {
      public  static MySqlConnection CreateSqlConnection()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["VVDNConnectionString"].ConnectionString;
            
            MySqlConnection connection = new MySqlConnection();
            connection.Open();
            return connection;
            
        }
    }
}
