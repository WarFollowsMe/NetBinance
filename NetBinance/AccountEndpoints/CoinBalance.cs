namespace NetBinance.AccountEndpoints
{
    public class CoinBalance
    {
        public string Asset { get; set; }
        public double Free { get; set; }
        public double Locked { get; set; }
    }
}
