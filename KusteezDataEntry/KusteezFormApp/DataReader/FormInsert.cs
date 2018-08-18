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
        double finalCost = 0.00;

        public int Insert(FormDetails fd)
        {

            string gamerTag1 = fd.gamerTag;
            string clothingType1 = fd.clothingType;
            string sizeType1 = fd.sizeType;
            string clothingColor1 = fd.clothesColorType;
            string printColor1 = fd.printColorType;
            string completeTask = "Not Completed";

            //This is my connection string i have assigned the database file address path  
            if (fd.clothingType == "TS")
            {
                clothingType1 = "T-Shirt 20.00$";
                finalCost += 20.00;
            }
            else if (fd.clothingType == "TSF")
            {
                clothingType1 = "T-SHIRT FEMME 20.00$";
                finalCost += 20.00;
            }
            else if (fd.clothingType == "H")
            {
                clothingType1 = "HOODIE 35.00$";
                finalCost += 35.00;
            }
            else if (fd.clothingType == "LT")
            {
                clothingType1 = "LONG TEE 25.00$";
                finalCost += 25.00;
            }
            else if (fd.clothingType == "PO")
            {
                clothingType1 = "PULL-OVER 30.00$";
                finalCost += 30.00;
            }
            else if (fd.clothingType == "LEM")
            {
                clothingType1 = "LAN ETS MERCH 5.00$ (Print only/Impression seulement";
                finalCost += 5.00;
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

            if(fd.clothesColorCode == "01")
            {
                clothingColor1 = "Red";
            }
            else if(fd.clothesColorCode == "02")
            {
                clothingColor1 = "Purple";
            }
            else if(fd.clothesColorCode == "03")
            {
                clothingColor1 = "Blue";
            }
            else if(fd.clothesColorCode == "04")
            {
                clothingColor1 = " Green";
            }


            if (fd.printColorCode == "01")
            {
                printColor1 = "White";
            }
            else if (fd.printColorCode == "02")
            {
                printColor1 = "Black";
            }
            else if (fd.printColorCode == "03")
            {
                printColor1 = "Yellow";
            }

            string sql = "server=localhost;user id=root;password=1234;database=kusteez";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();

            cmd.Parameters.AddWithValue("@gamerTag1", gamerTag1);
            cmd.Parameters.AddWithValue("@clothingType1", clothingType1);
            cmd.Parameters.AddWithValue("@sizeType1", sizeType1);
            cmd.Parameters.AddWithValue("@clothingColor1", clothingColor1);
            cmd.Parameters.AddWithValue("@printColor1", printColor1);
            cmd.Parameters.AddWithValue("@completeTask", completeTask);
            cmd.Parameters.AddWithValue("@finalCost", finalCost);

            cmd.CommandText = "insert into kusteezform (gamerTag, clothing, size, color, printColor, status, finalCost ) values (@gamerTag1, @clothingType1, @sizeType1, @clothingColor1, @printColor1, @completeTask, @finalCost)";

            conn.Open();

            cmd.ExecuteNonQuery();


            conn.Close();

            return 0;
        }

        public List<SizeReference> GetSizeReferences()
        {
            List<SizeReference> sizes = new List<SizeReference>();

            SizeReference sizeRef = new SizeReference();

            sizeRef.cd = "00";
            sizeRef.descr = "Choose a size";

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


        public List<ClothesColorReference> GetClothesColorReference(){

            List<ClothesColorReference> clothesColor = new List<ClothesColorReference>();

            ClothesColorReference clothesColorRef = new ClothesColorReference();

            clothesColorRef.clothColCode = "00";
            clothesColorRef.clothColDescr = "Choose a clothing color";

            clothesColor.Add(clothesColorRef);

            ClothesColorReference clothesColorRef1 = new ClothesColorReference();

            clothesColorRef1.clothColCode = "01";
            clothesColorRef1.clothColDescr = "Red";

            clothesColor.Add(clothesColorRef1);

            ClothesColorReference clothesColorRef2 = new ClothesColorReference();

            clothesColorRef2.clothColCode = "02";
            clothesColorRef2.clothColDescr = "Purple";

            clothesColor.Add(clothesColorRef2);

            ClothesColorReference clothesColorRef3 = new ClothesColorReference();

            clothesColorRef3.clothColCode = "03";
            clothesColorRef3.clothColDescr = "Blue";

            clothesColor.Add(clothesColorRef3);

            ClothesColorReference clothesColorRef4 = new ClothesColorReference();

            clothesColorRef4.clothColCode = "04";
            clothesColorRef4.clothColDescr = "Green";

            clothesColor.Add(clothesColorRef4);

            return clothesColor;
    }
        public List<PrintColorReference> GetPrintColorReference()
        {

            List<PrintColorReference> printColor = new List<PrintColorReference>();

            PrintColorReference printColorRef = new PrintColorReference();

            printColorRef.printColCode = "00";
            printColorRef.printColDescr = "Choose a Color";

            printColor.Add(printColorRef);

            PrintColorReference printColorRef1 = new PrintColorReference();

            printColorRef1.printColCode = "01";
            printColorRef1.printColDescr = "White";

            printColor.Add(printColorRef1);

            PrintColorReference printColorRef2 = new PrintColorReference();

            printColorRef2.printColCode = "02";
            printColorRef2.printColDescr = "Black";

            printColor.Add(printColorRef2);

            PrintColorReference printColorRef3 = new PrintColorReference();

            printColorRef3.printColCode = "03";
            printColorRef3.printColDescr = "Yellow";

            printColor.Add(printColorRef3);

            return printColor;

        }
    }
}
