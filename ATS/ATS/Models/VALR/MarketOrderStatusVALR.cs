using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.VALR
{
    class MarketOrderStatusVALR
    {
        public string orderId { get; set; }
        public string orderStatusType { get; set; }
        public string currencyPair { get; set; }
        public string originalPrice { get; set; }
        public string remainingQuantity { get; set; }
        public string originalQuantity { get; set; }
        public string orderSide { get; set; }
        public string orderType { get; set; }
        public string failedReason { get; set; }
        public string orderUpdatedAt { get; set; }
        public string orderCreatedAt { get; set; }
    }
}
