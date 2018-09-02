using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KusteezDisplayApp.Models;
using KusteezDisplayApp.DataReader;

namespace KusteezDisplayApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            FormInformation fi = new FormInformation();//retrieve the information
            
            fi.OrdersList = InformationReader.GetInformation();
           
            return View("Index",fi);
        }

        [HttpPost]
        public IActionResult Confirm(FormInformation fi)//the status change
        {
            InformationReader reader = new InformationReader();
            int result = reader.insertCompletedStatus(fi);

            return RedirectToAction("Index", fi);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
