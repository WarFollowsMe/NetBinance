namespace NetBinance.MarketDataEndpoints
{    
    /*
    [
      {
        "symbol": "LTCBTC",
        "price": "4.00000200"
      },
      {
        "symbol": "ETHBTC",
        "price": "0.07946600"
      }
    ]
    */
    public class PriceItem
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
    }
}
