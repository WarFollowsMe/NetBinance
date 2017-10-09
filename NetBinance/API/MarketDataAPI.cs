using NetBinance.Enum;
using NetBinance.MarketDataEndpoints;
using NetBinance.MarketDataEndpoints.Requests;
using NetBinance.MarketDataEndpoints.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.API
{
    /// <summary>
    /// Market Data endpoints
    /// </summary>
    public class MarketDataAPI : API
    {
        public MarketDataAPI() : base("https://www.binance.com/api/v1/") { }

        /// <summary>
        /// Order book
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<DepthResponse> Depth(DepthRequest request)
        {
            return await RequestJsonAsync<DepthResponse>(MethodType.GET, APIMethods.Depth, request);
        }

        /// <summary>
        /// Get compressed, aggregate trades. Trades that fill at the time, from the same order, with the same price will have the quantity aggregated.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<IEnumerable<AggregateTrade>> AggregateTrades(AggregateTradesRequest request)
        {
            return await RequestJsonAsync<IEnumerable<AggregateTrade>>(MethodType.GET, APIMethods.AggregateTrades, request);
        }

        /// <summary>
        /// Kline/candlestick bars for a symbol. Klines are uniquely identified by their open time.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<IEnumerable<Kline>> Klines(KlinesRequest request)
        {
            return await RequestJsonAsync<IEnumerable<Kline>>(MethodType.GET, APIMethods.Klines, request);
        }

        /// <summary>
        /// 24hr ticker price change statistics
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<Ticker24Response> Ticker24(Ticker24Request request)
        {
            return await RequestJsonAsync<Ticker24Response>(MethodType.GET, APIMethods.Ticker24hr, request);
        }

        /// <summary>
        /// Latest price for all symbols.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PriceItem>> AllPrices()
        {
            return await RequestJsonAsync<IEnumerable<PriceItem>>(MethodType.GET, APIMethods.AllPrices);
        }

        /// <summary>
        /// Best price/qty on the order book for all symbols.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BookTicker>> AllBookTickers()
        {
            return await RequestJsonAsync<IEnumerable<BookTicker>>(MethodType.GET, APIMethods.AllBookTickers);
        }
    }
}
