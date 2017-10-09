using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints.Responses
{
    /*
    {
      "symbol": "LTCBTC",
      "origClientOrderId": "myOrder1",
      "orderId": 1,
      "clientOrderId": "cancelMyOrder1"
    }
    */
    public class CancelOrderResponse
    {
        public string Symbol { get; set; }
        public string OrigClientOrderId { get; set; }
        public long OrderId { get; set; }
        public string ClientOrderId { get; set; }
    }
}
