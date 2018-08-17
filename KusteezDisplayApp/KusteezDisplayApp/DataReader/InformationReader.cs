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
            
            
            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "select orderID,gamerTag, clothing, size, printColor, status from kusteezform";

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
                fi.printColor = reader["printColor"].ToString();
                fi.status = reader["status"].ToString();

               infoList.Add(fi);
            }
            conn.Close();
            return infoList;
            }

        public int insertCompletedStatus()
        {
            FormInformation fi = new FormInformation();
            string completedID = fi.completedID;
            string taskCompleted = "Complete";

            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.Parameters.AddWithValue("@taskCompleted1", taskCompleted);
            cmd.Parameters.AddWithValue("@completedID1", completedID);

            cmd.CommandText = "insert into kusteezform (status ) values (@taskCompleted1) where orderID = @completedID";

            conn.Open();

            cmd.ExecuteNonQuery();


            conn.Close();

            return 0;
        }
            
    }

    
}
