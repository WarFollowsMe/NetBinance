using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.MarketDataEndpoints.Requests
{
    /// <summary>
    /// GET /api/v1/depth?
    /// symbol={Symbol}&
    /// limit={Limit[optional;default=100;max=100]}
    /// </summary>
    public class DepthRequest:IRequestURLParameter
    {
        private int? _limit;

        public string Symbol { get; set; }
        public int? Limit {
            get { return _limit; }
            set
            {
                if (value <= 100)
                    _limit = value;
                else _limit = 100;
            }
        }

        public string GetUrlParameters()
        {
            var parameters = $"symbol={Symbol}" +
                (Limit == null ? string.Empty : $"&limit={Limit}");
            return parameters;
        }
    }
}
