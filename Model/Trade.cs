namespace TradeCLI.Model
{
    public class Trade
    {

        public int InstrumentId { get; set; }
        public string  Name { get; set; }
        public decimal ClosePrice { get; set; }
        public DateTime MaxDate { get; set; }

    }
}
