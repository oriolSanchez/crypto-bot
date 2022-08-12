using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptoBot
{
    public class Program
    {
        static int Main()
        {
            BitcoinPriceChecker priceChecker = new BitcoinPriceChecker();
            priceChecker.checkBitcoinPrice("https://api.coinbase.com/v2/");
            return 0;
        }
    }
}
