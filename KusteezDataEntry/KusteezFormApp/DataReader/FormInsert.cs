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
            string sizeType1 = fd.size; 

            //This is my connection string i have assigned the database file address path  
            if(fd.clothingType == "TS")
            {
                clothingType1 = "T-Shirt 20.00$";

            }else if(fd.clothingType == "TSF")
            {
                clothingType1 = "T-SHIRT FEMME 20.00$";
            }
            else if (fd.clothingType == "H")
            {
                clothingType1 = "HOODIE 35.00$";
            }
            else if (fd.clothingType == "LT")
            {
                clothingType1 = "LONG TEE 25.00$";
            }
            else if (fd.clothingType == "PO")
            {
                clothingType1 = "PULL-OVER 30.00$";
            }
            else if (fd.clothingType == "LEM")
            {
                clothingType1 = "LAN ETS MERCH 5.00$ (Print only/Impression seulement";
            }

            if(fd.size == "S")
            {
                sizeType1 = "small";
            }else if(fd.size == "M")
            {
                sizeType1 = "Medium";
            }
            else if (fd.size == "L")
            {
                sizeType1 = "Large";
            }
            else if (fd.size == "XL")
            {
                sizeType1 = "Extra Large";
            }
            else if (fd.size == "2XL")
            {
                sizeType1 = "2x Extra Large";
            }
            else if (fd.size == "3XL")
            {
                sizeType1 = "3x Extra Large";
            }

            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@gamerTag1", gamerTag1);
            cmd.Parameters.AddWithValue("@clothingType1", clothingType1);
            cmd.Parameters.AddWithValue("@sizeType1", sizeType1);
            cmd.CommandText = "insert into kusteezform (gamerTag, clothing,size ) values (@gamerTag1,@clothingType1, @sizeType1)";

            conn.Open();

            cmd.ExecuteNonQuery();


            conn.Close();



            conn.Close();
            return 0;
        }
            
        
    }
}
