using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using RestSharp;

namespace cryptoBot
{
    internal class BitcoinPriceChecker
    {
        public void checkBitcoinPriceNow(string url)
        {
            //Using RestSharp, set up a RestClient, search for bitcoin price in API route prices/BTC-EUR/spot, request in JSON format then deserialize to get the amount at the moment.     
            var client = new RestClient(url);
            var request = new RestRequest("prices/BTC-EUR/spot");
            request.RequestFormat = DataFormat.Json;
            var response = client.ExecuteGet(request);
            var root = JsonSerializer.Deserialize<BtcPrice>(response.Content);
            Console.WriteLine(root.data.amount);
        }
    }
}
