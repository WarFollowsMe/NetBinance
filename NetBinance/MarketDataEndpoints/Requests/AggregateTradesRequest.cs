using System;
using NetBinance.Converters;
using System.Collections.Generic;

namespace NetBinance.MarketDataEndpoints.Requests
{
    /// <summary>
    /// GET /api/v1/aggTrades?
    /// symbol={Symbol}&
    /// fromId={Limit[optional]}&
    /// startTime={StartTime[optional]}&
    /// endTime={EndTime[optional]}&
    /// limit={Limit[optional;default=500;max=500]}
    /// </summary>
    public class AggregateTradesRequest:IRequestURLParameter
    {
        private int? _limit;

        public string Symbol { get; set; }
        public long? FromID { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Limit
        {
            get { return _limit; }
            set
            {
                if (value <= 500)
                    _limit = value;
                else _limit = 500;
            }
        }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}" +
                (FromID == null ? string.Empty : $"&fromId={FromID}&") +
                (StartTime == null ? string.Empty : $"startTime={StartTime.Value.ToTimestamp()}&") +
                (EndTime == null ? string.Empty : $"endTime={EndTime.Value.ToTimestamp()}&") +
                (Limit == null ? string.Empty : $"limit={Limit}");
            return parameters;
        }
    }
}