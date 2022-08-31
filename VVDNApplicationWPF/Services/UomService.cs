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
   public class UomService
   {
        public bool InsertUom(UOM uom)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_uom";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("uom_name", uom.Name);
                mySqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;

            }
            return true;
        }
        

        public List<UOM> GetAllUoms()
        {
            var SelectedUOM = new List<UOM>();
            MySqlCommand getCategoriesCommand = new MySqlCommand();
            getCategoriesCommand.Connection = Connection.CreateSqlConnection();
            getCategoriesCommand.CommandText = "Select ID, UomName from uom";
            getCategoriesCommand.CommandType = System.Data.CommandType.Text;
            var reader = getCategoriesCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    SelectedUOM.Add(new UOM
                    {
                        ID = reader.GetInt32("ID"),
                        Name = reader.GetString("UomName")
                    });
                }
                reader.Close();
            }

            return SelectedUOM;
        }

   }
}
