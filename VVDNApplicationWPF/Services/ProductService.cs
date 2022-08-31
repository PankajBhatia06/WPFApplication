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
   public  class ProductService
   {
        private string proc_getproduct;

        public bool InsertProduct(Product product )
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_product";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("product_name", product.Name);
                mySqlCommand.Parameters.AddWithValue("product_ID", 1);
                mySqlCommand.Parameters.AddWithValue("category_ID", product.SelectedCategory);
                mySqlCommand.Parameters.AddWithValue("UOM_ID", product.SelectedUOMs);
                mySqlCommand.Parameters.AddWithValue("Brand_ID", product.SelectedBrand);
                mySqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public List<Product> GetAllProduct()
        {
            var SelectedProduct = new List<Product>();

            MySqlCommand getCategoriesCommand = new MySqlCommand();
            getCategoriesCommand.Connection = Connection.CreateSqlConnection();
            getCategoriesCommand.CommandText = proc_getproduct;
            getCategoriesCommand.CommandType = System.Data.CommandType.StoredProcedure;
            var reader = getCategoriesCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    SelectedProduct.Add(new Product
                    {
                        ID = reader.GetInt32("product_ID"),
                        Name = reader.GetString("product_Name"),
                        SelectedCategory = reader.GetString("Name"),
                        SelectedBrand = reader.GetString("B_name"),
                        SelectedUOMs = reader.GetString("UomName"),
                        IsAvailable = reader.GetBoolean("Is_Aviable"),
                        OpeningStock=reader.GetDouble("Opening_Stock")
                    
                    });
                }
                reader.Close();
            }

            return SelectedProduct;
        }


    }
}
