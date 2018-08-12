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
        public string size { get; set; }

        public FormDetails()
        {
            this.gamerTag = null;
            this.clothingType = string.Empty;
            this.size = string.Empty;
        }

    }


}
