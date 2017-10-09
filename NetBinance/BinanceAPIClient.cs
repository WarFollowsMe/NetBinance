using NetBinance.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance
{
    public class BinanceAPIClient
    {
        public GeneralAPI GeneralEndpoints { get; private set; }
        public MarketDataAPI MarketDataEndpoints { get; private set; }
        public AccountAPI AccountEndpoints { get; private set; }

        public BinanceAPIClient(string key, string secret)
        {
            GeneralEndpoints = new GeneralAPI();
            MarketDataEndpoints = new MarketDataAPI();
            AccountEndpoints = new AccountAPI(key, secret);
        }
    }
}
