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
        public ActionResult Index()
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
        public ActionResult Submit(FormDetails fd)
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

            int Result = findEstimate.Insert(fd);
            formDetails.estimatedCost = fd.estimatedCost;

            if (fd.clothingType == "")
            {
                string x = "YAY";
                ModelState.AddModelError("clothingType", "test");
            }
            if (ModelState.IsValid)
            {
                string x = "YAY";
            }
            else
            {
                string y = "awsome";
            }
            

            if(fd.confirmationButton)
            {
                //FormInsert finsert = new FormInsert();
                //int Result1 = finsert.Insert(fd);
                return RedirectToAction("Index", fd);
           }

            return View("Index",formDetails);
        }
        
    }
}
