using NetBinance.Enum;
using Newtonsoft.Json;
using NetBinance.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NetBinance.AccountEndpoints.Requests
{
    /// <summary>
    /// POST /api/v3/order?
    /// symbol={Symbol}&
    /// side={Side}&
    /// type={Type}&
    /// timeInForce={TimeInForce}&
    /// quantity={Quantity}&
    /// price={Price}&
    /// newClientOrderId={NewClientOrderId[optional]}&
    /// stopPrice={StopPrice[optional]}&
    /// icebergQty={IcebergQuantity[optional]}&
    /// timestamp={Timestamp}
    /// </summary>
    public class NewOrderRequest:IRequestURLParameter
    {
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public OrderType Type { get; set; }
        public TimeInForce TimeInForce { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string NewClientOrderId { get; set; }
        public double? StopPrice { get; set; }
        public double? IcebergQuantity { get; set; }
        public long? RecvWindow { get; set; }
        public DateTime Timestamp { get; set; }

        public string GetUrlParameters()
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            var parameters = $"symbol={Symbol}&" +
                $"side={Side}&" +
                $"type={Type}&" +
                $"timeInForce={TimeInForce}&" +
                $"quantity={Quantity.ToString(nfi)}&" +
                $"price={Price.ToString(nfi)}&" +
                (string.IsNullOrEmpty(NewClientOrderId) ? string.Empty : $"newClientOrderId={NewClientOrderId}&") +
                (StopPrice == null ? string.Empty : $"stopPrice={StopPrice.Value.ToString(nfi)}&") +
                (IcebergQuantity == null ? string.Empty : $"icebergQty={IcebergQuantity.Value.ToString(nfi)}&") +
                (RecvWindow == null ? string.Empty : $"recvWindow={RecvWindow}&") +
                $"timestamp={Timestamp.ToTimestamp()}";
            return parameters;
        }
    }
}
