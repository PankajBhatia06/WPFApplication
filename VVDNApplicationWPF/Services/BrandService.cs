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
    public class BrandService
    {
        public bool InsertBrand(Brand brand)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_brand";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("Brand_Name", brand.Name);
                mySqlCommand.Parameters.AddWithValue("user_Id", 1);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public List<Brand> GetAllBrand()
        {
            var listBrand = new List<Brand>();
            MySqlCommand getBrandCommand = new MySqlCommand();
            getBrandCommand.Connection = Connection.CreateSqlConnection();
            getBrandCommand.CommandText = "Select Brand_Id, Brand_Name from brand";
            getBrandCommand.CommandType = System.Data.CommandType.Text;
            var reader = getBrandCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listBrand.Add(new Brand
                    {
                        Id = reader.GetInt32("Brand_Id"),
                        Name = reader.GetString("Brand_Name")
                    });
                }
                reader.Close();
            }
            return listBrand;
        }
    }
}
