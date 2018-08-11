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
        public IActionResult Index()
        {
            //string score = "hello";
           
            ////This is my connection string i have assigned the database file address path  
            //string sql = "server=localhost;user id=root;password=1234;database=testing";
            //MySqlConnection conn = new MySqlConnection(sql);
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.Parameters.AddWithValue("@score", score);
            //cmd.CommandText = "insert into testing (name) values (@score)";
        
            //conn.Open();

            //    cmd.ExecuteNonQuery();
            
               
            //conn.Close();
            return View();
        }

        [HttpPost]
        public ActionResult Submit(FormDetails fd)
        {

            FormInsert finsert = new FormInsert();
            int Result = finsert.Insert(fd);
            return View("Index", fd);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
