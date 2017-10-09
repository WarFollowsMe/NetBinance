using System;
using NetBinance.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints.Requests
{
    /// <summary>
    /// GET /api/v3/allOrders?
    /// symbol={Symbol}&
    /// orderId={OrderID[optional]}&
    /// limit={Limit[optional;default=500;max=500]}
    /// recvWindow={RecvWindow[optional]}&
    /// timestamp={Timestamp}
    /// </summary>
    public class AllOrdersRequest:IRequestURLParameter
    {
        public string Symbol { get; private set; }
        public long? OrderID { get; private set; }
        public int? Limit { get; private set; }
        public long? RecvWindow { get; private set; }
        public DateTime Timestamp { get; private set; }

        public AllOrdersRequest(string symbol, DateTime timestamp, long? orderId = null, int? limit = null, long? recvWindow = null)
        {
            Symbol = symbol;
            OrderID = orderId;
            Limit = limit;
            RecvWindow = recvWindow;
            Timestamp = timestamp;
        }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}&" +
                (OrderID == null ? string.Empty : $"orderID={OrderID}&") +
                (Limit == null ? string.Empty : $"limit={Limit}&") +
                (RecvWindow == null ? string.Empty : $"recvWindow={RecvWindow}&") +
                $"timestamp={Timestamp.ToTimestamp()}";
            return parameters;
        }
    }
}
