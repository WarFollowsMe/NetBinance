using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.AccountEndpoints.Responses
{
    /*API JSON Response
    {
      "makerCommission": 15,
      "takerCommission": 15,
      "buyerCommission": 0,
      "sellerCommission": 0,
      "canTrade": true,
      "canWithdraw": true,
      "canDeposit": true,
      "balances": [
        {
          "asset": "BTC",
          "free": "4723846.89208129",
          "locked": "0.00000000"
        },
        {
          "asset": "LTC",
          "free": "4763368.68006011",
          "locked": "0.00000000"
        }
      ]
    } 
    */
    public class AccountInfoResponse
    {
        public long MarkerCommission { get; set; }
        public int TakerCommission { get; set; }
        public int BuyerCommission { get; set; }
        public int SellerCommission { get; set; }
        public bool CanTrade { get; set; }
        public bool CanWithdraw { get; set; }
        public bool CanDeposit { get; set; }
        public CoinBalance[] Balances { get; set; }
    }
}
