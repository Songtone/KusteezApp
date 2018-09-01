using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezFormApp.Models
{
    public class CustomLaceColorReference
    {
        public string laceColorCode { get; set; }
        public string laceColorDesc { get; set; }

        public CustomLaceColorReference()
        {
            this.laceColorCode = string.Empty;
            this.laceColorDesc = string.Empty;
        }
    }
}
