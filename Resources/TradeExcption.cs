namespace TradeTest.Resources
{
    public class TradeExcption:Exception
    {
        public TradeExcption()
        {
             
        }

        public TradeExcption(string? message) : base(message)
        {

        }

        public TradeExcption(string message, Exception? innerException) : base(message, innerException)
        {
        }


    }
}
