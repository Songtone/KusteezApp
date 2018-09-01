using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezFormApp.Models
{
    public class FormDetails
    {
        
        public string phoneNumber { get; set; }
        public string ticketNumber { get; set; }

        public string clothingType { get; set; }
        public string fontType { get; set; }

        //public string size { get; set; }
        public List<SizeReference> sizes { get; set; }
        public string sizeCode { get; set; }
        public string sizeType { get; set; }

        public List<ClothesColorReference> clothesColor { get; set; }
        public string clothesColorCode { get; set; }
        public string clothesColorType { get; set; }

        public List<PrintColorReference> printColor { get; set; }
        public string printColorCode { get; set; }
        public string printColorType { get; set; }

        public List<CustomLaceColorReference> laceColor { get; set; }
        public string laceColorCode { get; set; }
        public string laceColorType { get; set; }

        public string frontJersey { get; set; }
        public string leftSleeveJersey { get; set; }
        public string rightSleeveJersey { get; set; }
        public string topBackJersey { get; set; }
        public string bottomBackJersey { get; set; }

        public string comments { get; set; }

        public double finalCost { get; set; }
        public double estimatedCost { get; set; }

        public bool confirmationButton { get; set; }
        public string estimateButton { get; set; }

        public FormDetails()
        {
            
            this.phoneNumber = string.Empty;
            this.ticketNumber = string.Empty;

            this.clothingType = string.Empty;
            this.fontType = string.Empty;

            //this.size = string.Empty;
            this.sizes = new List<SizeReference>();
            this.sizeCode = string.Empty;
            this.sizeType = string.Empty;

            this.clothesColor = new List<ClothesColorReference>();
            this.clothesColorCode = string.Empty;
            this.clothesColorType = string.Empty;

            this.printColor = new List<PrintColorReference>();
            this.printColorCode = string.Empty;
            this.printColorType = string.Empty;

            this.laceColor = new List<CustomLaceColorReference>();
            this.laceColorCode = string.Empty;
            this.laceColorType = string.Empty;

            this.frontJersey = string.Empty;
            this.leftSleeveJersey = string.Empty;
            this.rightSleeveJersey = string.Empty;
            this.topBackJersey = string.Empty;
            this.bottomBackJersey = string.Empty;

            this.comments = string.Empty;

            this.finalCost = 0;
            this.estimatedCost = 0;

            this.confirmationButton = false;
            this.estimateButton = "yes";
        }

    }


}
