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

            List<AskBid> _checkedBids = new List<AskBid>();

            double quantities = 0.0D;
            double VBP = 0.0;
            bool inital = false;

            foreach (var bid in bids)
            {
                quantities += Convert.ToDouble(bid.Quantity);
                _checkedBids.Add(bid);

                if (quantities >= BTI && !inital)
                {
                    VBP = Convert.ToDouble(bid.Price);
                    inital = true;
                    return VBP;
                } 
                else if (quantities >= BTI)
                {
                    VBP = ReturnVBPFromBids(_checkedBids, quantities);
                }
                
            }

            return 0;
        }

        private static double ReturnVBPFromBids(List<AskBid> bids, double quantity)
        {
            double VBP = 0.0;
            foreach (var bid in bids)
            {
                VBP += Convert.ToDouble(bid.Price) * (Convert.ToDouble(bid.Quantity) / quantity);
            }
            return VBP;
        }

    }
}
