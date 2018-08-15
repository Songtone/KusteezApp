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
            string sizeType1 = fd.sizeType; 

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

            if (fd.sizeCode == "S")
            {
                sizeType1 = "Small";
            }
            else if (fd.sizeCode == "M")
            {
                sizeType1 = "Medium";
            }
            else if (fd.sizeCode == "L")
            {
                sizeType1 = "Large";
            }
            else if (fd.sizeCode == "XL")
            {
                sizeType1 = "Extra Large";
            }
            else if (fd.sizeCode == "2XL")
            {
                sizeType1 = "2x Extra Large";
            }
            else if (fd.sizeCode == "3XL")
            {
                sizeType1 = "3x Extra Large";
            }

            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@gamerTag1", gamerTag1);
            cmd.Parameters.AddWithValue("@clothingType1", clothingType1);
            //cmd.Parameters.AddWithValue("@sizeType1", sizeType1);
            cmd.CommandText = "insert into kusteezform (gamerTag, clothing,size ) values (@gamerTag1,@clothingType1)";

            conn.Open();

            cmd.ExecuteNonQuery();


            conn.Close();
            
            return 0;
        }

        public List<SizeReference> GetSizeReferences()
        {
            List<SizeReference> sizes = new List<SizeReference>();

            SizeReference sizeRef = new SizeReference();

            sizeRef.cd = "";
            sizeRef.descr = "";

            sizes.Add(sizeRef);

            SizeReference sizeRef1 = new SizeReference();

            sizeRef1.cd = "S";
            sizeRef1.descr = "Small";

            sizes.Add(sizeRef1);

            SizeReference sizeRef2 = new SizeReference();
            sizeRef2.cd = "M";
            sizeRef2.descr = " Medium";

            sizes.Add(sizeRef2);

            SizeReference sizeRef3 = new SizeReference();

            sizeRef3.cd = "L";
            sizeRef3.descr = "Large";

            sizes.Add(sizeRef3);

            SizeReference sizeRef4 = new SizeReference();

            sizeRef4.cd = "XL";
            sizeRef4.descr = "Extra Large";

            sizes.Add(sizeRef4);

            SizeReference sizeRef5 = new SizeReference();

            sizeRef5.cd = "2XL";
            sizeRef5.descr = "2x Extra Large";

            sizes.Add(sizeRef5);

            SizeReference sizeRef6 = new SizeReference();

            sizeRef6.cd = "3XL";
            sizeRef6.descr = "3X Extra Large";

            sizes.Add(sizeRef6);

            return sizes;

        }
            
        
    }
}
