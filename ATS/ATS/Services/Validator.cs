using ATS.Models.VALR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Services
{
    public class Validator
    {

        public static double CalcVBP(List<AskBid> bids, double BTI)
        {

            bids.OrderBy(bid => bid.Price);

            double totalVal = 0.0;
            double VBP = 0.0;

            foreach (var bid in bids)
            {
                if ((totalVal + Convert.ToDouble(bid.Quantity)) >= BTI)
                {
                    //totalVal += 
                }
            }

            return 0;
        }

    }
}
