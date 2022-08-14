namespace cryptoBot
{
    public class BtcPrice
    {
        public BtcPriceData data { get; set; }
    }
    public class BtcPriceData
    {
        public string @base { get; set; }
        public string currency { get; set; }
        public string amount { get; set; }
    }
}