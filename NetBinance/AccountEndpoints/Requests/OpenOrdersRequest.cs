using System;
using NetBinance.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints.Requests
{
    /// <summary>
    /// GET /api/v3/openOrders?
    /// symbol={Symbol}&
    /// recvWindow={RecvWindow[optional]}&
    /// timestamp={Timestamp}
    /// </summary>
    public class OpenOrdersRequest:IRequestURLParameter
    {
        public string Symbol { get; set; }
        public long? RecvWindow { get; set; }
        public DateTime Timestamp { get; set; }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}&" +
                (RecvWindow == null ? string.Empty : $"recvWindow={RecvWindow}&") +
                $"timestamp={Timestamp.ToTimestamp()}";
            return parameters;
        }
    }
}
