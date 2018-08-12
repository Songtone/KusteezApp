﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezDisplayApp.Models
{
    public class FormInformation
    {
        public int orderID { get; set; }
        public string gamerTag { get; set; }
        public string clothingType { get; set; }
        public string size { get; set; }
        public List<FormInformation> OrdersList { get; set; } 

        public FormInformation()
        {
            this.orderID = 0;
            this.gamerTag = null;
            this.clothingType = string.Empty;
            this.size = string.Empty;
            this.OrdersList = new List<FormInformation>();
        }
    }
}