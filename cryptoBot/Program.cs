using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptoBot
{
    public class Program
    {
        static void Main()
        {
            BitcoinPriceChecker priceChecker = new BitcoinPriceChecker();
            string apiUrl = "https://api.coinbase.com/v2/";
            priceChecker.checkBitcoinPriceNow(apiUrl);

            BitcoinHistoric historicPriceChecker = new BitcoinHistoric();
            historicPriceChecker.CheckBitcoinPriceHistory(apiUrl);
        }
    }
}
