using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KusteezDisplayApp.Models;
using MySql.Data.MySqlClient;

namespace KusteezDisplayApp.DataReader
{
    public class InformationReader
    {
        public static List<FormInformation> GetInformation(){
            

            InformationReader info = new InformationReader();
            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "select orderID,gamerTag, clothing, size from kusteezform";

            List<FormInformation> infoList = new List<FormInformation>();
            
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                FormInformation fi = new FormInformation();

                fi.orderID = reader["orderID"] == null ? 0 : Convert.ToInt32(reader["orderID"]);
                fi.gamerTag = reader["gamerTag"].ToString();
                fi.clothingType = reader["clothing"].ToString();
                fi.size = reader["size"].ToString();

               infoList.Add(fi);
            }
            conn.Close();
            return infoList;
            }
            
    }

    
}
