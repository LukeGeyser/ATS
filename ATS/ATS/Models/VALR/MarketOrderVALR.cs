using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.VALR
{
    [Serializable]
    public class MarketOrderVALR
    {
        public string side { get; set; }
        public string baseAmount { get; set; }
        public string pair { get; set; }
    }
}
