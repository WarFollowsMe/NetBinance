using System;
using NetBinance.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints.Requests
{
    /// <summary>
    /// GET /api/v3/myTrades?
    /// symbol={Symbol}&
    /// limit={Limit[optional;default=500;max=500]}&
    /// fromId={FromId[optional]}&
    /// recvWindow={RecvWindow[optional]}&
    /// timestamp={Timestamp}
    /// </summary>
    public class AccountTradeListRequest:IRequestURLParameter
    {
        public string Symbol { get; set; }
        public int? Limit { get; set; }
        public long? FromId { get; set; }
        public long? RecvWindow { get; set; }
        public DateTime Timestamp { get; set; }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}" +
                (Limit == null ? string.Empty : $"limit={Limit}") +
                (FromId == null ? string.Empty : $"recvWindow={FromId}&") +
                (RecvWindow == null ? string.Empty : $"recvWindow={RecvWindow}&") +
                $"timestamp={Timestamp.ToTimestamp()}";
            return parameters;
        }
    }
}
