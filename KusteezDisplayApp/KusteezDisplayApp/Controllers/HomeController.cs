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
            InformationReader IR = new InformationReader();
            FormInformation fi = new FormInformation();
            IR.GetInformation(fi);
            return View("Index",fi);
        }

       

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
