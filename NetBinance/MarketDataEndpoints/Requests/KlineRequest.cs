using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBinance.Converters;

namespace NetBinance.MarketDataEndpoints.Requests
{
    /// <summary>
    /// GET /api/v1/klines?
    /// symbol={Symbol}&
    /// interval={Interval}&
    /// limit={Limit[optional;default=500;max=500]}&
    /// startTime={StartTime[optional]}&
    /// endtime={EndTime[optional]
    public class KlinesRequest:IRequestURLParameter
    {
        private int? _limit;

        public string Symbol { get; set; }
        public Interval Interval { get; set; }
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
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}&" +
                $"interval={Interval}" +
                (Limit == null ? string.Empty : $"&limit={Limit}&") +
                (StartTime == null ? string.Empty : $"startTime={StartTime.Value.ToTimestamp()}&") +
                (EndTime == null ? string.Empty : $"endTime={EndTime.Value.ToTimestamp()}");
            return parameters;
        }
    }
}
