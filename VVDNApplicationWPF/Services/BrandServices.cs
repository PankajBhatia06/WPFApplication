using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using MySql.Data.MySqlClient;
using VVDNApplicationWPF.Database;

namespace VVDNApplicationWPF.Services
{
    public class BrandServices
    {
        public bool InsertBrand( Brand brand)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_Brand";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("Brand_name", brand.Name);
                mySqlCommand.Parameters.AddWithValue("Brand_id", brand.Id);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public List<Category> GetAllCategories()
        {
            var listCategories = new List<Category>();

            MySqlCommand getCategoriesCommand = new MySqlCommand();
            getCategoriesCommand.Connection = Connection.CreateSqlConnection();
            getCategoriesCommand.CommandText = "Select ID, CategoryName from categories";
            getCategoriesCommand.CommandType = System.Data.CommandType.Text;
            var reader = getCategoriesCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listCategories.Add(new Category
                    {
                        Id = reader.GetInt32("ID"),
                        Name = reader.GetString("CategoryName")
                    });
                }
                reader.Close();
            }

            return listCategories;
        }
    }
}
