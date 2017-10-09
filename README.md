# NetBinance
Binance REST API .Net Wrapper 

It is unofficial .Net wrapper of [Binance API](https://www.binance.com/restapipub.html)

## How-to use.
```
var client = new BinanceAPIClient(key, secret);

var accountInfo = await client.AccountEndpoints.AccountInfo(new AccountInfoRequest
{
    RecvWindow = 600000,
    Timestamp = DateTime.Now
});

var ethBalance = accountInfo.Balances.FirstOrDefault(b => b.Asset == "ETH");

var totalEthAmount = ethBalance.Free+ethBalance.Locked;

var orderInfo = await client.AccountEndpoints.NewOrder(new NewOrderRequest
{
    Symbol = "ETHBTC",
    Side = OrderSide.SELL,
    Type = OrderType.LIMIT,
    TimeInForce = TimeInForce.GTC,
    Price = 0.01,
    Quantity = ethBalance.Free,
    RecvWindow = 600000,
    Timestamp = DateTime.Now
});

var orderStatus = await client.AccountEndpoints.CheckOrderStatus(new OrderStatusRequest
{
    Symbol = "ETHBTC",
    OrderID = order.OrderID,
    RecvWindow = 600000,
    Timestamp = DateTime.Now
});

var cancelOrder = await client.AccountEndpoints.CancelOrder(new CancelOrderRequest
{
    Symbol = order.Symbol,
    OrderID = order.OrderID,
    Timestamp = DateTime.Now,
    RecvWindow = 600000
});
```
