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

            
            string phoneNumber1 = fd.phoneNumber;
            string tickerNumber1 = fd.ticketNumber;
            string comments1 = fd.comments;

            string clothingType1 = fd.clothingType;
            string fontType1 = fd.fontType;
            string sizeType1 = fd.sizeType;
            string clothingColor1 = fd.clothesColorType;
            string printColor1 = fd.printColorType;
            string laceColor1 = fd.laceColorType;
            string completeTask = "Not Completed";

            string frontJersey1 = fd.frontJersey;
            string leftSleeveJersey1 = fd.leftSleeveJersey;
            string rightSleeveJersey1 = fd.rightSleeveJersey;
            string topBackJersey1 = fd.topBackJersey;
            string bottomBackJersey1 = fd.bottomBackJersey;

            //This is my connection string i have assigned the database file address path  

            //clothing type section-----------------------------------------------------------------------------------------------
            if (fd.clothingType == "TS")
            {
                clothingType1 = "T-SHIRT";
                fd.finalCost += 20;
            }
            else if (fd.clothingType == "H")
            {
                clothingType1 = "HOODIE";
                fd.finalCost += 35;
            }
            else if (fd.clothingType == "ZH")
            {
                clothingType1 = "ZIP HOODIE";
                fd.finalCost += 35;
            }
            else if (fd.clothingType == "C")
            {
                clothingType1 = "CAPS";
                fd.finalCost += 25;
            }
            else if (fd.clothingType == "P")
            {
                clothingType1 = "PILLOWCASE";
                fd.finalCost += 25;
            }
            else if (fd.clothingType == "PT")
            {
                clothingType1 = "PERFORMANCE TEE";
                fd.finalCost += 30;
            }
            else if (fd.clothingType == "B")
            {
                clothingType1 = "BANDANA";
                fd.finalCost += 25;
            }
            else if (fd.clothingType == "PO")
            {
                clothingType1 = "PRINT ONLY";
                fd.finalCost += 0;
            }
            //size section-----------------------------------------------------------------------------------------------
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
                sizeType1 = "2XL";
            }
            else if (fd.sizeCode == "3XL")
            {
                sizeType1 = "3XL";
            }

            //clothing color section-----------------------------------------------------------------------------------------------
            if (fd.clothesColorCode == "01")
            {
                clothingColor1 = "White";
            }
            else if (fd.clothesColorCode == "02")
            {
                clothingColor1 = "Navy";
            }
            else if (fd.clothesColorCode == "03")
            {
                clothingColor1 = "Yellow";
            }
            else if (fd.clothesColorCode == "04")
            {
                clothingColor1 = "Black";
            } else if (fd.clothesColorCode == "05")
            {
                clothingColor1 = "Kelly";
            }
            else if (fd.clothesColorCode == "06")
            {
                clothingColor1 = "Red Heather";
            }
            else if (fd.clothesColorCode == "07")
            {
                clothingColor1 = "Military Green";
            }
            else if (fd.clothesColorCode == "08")
            {
                clothingColor1 = "Kelly Heather";
            }
            else if (fd.clothesColorCode == "09")
            {
                clothingColor1 = "Purple";
            }
            else if (fd.clothesColorCode == "10")
            {
                clothingColor1 = "Lime";
            }
            else if (fd.clothesColorCode == "11")
            {
                clothingColor1 = "Celadon";
            }
            else if (fd.clothesColorCode == "12")
            {
                clothingColor1 = "Orange";
            }
            else if (fd.clothesColorCode == "13")
            {
                clothingColor1 = "Royal";
            }
            else if (fd.clothesColorCode == "14")
            {
                clothingColor1 = "Coral";
            }
            else if (fd.clothesColorCode == "15")
            {
                clothingColor1 = "Pacific Blue";
            }
            else if (fd.clothesColorCode == "16")
            {
                clothingColor1 = "Red";
            }

            //print color section-----------------------------------------------------------------------------------------------
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
                printColor1 = "Royal Blue";
            }
            else if (fd.printColorCode == "04")
            {
                printColor1 = "Orange";
            }
            else if (fd.printColorCode == "05")
            {
                printColor1 = "Red";
            }
            else if (fd.printColorCode == "06")
            {
                printColor1 = "Green";
            }
            else if (fd.printColorCode == "07")
            {
                printColor1 = "Gold";
            }
            else if (fd.printColorCode == "08")
            {
                printColor1 = "Cyan";
            }

            //lace color section-----------------------------------------------------------------------------------------------
            if (fd.laceColorCode == "01")
            {
                laceColor1 = "Red";
                fd.finalCost += 5;
            }
            else if (fd.laceColorCode == "02")
            {
                laceColor1 = "Pink";
                fd.finalCost += 5;
            }
            else if (fd.laceColorCode == "03")
            {
                laceColor1 = "Yellow";
                fd.finalCost += 5;
            }
            else if (fd.laceColorCode == "04")
            {
                laceColor1 = "Blue";
                fd.finalCost += 5;
            }
            else if (fd.laceColorCode == "05")
            {
                laceColor1 = "Orange";
                fd.finalCost += 5;
            }
            else if (fd.laceColorCode == "06")
            {
                laceColor1 = "Green";
                fd.finalCost += 5;
            }
            else if (fd.laceColorCode == "07")
            {
                laceColor1 = "Purple";
                fd.finalCost += 5;
            }

            //font type section-----------------------------------------------------------------------------------------------
            if (fd.fontType == "JM")
            {
                fontType1 = "JERSEY M54";
            }
            else if (fd.fontType == "N")
            {
                fontType1 = "NOTEWORTHY";
            }
            else if (fd.fontType == "BN")
            {
                fontType1 = "BEBAS NEUE";
            }
            else if (fd.fontType == "D")
            {
                fontType1 = "DEATHWISH";
            }
            else if(fd.fontType == "H")
            {
                fontType1 = "HELVETICA";
            }

            //print locations section-----------------------------------------------------------------------------------------------
            if (fd.frontJersey != null)
            {
                fd.finalCost += 10;
            }
            if(fd.leftSleeveJersey != null)
            {
                fd.finalCost += 5;
            }
            if(fd.rightSleeveJersey != null)
            {
                fd.finalCost += 5;
            }
            if(fd.bottomBackJersey != null)
            {
                fd.finalCost += 10;
            }
            if(fd.topBackJersey != null)
            {
                fd.finalCost += 10;
            }

            //cost logic section-----------------------------------------------------------------------------------------------
            if (fd.frontJersey != null || fd.bottomBackJersey != null || fd.topBackJersey!= null)
            {
                fd.finalCost -= 10;
            }
            else if(fd.leftSleeveJersey != null || fd.rightSleeveJersey != null)
            {
                fd.finalCost -= 5;
            }

            fd.estimatedCost = fd.finalCost;

            if (fd.confirmationButton)
            {
                //sending all the information needed to the database
                string sql = "server=localhost;user id=root;password=1234;database=kusteez";
                MySqlConnection conn = new MySqlConnection(sql);
                MySqlCommand cmd = conn.CreateCommand();

                
                cmd.Parameters.AddWithValue("@clothingType1", clothingType1);
                cmd.Parameters.AddWithValue("@sizeType1", sizeType1);
                cmd.Parameters.AddWithValue("@clothingColor1", clothingColor1);
                cmd.Parameters.AddWithValue("@printColor1", printColor1);
                cmd.Parameters.AddWithValue("@laceColor1", laceColor1);
                cmd.Parameters.AddWithValue("@fontType1", fontType1);
                cmd.Parameters.AddWithValue("@completeTask", completeTask);
                cmd.Parameters.AddWithValue("@finalCost", fd.finalCost);
                cmd.Parameters.AddWithValue("@frontJersey1", frontJersey1);
                cmd.Parameters.AddWithValue("@leftSleeveJersey1", leftSleeveJersey1);
                cmd.Parameters.AddWithValue("@rightSleeveJersey1", rightSleeveJersey1);
                cmd.Parameters.AddWithValue("@topBackJersey1", topBackJersey1);
                cmd.Parameters.AddWithValue("@bottomBackJersey1", bottomBackJersey1);
                cmd.Parameters.AddWithValue("@comments1", comments1);
                cmd.Parameters.AddWithValue("@phoneNumber1", phoneNumber1);
                cmd.Parameters.AddWithValue("@ticketNumber1", tickerNumber1);

                cmd.CommandText = "insert into kusteezform (clothing, size, color, printColor, laceColor, font, status, finalCost, frontJersey, leftSleeveJersey, rightSleeveJersey, topBackJersey, bottomBackJersey, comment, phoneNumber, ticketNumber ) " +
                    "values (@clothingType1, @sizeType1, @clothingColor1, @printColor1, @laceColor1, @fontType1, @completeTask, @finalCost, @frontJersey1, @leftSleeveJersey1, @rightSleeveJersey1, @topBackJersey1, @bottomBackJersey1, @comments1, @phoneNumber1, @ticketNumber1)";

                conn.Open();

                cmd.ExecuteNonQuery();


                conn.Close();
            }
            return 0;
        }
        
            //each of the following functions creates a list to be shown in the dropdown
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
            sizeRef4.descr = "XL";

            sizes.Add(sizeRef4);

            SizeReference sizeRef5 = new SizeReference();

            sizeRef5.cd = "2XL";
            sizeRef5.descr = "2XL";

            sizes.Add(sizeRef5);

            SizeReference sizeRef6 = new SizeReference();

            sizeRef6.cd = "3XL";
            sizeRef6.descr = "3XL";

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
            clothesColorRef1.clothColDescr = "White";

            clothesColor.Add(clothesColorRef1);

            ClothesColorReference clothesColorRef2 = new ClothesColorReference();

            clothesColorRef2.clothColCode = "02";
            clothesColorRef2.clothColDescr = "Navy";

            clothesColor.Add(clothesColorRef2);

            ClothesColorReference clothesColorRef3 = new ClothesColorReference();

            clothesColorRef3.clothColCode = "03";
            clothesColorRef3.clothColDescr = "Yellow";

            clothesColor.Add(clothesColorRef3);

            ClothesColorReference clothesColorRef4 = new ClothesColorReference();

            clothesColorRef4.clothColCode = "04";
            clothesColorRef4.clothColDescr = "Black";

            clothesColor.Add(clothesColorRef4);

            ClothesColorReference clothesColorRef5 = new ClothesColorReference();

            clothesColorRef5.clothColCode = "05";
            clothesColorRef5.clothColDescr = "Kelly";

            clothesColor.Add(clothesColorRef5);

            ClothesColorReference clothesColorRef6 = new ClothesColorReference();

            clothesColorRef6.clothColCode = "06";
            clothesColorRef6.clothColDescr = "Red Heather";

            clothesColor.Add(clothesColorRef6);

            ClothesColorReference clothesColorRef7 = new ClothesColorReference();

            clothesColorRef7.clothColCode = "07";
            clothesColorRef7.clothColDescr = "Military Green";

            clothesColor.Add(clothesColorRef7);

            ClothesColorReference clothesColorRef8 = new ClothesColorReference();

            clothesColorRef8.clothColCode = "08";
            clothesColorRef8.clothColDescr = "Kelly Heather";

            clothesColor.Add(clothesColorRef8);

            ClothesColorReference clothesColorRef9 = new ClothesColorReference();

            clothesColorRef9.clothColCode = "09";
            clothesColorRef9.clothColDescr = "Purple";

            clothesColor.Add(clothesColorRef9);

            ClothesColorReference clothesColorRef10 = new ClothesColorReference();

            clothesColorRef10.clothColCode = "10";
            clothesColorRef10.clothColDescr = "Lime";

            clothesColor.Add(clothesColorRef10);

            ClothesColorReference clothesColorRef11 = new ClothesColorReference();

            clothesColorRef11.clothColCode = "11";
            clothesColorRef11.clothColDescr = "Celadon";

            clothesColor.Add(clothesColorRef11);

            ClothesColorReference clothesColorRef12 = new ClothesColorReference();

            clothesColorRef12.clothColCode = "12";
            clothesColorRef12.clothColDescr = "Orange";

            clothesColor.Add(clothesColorRef12);

            ClothesColorReference clothesColorRef13 = new ClothesColorReference();

            clothesColorRef13.clothColCode = "13";
            clothesColorRef13.clothColDescr = "Royal";

            clothesColor.Add(clothesColorRef13);

            ClothesColorReference clothesColorRef14 = new ClothesColorReference();

            clothesColorRef14.clothColCode = "14";
            clothesColorRef14.clothColDescr = "Coral";

            clothesColor.Add(clothesColorRef14);

            ClothesColorReference clothesColorRef15 = new ClothesColorReference();

            clothesColorRef15.clothColCode = "15";
            clothesColorRef15.clothColDescr = "Pacific Blue";

            clothesColor.Add(clothesColorRef15);

            ClothesColorReference clothesColorRef16 = new ClothesColorReference();

            clothesColorRef16.clothColCode = "16";
            clothesColorRef16.clothColDescr = "Red";

            clothesColor.Add(clothesColorRef16);
            

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
            printColorRef3.printColDescr = "Royal Blue";

            printColor.Add(printColorRef3);

            PrintColorReference printColorRef4 = new PrintColorReference();

            printColorRef4.printColCode = "04";
            printColorRef4.printColDescr = "Orange";

            printColor.Add(printColorRef4);

            PrintColorReference printColorRef5 = new PrintColorReference();

            printColorRef5.printColCode = "05";
            printColorRef5.printColDescr = "Red";

            printColor.Add(printColorRef5);

            PrintColorReference printColorRef6 = new PrintColorReference();

            printColorRef6.printColCode = "06";
            printColorRef6.printColDescr = "Green";

            printColor.Add(printColorRef6);

            PrintColorReference printColorRef7 = new PrintColorReference();

            printColorRef7.printColCode = "07";
            printColorRef7.printColDescr = "Gold";

            printColor.Add(printColorRef7);

            PrintColorReference printColorRef8 = new PrintColorReference();

            printColorRef8.printColCode = "08";
            printColorRef8.printColDescr = "Cyan";

            printColor.Add(printColorRef8);

           
            return printColor;

        }
        public List<CustomLaceColorReference> GetCustomLaceColorReference()
        {
            List<CustomLaceColorReference> laceColor = new List<CustomLaceColorReference>();

            CustomLaceColorReference laceRef = new CustomLaceColorReference();

            laceRef.laceColorCode = "00";
            laceRef.laceColorDesc = "Choose a lace color";

            laceColor.Add(laceRef);

            CustomLaceColorReference laceRef1 = new CustomLaceColorReference();

            laceRef1.laceColorCode = "01";
            laceRef1.laceColorDesc = "Red";

            laceColor.Add(laceRef1);

            CustomLaceColorReference laceRef2 = new CustomLaceColorReference();

            laceRef2.laceColorCode = "02";
            laceRef2.laceColorDesc = "Pink";

            laceColor.Add(laceRef2);

            CustomLaceColorReference laceRef3 = new CustomLaceColorReference();

            laceRef3.laceColorCode = "03";
            laceRef3.laceColorDesc = "Yellow";

            laceColor.Add(laceRef3);

            CustomLaceColorReference laceRef4 = new CustomLaceColorReference();

            laceRef4.laceColorCode = "04";
            laceRef4.laceColorDesc = "Blue";

            laceColor.Add(laceRef4);

            CustomLaceColorReference laceRef5 = new CustomLaceColorReference();

            laceRef5.laceColorCode = "05";
            laceRef5.laceColorDesc = "Orange";

            laceColor.Add(laceRef5);

            CustomLaceColorReference laceRef6 = new CustomLaceColorReference();

            laceRef6.laceColorCode = "06";
            laceRef6.laceColorDesc = "Green";

            laceColor.Add(laceRef6);

            CustomLaceColorReference laceRef7 = new CustomLaceColorReference();

            laceRef7.laceColorCode = "07";
            laceRef7.laceColorDesc = "Purple";

            laceColor.Add(laceRef7);

            return laceColor;
        }
    }
}
