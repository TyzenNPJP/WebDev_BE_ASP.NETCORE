namespace DNC13_HttpClient.Models
{
    public class Stock
    {
        public string? stock_symbol { get; set; }
        public double current_price { get; set; }
        public double high_price { get; set; }
        public double low_price { get; set;}
        public double open_price { get; set; }
    }
}
