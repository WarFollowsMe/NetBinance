using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.MarketDataEndpoints.Responses
{
    /*Binance API JSON Response example
    {
      "lastUpdateId": 1027024,
      "bids": [
        [
          "4.00000000",     // PRICE
          "431.00000000",   // QTY
          []                // Can be ignored
        ]
      ],
      "asks": [
        [
          "4.00000200",
          "12.00000000",
          []
        ]
      ]
    }
    */
    public class DepthResponse
    {
        public long LastUpdateId { get; set; }
        public BidAsk[] Bids { get; set; }
        public BidAsk[] Asks { get; set; }
    }
}
