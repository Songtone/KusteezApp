using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KusteezFormApp.Models;
using KusteezFormApp.DataReader;
using MySql.Data.MySqlClient;

namespace KusteezFormApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//the main page when it loads it will have all the page refreshed and the dropdown list filled properly.
        {
            FormInsert infoReader = new FormInsert();
            List<SizeReference> sizeRef = infoReader.GetSizeReferences();
            List<ClothesColorReference> clothesColorRef = infoReader.GetClothesColorReference();
            List<PrintColorReference> printColorRef = infoReader.GetPrintColorReference();
            List<CustomLaceColorReference> laceColorRef = infoReader.GetCustomLaceColorReference();

            FormDetails formDetails = new FormDetails();

            formDetails.sizes = sizeRef;
            formDetails.clothesColor = clothesColorRef;
            formDetails.printColor = printColorRef;
            formDetails.laceColor = laceColorRef;

            return View("Index",formDetails);
        }

        [HttpPost]
        public ActionResult Submit(FormDetails fd)//submitting the information to the database
        {

            FormInsert infoReader = new FormInsert();
            List<SizeReference> sizeRef = infoReader.GetSizeReferences();
            List<ClothesColorReference> clothesColorRef = infoReader.GetClothesColorReference();
            List<PrintColorReference> printColorRef = infoReader.GetPrintColorReference();
            List<CustomLaceColorReference> laceColorRef = infoReader.GetCustomLaceColorReference();

            FormDetails formDetails = new FormDetails();

            formDetails.sizes = sizeRef;
            formDetails.clothesColor = clothesColorRef;
            formDetails.printColor = printColorRef;
            formDetails.laceColor = laceColorRef;
            string test = "";

            test = fd.clothingType;
            test = formDetails.clothingType;

            FormInsert findEstimate = new FormInsert();
            //int Result = findEstimate.GetEstimatedCost(fd);

            


            //validation starts here
            if (fd.clothingType == "")//makes sure they choose an option
            {
               
                ModelState.AddModelError("clothingType", "Choose a clothing type");
                fd.confirmationButton = false;
            }

            if (fd.clothingType != "PO")//if the choice is not Print Only they must choose size and color
            {
                if (fd.sizeCode == "00")
                {
                    ModelState.AddModelError("sizeCode", "Choose a size");
                    fd.confirmationButton = false;
                }
                if(fd.clothesColorCode == "00")
                {
                    ModelState.AddModelError("clothesColorCode", "Choose a clothes color");
                    fd.confirmationButton = false;
                }
                
            }

            if (fd.printColorCode == "00")//if they choose print only, they must choose a print color
            {
                ModelState.AddModelError("printColorCode", "Choose a print color");
                fd.confirmationButton = false;
            }
            else
            {
                if(fd.fontType == "")
                {
                    ModelState.AddModelError("fontType", "Choose a font");
                    fd.confirmationButton = false;
                }
            }

            //if(fd.ticketNumber == null)//makes sure the ticket section is filled out
            //{
            //    ModelState.AddModelError("ticketNumber", "Enter a ticket number");
            //}

            int Result = findEstimate.Insert(fd);
            formDetails.estimatedCost = fd.estimatedCost;

            if (fd.confirmationButton)//if the confirmation isnt pressed, we can't continue
            {
                if (ModelState.IsValid)//if the confirmation button is clicked, we still need to check if the previous validations passed.
                {
                    //FormInsert finsert = new FormInsert();
                   
                    return RedirectToAction("Index", fd);
                }
                else
                {

                    return View("Index", formDetails);
                }
            }
            return View("Index", formDetails);

        }
        
    }
}
