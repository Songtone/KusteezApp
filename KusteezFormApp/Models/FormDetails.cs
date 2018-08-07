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

        public FormDetails()
        {
            this.gamerTag = string.Empty;
            this.clothingType = string.Empty;
        }

    }

    
}
