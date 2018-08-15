using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezFormApp.Models
{
    public class SizeReference
    {
        public string cd { get; set; }
        public string descr { get; set; }

        public SizeReference()
        {
            this.cd = string.Empty;
            this.descr = string.Empty;
        }
    }
}
