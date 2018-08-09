using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KusteezFormApp.Models;
using MySql.Data.MySqlClient;

namespace KusteezFormApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FormDetails fd = new FormDetails();
            //This is my connection string i have assigned the database file address path  
            string sql = "server=localhost;user id=root;password=1234;database=testing";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select name from testing where idtesting = 1";

            try
            {
                conn.Open();
            }
            catch
            {
                return View();
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fd.clothingType = reader["name"].ToString();
            }

            conn.Close();
            return View();
        }

        public IActionResult About()
        {
           
                
             

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
