using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.Services
{
    public class CategoryService
    {
        public bool InsertCategory(Category category)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_category";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("category_name", category.Name);
                mySqlCommand.Parameters.AddWithValue("user_id", 1);
                mySqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
