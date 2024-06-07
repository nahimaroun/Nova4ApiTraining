namespace NovaApiTraining.DTOs
{
    public class Crypto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime timeStamp { get; set; }
        public string? Source { get; set; }
    }
}
