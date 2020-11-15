using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Bitstamp
{
    class BitstampOrderBook
    {
        public string timestamp { get; set; }
        public string microtimestamp { get; set; }
        public List<List<string>> bids { get; set; }
        public List<List<string>> asks { get; set; }
    }
}
