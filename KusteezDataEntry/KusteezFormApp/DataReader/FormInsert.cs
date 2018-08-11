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

            string gamerTag1 = fd.gamerTag;
            string clothingType1 = fd.clothingType;

            //This is my connection string i have assigned the database file address path  
            if(fd.clothingType == "TS")
            {
                clothingType1 = "T-Shirt 20.00$";
            }
            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@gamerTag1", gamerTag1);
            cmd.Parameters.AddWithValue("@clothingType1", clothingType1);
            cmd.CommandText = "insert into kusteezform (gamerTag, clothing) values (@gamerTag1,@clothingType1)";

            conn.Open();

            cmd.ExecuteNonQuery();


            conn.Close();



            conn.Close();
            return 0;
        }
            
        
    }
}
