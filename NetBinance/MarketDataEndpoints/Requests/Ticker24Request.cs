using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.MarketDataEndpoints.Requests
{
    /// <summary>
    /// GET /api/v1/ticker/24hr?
    /// symbol={Symbol}
    /// </summary>
    public class Ticker24Request:IRequestURLParameter
    {
        public string Symbol { get; set; }

        public string GetUrlParameters()
        {
            return $"symbol={Symbol}";
        }
    }
}
