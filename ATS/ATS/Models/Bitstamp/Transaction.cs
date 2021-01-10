using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Bitstamp
{
    public class Transaction
    {
        public string fee { get; set; }
        public string price { get; set; }
        public string datetime { get; set; }
        public string btc { get; set; }
        public int tid { get; set; }
        public int type { get; set; }
        public string eur { get; set; }
    }
}
