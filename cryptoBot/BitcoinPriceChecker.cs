using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace cryptoBot
{
    internal class BitcoinPriceChecker
    {
        public async Task checkBitcoinPrice(string URL)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("prices/BTC-EUR/spot");
            var response = client.ExecuteGet(request);
            Console.WriteLine(response.Content);
        }
    }
}
