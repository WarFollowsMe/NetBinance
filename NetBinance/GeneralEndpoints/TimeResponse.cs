using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBinance.GeneralEndpoints
{
    /*Binance API JSON Response example
    {
      "serverTime": 1499827319559
    } 
    */
    public class TimeResponse
    {
        public long ServerTime { get; set; }
    }
}
