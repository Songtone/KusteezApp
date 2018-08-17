using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezFormApp.Models
{
    public class PrintColorReference
    {

        public string printColCode { get; set; }
        public string printColDescr { get; set; }

        public PrintColorReference()
        {

            this.printColCode = string.Empty;
            this.printColDescr = string.Empty;
        }

    }
}
