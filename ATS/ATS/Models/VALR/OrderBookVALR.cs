using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.VALR
{
    public class OrderBookVALR
    {

        #region Private Fields

        private List<AskBid> asks;
        private List<AskBid> bids;
        private DateTime lastChange;

        #endregion

        #region Public Properties

        public List<AskBid> Asks
        {
            get { return asks; }
            set
            {
                asks = value;
            }
        }

        public List<AskBid> Bids
        {
            get { return bids; }
            set
            {
                bids = value;
            }
        }

        public DateTime LastChange
        {
            get { return lastChange; }
            set
            {
                lastChange = value;
            }
        }

        #endregion

        #region Constructors



        #endregion

        #region Helper Function



        #endregion
    }
}
