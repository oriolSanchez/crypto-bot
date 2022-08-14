using System;
using System.Collections.Generic;

namespace cryptoBot
{
    public class Price
    {
        public string price { get; set; }
        public DateTime time { get; set; }
    }
    public class BtcPriceHistoricData
    {
        public string @base { get; set; }
        public string currency { get; set; }
        public List<Price> prices { get; set; }
    }
    public class BtcPriceHistoric
    {
        public BtcPriceHistoricData data { get; set; }

    }
}