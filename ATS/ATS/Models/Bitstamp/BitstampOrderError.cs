using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Bitstamp
{
    public class BitstampOrderError
    {
        public string status { get; set; }
        public Reason reason { get; set; }
    }

    public class Reason
    {
        public List<string> __all__ { get; set; }
    }
}
