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
            FormInsert sizeReader = new FormInsert();
            List<SizeReference> sizeRef = sizeReader.GetSizeReferences();
            FormDetails formDetails = new FormDetails();

            formDetails.sizes = sizeRef;

            return View("Index",formDetails);
        }

        [HttpPost]
        public ActionResult Submit(FormDetails fd)
        {
          
            FormInsert finsert = new FormInsert();
            int Result = finsert.Insert(fd);

            return RedirectToAction("Index",fd);
        }

        
    }
}
