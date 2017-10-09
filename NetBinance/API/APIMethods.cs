using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.API
{
    public static class APIMethods
    {
        public const string Ping = "ping";
        public const string Time = "time";
        public const string Depth = "depth";
        public const string AggregateTrades = "aggTrades";
        public const string Klines = "klines";
        public const string Ticker24hr = "ticker/24hr";
        public const string AllPrices = "ticker/allPrices";
        public const string AllBookTickers = "ticker/allBookTickers";
        public const string Order = "order";
        public const string TestOrder = "order/test";
        public const string OpenOrders = "openOrders";
        public const string AllOrders = "allOrders";
        public const string Account = "account";
        public const string AccountTrades = "myTrades";
    }
}
