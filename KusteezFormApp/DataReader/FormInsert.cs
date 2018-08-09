using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KusteezFormApp.Models;
using MySql.Data.MySqlClient;

namespace KusteezFormApp.DataReader
{
    public class FormInsert
    {
        public int Insert(FormDetails fd)
        {

            string score = fd.gamerTag;

            //This is my connection string i have assigned the database file address path  
            string sql = "server=localhost;user id=root;password=1234;database=testing";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@score", score);
            cmd.CommandText = "insert into testing (name) values (@score)";

            conn.Open();

            cmd.ExecuteNonQuery();


            conn.Close();



            conn.Close();
            return 0;
        }
            
        
    }
}
