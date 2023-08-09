using TradeCLI.Model;
using TradeTest.FrameWork;

namespace TradeCLI.DB
{
    public  interface ITradeRepository
    {
        Task<Result> GetTradesAsync();
    }
}
