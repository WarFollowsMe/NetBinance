using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetBinance.AccountEndpoints.Requests;
using NetBinance.AccountEndpoints.Responses;
using NetBinance.Enum;
using NetBinance.AccountEndpoints;

namespace NetBinance.API
{
    /// <summary>
    /// Account endpoints
    /// </summary>
    public class AccountAPI : API
    {
        private string _key;
        private byte[] _secret;

        public AccountAPI(string key, string secret) : base("https://www.binance.com/api/v3/")
        {
            _key = key;
            _secret = Encoding.UTF8.GetBytes(secret);
            _client.DefaultRequestHeaders.Add("X-MBX-APIKEY", key);
        }

        /// <summary>
        /// Send in a new order
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<NewOrderResponse> NewOrder(NewOrderRequest request)
        {
            return await RequestJsonAsync<NewOrderResponse>(MethodType.POST, APIMethods.Order, request, true, _secret);
        }

        /// <summary>
        /// Check an order's status.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<Order> CheckOrderStatus(OrderStatusRequest request)
        {
            return await RequestJsonAsync<Order>(MethodType.GET, APIMethods.Order, request, true, _secret);
        }

        /// <summary>
        /// Cancel an active order.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request)
        {
            return await RequestJsonAsync<CancelOrderResponse>(MethodType.DELETE, APIMethods.Order, request, true, _secret);
        }

        /// <summary>
        /// Current open orders
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<IEnumerable<Order>> CurrentOpenOrders(OpenOrdersRequest request)
        {
            return await RequestJsonAsync<IEnumerable<Order>>(MethodType.GET, APIMethods.OpenOrders, request, true, _secret);
        }

        /// <summary>
        /// Get all account orders; active, canceled, or filled.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<IEnumerable<Order>> AllOrders(AllOrdersRequest request)
        {
            return await RequestJsonAsync<IEnumerable<Order>>(MethodType.GET, APIMethods.AllOrders, request, true, _secret);
        }

        /// <summary>
        /// Get current account information.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<AccountInfoResponse> AccountInfo(AccountInfoRequest request)
        {
            return await RequestJsonAsync<AccountInfoResponse>(MethodType.GET, APIMethods.Account, request, true, _secret);
        }

        /// <summary>
        /// Get trades for a specific account and symbol.
        /// </summary>
        /// <param name="request">request parameters</param>
        /// <returns></returns>
        public async Task<IEnumerable<Trade>> AccountTrades(AccountTradeListRequest request)
        {
            return await RequestJsonAsync<IEnumerable<Trade>>(MethodType.GET, APIMethods.AccountTrades, request, true, _secret);
        }
    }
}
