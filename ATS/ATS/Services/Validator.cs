﻿using ATS.Models.Bitstamp;
using ATS.Models.VALR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Services
{
    public class Validator
    {

        #region Valr VBP

        public static double CalcVBP(List<AskBid> oldbids, double BTI)
        {

            var bids = oldbids.OrderByDescending(bid => Convert.ToDouble(bid.Price));

            int counter = 0;

            List<AskBid> _checkedBids = new List<AskBid>();

            double quantities = 0.0D;
            double VBP = 0.0;
            bool inital = false;

            foreach (var bid in bids)
            {

                if (counter == 20)
                    return 9999999;

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
                counter++;
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

        #endregion

        #region Bitstamp BAP

        public static double CalcBAP(List<List<string>> asks, double BTI)
        {

            var Asks = asks.GetRange(0, 9);

            List<BitstampAsk> convertedAsks = new List<BitstampAsk>();

            foreach (var a in Asks)
            {
                convertedAsks.Add(new BitstampAsk() { Price = a[0], Quantity = a[1] });
            }

            var orderedAsks = convertedAsks.OrderByDescending(ask => Convert.ToDouble(ask.Price));

            int counter = 0;

            List<BitstampAsk> _checkedBids = new List<BitstampAsk>();

            double quantities = 0.0D;
            double VBP = 0.0;
            bool inital = false;

            foreach (var ask in orderedAsks)
            {

                if (counter == 20)
                    return 0;

                quantities += Convert.ToDouble(ask.Quantity);
                _checkedBids.Add(ask);

                if (quantities >= BTI && !inital)
                {
                    VBP = Convert.ToDouble(ask.Price);
                    inital = true;
                    return VBP;
                }
                else if (quantities >= BTI)
                {
                    VBP = ReturnBAPFromAsks(_checkedBids, quantities);
                }
                counter++;
            }

            return 0;
        }

        private static double ReturnBAPFromAsks(List<BitstampAsk> asks, double quantity)
        {
            double VBP = 0.0;
            foreach (var bid in asks)
            {
                VBP += Convert.ToDouble(bid.Price) * (Convert.ToDouble(bid.Quantity) / quantity);
            }
            return VBP;
        }

        #endregion

    }
}
