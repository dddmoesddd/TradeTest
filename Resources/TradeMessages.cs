using System.Globalization;
using System.Resources;

namespace TradeTest.Resources
{
    public class TradeMessages
    {
        private static readonly ResourceManager Rm = new("TradeTest.Resources.TradeResources",
            typeof(TradeMessages).Assembly);

        
        public static string? GetTradeException =
            string.IsNullOrEmpty(Rm.GetString("GetTradeException", CultureInfo.CurrentCulture))
                ? string.Empty
                : Rm.GetString("GetTradeException", CultureInfo.CurrentCulture);
        

        public static string? GetTradeSuccess =
           string.IsNullOrEmpty(Rm.GetString("GetTradeSuccess", CultureInfo.CurrentCulture))
               ? string.Empty
               : Rm.GetString("GetTradeSuccess", CultureInfo.CurrentCulture);


        public static string? TradeNotFound =
           string.IsNullOrEmpty(Rm.GetString("TradeNotFound", CultureInfo.CurrentCulture))
               ? string.Empty
               : Rm.GetString("TradeNotFound", CultureInfo.CurrentCulture);
    }
   
}
