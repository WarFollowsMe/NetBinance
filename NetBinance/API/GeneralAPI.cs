using System;
using System.Threading.Tasks;
using NetBinance.GeneralEndpoints;
using NetBinance.Converters;
using NetBinance.Enum;

namespace NetBinance.API
{
    /// <summary>
    /// General endpoints
    /// </summary>
    public class GeneralAPI:API
    {
        public GeneralAPI() : base("https://www.binance.com/api/v1/") { }

        /// <summary>
        /// Test connectivity to the Rest API.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Ping()
        {
            var response = await _client.GetAsync("ping");
            response.EnsureSuccessStatusCode();
            return true;
        }

        /// <summary>
        /// Test connectivity to the Rest API and get the current server time.
        /// </summary>
        /// <returns></returns>
        public async Task<DateTime> ServerTime()
        {
            var response = await RequestJsonAsync<TimeResponse>(MethodType.GET, "time");
            return response.ServerTime.ToDateTime();
        }
    }
}
