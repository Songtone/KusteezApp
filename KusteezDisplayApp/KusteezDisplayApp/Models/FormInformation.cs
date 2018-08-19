using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezDisplayApp.Models
{
    public class FormInformation
    {
        public int orderID { get; set; }
        public double finalCost { get; set; }
        public string completedID { get; set; }
        public string gamerTag { get; set; }
        public string clothingType { get; set; }
        public string size { get; set; }
        public string printColor { get; set; }
        public string status { get; set; }

        public string frontJersey { get; set; }
        public string leftSleeveJersey { get; set; }
        public string rightSleeveJersey { get; set; }
        public string topBackJersey { get; set; }
        public string bottomBackJersey { get; set; }

        public List<FormInformation> OrdersList { get; set; } 

        public FormInformation()
        {
            this.orderID = 0;
            this.finalCost = 0.00;
            this.completedID = string.Empty;
            this.gamerTag = null;
            this.clothingType = string.Empty;
            this.size = string.Empty;
            this.printColor = string.Empty;
            this.status = string.Empty;

            this.frontJersey = string.Empty;
            this.leftSleeveJersey = string.Empty;
            this.rightSleeveJersey = string.Empty;
            this.topBackJersey = string.Empty;
            this.bottomBackJersey = string.Empty;

            this.OrdersList = new List<FormInformation>();
        }
    }
}
