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
    public class StateService
    {
        public bool InsertState(State state)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_state";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("State_Name", state.StateName);
                mySqlCommand.Parameters.AddWithValue("user_Id", 1);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public List<State> GetAllState()
        {
            var listState = new List<State>();
            MySqlCommand getStateCommand = new MySqlCommand();
            getStateCommand.Connection = Connection.CreateSqlConnection();
            getStateCommand.CommandText = "Select StateId, StateName from State";
            getStateCommand.CommandType = System.Data.CommandType.Text;
            var reader = getStateCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listState.Add(new State
                    {
                        StateId = reader.GetInt32("StateId"),
                        StateName = reader.GetString("StateName")
                    });
                }
                reader.Close();
            }
            return listState;
        }
    }
}
