using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezFormApp.Models
{
    public class ClothesColorReference
    {
        public string clothColCode { get; set; }
        public string clothColDescr { get; set; }

        public ClothesColorReference()
        {
            this.clothColCode = string.Empty;
            this.clothColDescr = string.Empty;
        }
    }
}
