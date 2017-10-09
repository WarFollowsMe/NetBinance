using NetBinance.Enum;
using Newtonsoft.Json;
using NetBinance.Converters;
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
      "orderId": 1,
      "clientOrderId": "myOrder1",
      "price": "0.1",
      "origQty": "1.0",
      "executedQty": "0.0",
      "status": "NEW",
      "timeInForce": "GTC",
      "type": "LIMIT",
      "side": "BUY",
      "stopPrice": "0.0",
      "icebergQty": "0.0",
      "time": 1499827319559
    }
    */
    public class OrderStatusResponse
    {
        public string Symbol { get; set; }
        public long OrderID { get; set; }
        public string ClientOrderID { get; set; }
        public double Price { get; set; }
        [JsonProperty(PropertyName = "origQty")]
        public double OrigQuantity { get; set; }
        public OrderStatus Status { get; set; }
        public TimeInForce TimeInForce { get; set; }
        public OrderSide Side { get; set; }
        public double StopPrice { get; set; }
        [JsonProperty(PropertyName = "icebergQty")]
        public double IcebergQuantity { get; set; }
        [JsonConverter(typeof(UnixTimestampJsonConverter))]
        public DateTime Time { get; set; }
    }
}
