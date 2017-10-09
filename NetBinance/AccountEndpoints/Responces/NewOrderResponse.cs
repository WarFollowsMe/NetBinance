using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBinance.Converters;

namespace NetBinance.AccountEndpoints.Responses
{
    /*
    {
      "symbol":"LTCBTC",
      "orderId": 1,
      "clientOrderId": "myOrder1" // Will be newClientOrderId
      "transactTime": 1499827319559
    }
    */
    public class NewOrderResponse
    {
        public string Symbol { get; set; }
        public int OrderID { get; set; }
        public string ClientOrderId { get; set; }
        [JsonConverter(typeof(UnixTimestampJsonConverter))]
        public DateTime TransactTime { get; set; }
    }
}
