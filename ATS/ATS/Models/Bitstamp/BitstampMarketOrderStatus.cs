using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Bitstamp
{
    public class BitstampMarketOrderStatus
    {
        public string status { get; set; }
        public string id { get; set; }
        public List<Transaction> transactions { get; set; }
        public string amount_remaining { get; set; }
    }
}
