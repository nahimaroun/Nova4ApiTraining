namespace NovaApiTraining.DTOs
{
    public class Bitfinex
    {
        public int Id { get; set; }
        public double last_price { get; set; }
        public double timestamp { get; set; }
        public DateTime Converted { get; set; }
    }
}
