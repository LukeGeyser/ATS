using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Bitstamp
{
    public class BitstampMarketOrderResponse
    {
        public string id { get; set; }
        public string datetime { get; set; }
        public string type { get; set; }
        public string price { get; set; }
        public string amount { get; set; }
    }
}
