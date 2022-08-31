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
                mySqlCommand.Parameters.AddWithValue("Uom_Name", uom.Name);
                mySqlCommand.Parameters.AddWithValue("user_Id", 1);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public List<UOM> GetAllUom()
        {
            var listUom = new List<UOM>();
            MySqlCommand getUomCommand = new MySqlCommand();
            getUomCommand.Connection = Connection.CreateSqlConnection();
            getUomCommand.CommandText = "Select user_Id, Uom_Name from uom";
            getUomCommand.CommandType = System.Data.CommandType.Text;
            var reader = getUomCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listUom.Add(new UOM
                    {
                        Id = reader.GetInt32("user_Id"),
                        Name = reader.GetString("Uom_Name")
                    });
                }
                reader.Close();
            }
            return listUom;
        }
    }
}
