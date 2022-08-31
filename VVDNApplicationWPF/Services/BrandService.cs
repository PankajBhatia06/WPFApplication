using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.DataBase;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.Services
{
    public class BrandService
    {
        public bool InsertBrand(Brandswith brandswith)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_brand";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("B_name", brandswith.Name);
                mySqlCommand.Parameters.AddWithValue("ID", 1);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public List<Brandswith> GetAllBrands()
        {
            var SelectedBrandswith = new List<Brandswith>();

            MySqlCommand getCategoriesCommand = new MySqlCommand();
            getCategoriesCommand.Connection = Connection.CreateSqlConnection();
            getCategoriesCommand.CommandText = "Select ID, B_name from brand";
            getCategoriesCommand.CommandType = System.Data.CommandType.Text;
            var reader = getCategoriesCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    SelectedBrandswith.Add(new Brandswith
                    {
                        ID = reader.GetInt32("ID"),
                        Name = reader.GetString("B_name")
                    });
                }
                reader.Close();
            }

            return SelectedBrandswith;
        }
    }
}
