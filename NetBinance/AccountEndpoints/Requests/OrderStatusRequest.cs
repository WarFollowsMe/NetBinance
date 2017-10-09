using NetBinance.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints.Requests
{
    /// <summary>
    /// GET /api/v3/order?
    /// symbol={Symbol}&
    /// orderId={OrderID[optional]}&
    /// origClientOrderId={OrigClientOrderId[optional]}&
    /// recvWindow={RecvWindow[optional]}&
    /// timestamp={Timestamp}
    /// </summary>
    public class OrderStatusRequest:IRequestURLParameter
    {
        public string Symbol { get; set; }
        public long? OrderID { get; set; }
        public string OrigClientOrderId { get; set; }
        public long? RecvWindow { get; set; }
        public DateTime Timestamp { get; set; }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}&" +
                (OrderID == null ? string.Empty : $"orderID={OrderID}&") +
                (string.IsNullOrEmpty(OrigClientOrderId) ? string.Empty : $"origClientOrderId={OrigClientOrderId}&") +
                (RecvWindow == null ? string.Empty : $"recvWindow={RecvWindow}&") +
                $"timestamp={Timestamp.ToTimestamp()}";
            return parameters;
        }
    }
}
