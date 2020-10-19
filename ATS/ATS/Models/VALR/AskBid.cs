using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.VALR
{
    public class AskBid
    {
        public string Side { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string CurrencyPair { get; set; }
        public int OrderCount { get; set; }
    }
}
