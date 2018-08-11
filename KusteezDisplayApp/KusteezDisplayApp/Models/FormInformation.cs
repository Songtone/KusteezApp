using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KusteezDisplayApp.Models
{
    public class FormInformation
    {

        public string gamerTag { get; set; }
        public string clothingType { get; set; }

        public FormInformation()
        {
            this.gamerTag = null;
            this.clothingType = string.Empty;

        }
    }
}
