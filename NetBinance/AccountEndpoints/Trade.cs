using Newtonsoft.Json;
using System;
using NetBinance.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints
{
    /*
    [
      {
        "id": 28457,
        "price": "4.00000100",
        "qty": "12.00000000",
        "commission": "10.10000000",
        "commissionAsset": "BNB",
        "time": 1499865549590,
        "isBuyer": true,
        "isMaker": false,
        "isBestMatch": true
      }
    ]
    */
    public class Trade
    {
        public long Id { get; set; }
        public double Price { get; set; }
        [JsonProperty(PropertyName = "qty")]
        public double Quantity { get; set; }
        public double Commission { get; set; }
        public string CommissionAsset { get; set; }
        [JsonConverter(typeof(UnixTimestampJsonConverter))]
        public DateTime Time { get; set; }
        public bool IsBuyer { get; set; }
        public bool IsMaker { get; set; }
        public bool IsBestMatch { get; set; }
    }
}
