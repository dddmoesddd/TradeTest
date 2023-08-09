using Microsoft.AspNetCore.Mvc;
using System.Text;
using TradeCLI.DB;
using TradeCLI.Model;
using TradeTest.FrameWork;
using TradeTest.Resources;

namespace TradeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradeController : ControllerBase
    {

        private readonly ITradeRepository _repo;
        public TradeController(ILogger<TradeController> logger, ITradeRepository repo)
        {
          
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        [HttpGet("GetTradesAsync")]
        public  async Task<Result> GetTradesAsync()
        {
            try
            {
                var result = await _repo.GetTradesAsync();
                return result;
               
            }
            catch (Exception ex)
            {
                var message = new StringBuilder();
                message.Append(ex.Message);
                message.AppendFormat(Environment.NewLine);
                message.Append(TradeMessages.GetTradeException);

                return new Result()
                {
                    Data = new List<Trade>(),
                    Code = 500,
                    IsSuccess = false,
                    Message = message.ToString() ?? string.Empty
                };
            }
      
        }
    }
}