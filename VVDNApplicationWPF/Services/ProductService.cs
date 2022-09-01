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
    public  class ProductService
    {
        public bool InsertProduct(ProductModel product)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_product";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("Product_Name", product.Name);
                mySqlCommand.Parameters.AddWithValue("Product_Id", 1);
                mySqlCommand.Parameters.AddWithValue("Brand_Id", product.SelectedBrand);
                mySqlCommand.Parameters.AddWithValue("Category_Id", product.SelectedCategory);
                mySqlCommand.Parameters.AddWithValue("Uom_Id", product.SelectedUom);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true; 
        }


        public List<ProductModel> GetAllProduct()
        {
            var listProduct = new List<ProductModel>();
            MySqlCommand getProductCommand = new MySqlCommand();
            getProductCommand.Connection = Connection.CreateSqlConnection();
            getProductCommand.CommandText = "proc_join_product";
            getProductCommand.CommandType = System.Data.CommandType.StoredProcedure;
            var reader = getProductCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listProduct.Add(new ProductModel
                    {
                        Id = reader.GetInt32("Product_Id"),
                        Name = reader.GetString("Product_Name"),
                        SelectedCategory = reader.GetInt32("Category_Id"),
                        SelectedBrand = reader.GetInt32("Brand_Id"),
                        SelectedUom = reader.GetInt32("Uom_Id")
                    });
                }
                reader.Close();
            }
            return listProduct;
        }
    }
}
