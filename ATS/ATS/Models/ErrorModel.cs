using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models
{
    public class ErrorModel
    {
        public string DateTime { get; set; }
        public string Error { get; set; }
        public string OtherParameter { get; set; }
        public string Exchange { get; set; }

        public ErrorModel(string DateTime, string Error, string OtherParameter, string Exchange)
        {
            this.DateTime = DateTime;
            this.Error = Error;
            this.OtherParameter = OtherParameter;
            this.Exchange = Exchange;
        }
    }
}
