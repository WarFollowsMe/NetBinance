using NetBinance.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints.Requests
{
    /// <summary>
    /// DELETE /api/v3/order?
    /// symbol={Symbol}&
    /// orderId={OrderID[optional]}&
    /// origClientOrderId={OrigClientOrderId[optional]}&
    /// newClientOrderId={NewClientOrderId[optional]}&
    /// recvWindow={RecvWindow[optional]}&
    /// timestamp={Timestamp}
    /// </summary>
    public class CancelOrderRequest:IRequestURLParameter
    {
        public string Symbol { get; set; }
        public long? OrderID { get; set; }
        public string OrigClientOrderId { get; set; }
        public string NewClientOrderId { get; set; }
        public long? RecvWindow { get; set; }
        public DateTime Timestamp { get; set; }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}&" +
                (OrderID == null ? string.Empty : $"orderID={OrderID}&") +
                (string.IsNullOrEmpty(OrigClientOrderId) ? string.Empty : $"origClientOrderId={OrigClientOrderId}&") +
                (string.IsNullOrEmpty(NewClientOrderId) ? string.Empty : $"newClientOrderId={NewClientOrderId}&") +
                (RecvWindow == null ? string.Empty : $"recvWindow={RecvWindow}&") +
                $"timestamp={Timestamp.ToTimestamp()}";
            return parameters;
        }
    }
}
