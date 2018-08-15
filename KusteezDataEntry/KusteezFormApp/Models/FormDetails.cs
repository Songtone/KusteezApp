using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezFormApp.Models
{
    public class FormDetails
    {
        public string gamerTag { get; set; }
        public string clothingType { get; set; }
        //public string size { get; set; }
        public List<SizeReference> sizes { get; set; }
        public string sizeCode { get; set; }
        public string sizeType { get; set; }

        public FormDetails()
        {
            this.gamerTag = null;
            this.clothingType = string.Empty;
            //this.size = string.Empty;
            this.sizes = new List<SizeReference>();
            this.sizeCode = string.Empty;
            this.sizeType = string.Empty;
        }

    }


}
