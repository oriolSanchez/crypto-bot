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
    internal class BitcoinHistoric
    {

        public void CheckBitcoinPriceHistory(string url)
        {
            //Using RestSharp, set up a RestClient, search for bitcoin price in API route prices/BTC-EUR/spot,
            //request in JSON format then deserialize to get the historic amount, then compare to DB and add last results if necessary    
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest("prices/BTC-USD/historic?start=2018-01-01T00:00:00&end=2018-01-20T00:00:00")
            {
                RequestFormat = DataFormat.Json
            };
            var response = client.ExecuteGet(request);
            BtcPriceHistoric root = JsonSerializer.Deserialize<BtcPriceHistoric>(response.Content);
            int counter = 0;
            foreach (Price element in root.data.prices)
            {
                Console.WriteLine($"{counter}: In day {element.time} BTC price was {element.price} USD");
                counter++;

            }
        }
    }
}
