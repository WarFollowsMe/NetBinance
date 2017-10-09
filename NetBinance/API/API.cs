using NetBinance.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.API
{
    public abstract class API
    {
        internal HttpClient _client;

        public API(string baseUrl)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseUrl);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("User-Agent", ".NET Binance API Client");
        }

        internal async Task<T> RequestJsonAsync<T>(MethodType method, string requestUri, IRequestURLParameter parameters = null, 
                                                bool signed = false, byte[] signature = null)
        {
            var url = requestUri;

            if (parameters != null)
            {
                var strQueryParams = parameters.GetUrlParameters();
                    url += "?" + strQueryParams;

                if (signed)
                {
                    url += "&signature=" + SignData(strQueryParams, signature);
                }
            }
            HttpResponseMessage response = null;
            if (method == MethodType.GET)
                response = await _client.GetAsync(url);
            else if (method == MethodType.POST)
                response = await _client.PostAsync(url, null);
            else if (method == MethodType.DELETE)
                response = await _client.DeleteAsync(url);
            else if (method == MethodType.PUT)
                response = await _client.PutAsync(url, null);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                var message = $"{response.StatusCode} {response.ReasonPhrase}\n{errorContent}";

                throw new HttpRequestException(message);
            }

            var content = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<T>(content);

            return responseObject;
        }

        private string SignData(string parameters, byte[] secret)
        {
            using (HMACSHA256 hmac = new HMACSHA256(secret))
            {
                var data = System.Text.Encoding.UTF8.GetBytes(parameters);
                return string.Concat(hmac.ComputeHash(data).Select(b => b.ToString("X2")).ToArray()).ToLower();
            }
        }
    }
}
