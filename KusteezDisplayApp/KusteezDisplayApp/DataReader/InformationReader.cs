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

            cmd.CommandText = "select orderID, clothing, size, printColor, laceColor, font, status, finalCost, frontJersey, leftSleeveJersey, rightSleeveJersey, topBackJersey, bottomBackJersey, comment, phoneNumber, ticketNumber from kusteezform";

            List<FormInformation> infoList = new List<FormInformation>();
            
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                FormInformation fi = new FormInformation();

                fi.orderID = reader["orderID"] == null ? 0 : Convert.ToInt32(reader["orderID"]);
                fi.finalCost = reader["finalCost"] == null ? 0 : Convert.ToDouble(reader["finalCost"]);
                fi.clothingType = reader["clothing"].ToString();
                fi.size = reader["size"].ToString();
                fi.printColor = reader["printColor"].ToString();
                fi.laceColor = reader["laceColor"].ToString();
                fi.font = reader["font"].ToString();
                fi.status = reader["status"].ToString();
                fi.frontJersey = reader["frontJersey"].ToString();
                fi.leftSleeveJersey = reader["leftSleeveJersey"].ToString();
                fi.rightSleeveJersey = reader["rightSleeveJersey"].ToString();
                fi.topBackJersey = reader["topBackJersey"].ToString();
                fi.bottomBackJersey = reader["bottomBackJersey"].ToString();
                fi.comments = reader["comment"].ToString();
                fi.phoneNumber = reader["phoneNumber"].ToString();
                fi.ticketNumber = reader["ticketNumber"].ToString();

               infoList.Add(fi);
            }
            conn.Close();
            return infoList;
            }

        public int insertCompletedStatus(FormInformation fi)
        {
            
            string completedID = fi.completedID;
            string taskCompleted = "Complete";
            int x = Int32.Parse(completedID);

            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.Parameters.AddWithValue("@taskCompleted1", taskCompleted);
            cmd.Parameters.AddWithValue("@completedID1", x);

            cmd.CommandText = "update kusteezform set status = @taskCompleted1 where (orderID = @completedID1)";

            conn.Open();

            cmd.ExecuteNonQuery();


            conn.Close();

            return 0;
        }
            
    }

    
}
