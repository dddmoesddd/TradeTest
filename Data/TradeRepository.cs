using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TradeCLI.Model;
using TradeTest.FrameWork;
using TradeTest.Resources;

namespace TradeCLI.DB
{
    public class TradeRepository : ITradeRepository
    {
        private readonly DapperContext _context;
        public TradeRepository(DapperContext context)
        {
          
            _context = context ?? throw new ArgumentNullException(nameof(context));
       
        }

    
        public async Task<Result> GetTradesAsync()
        {
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    var trans = connection.BeginTransaction();

                    var result = await connection.QueryAsync<Trade>(Utility.query, transaction: trans);
                    trans.Commit();
                    if (result != null && result.ToList().Count != 0)
                    {
                        return new Result()
                        {
                            Data = result.ToList(),
                            Code = 200,
                            IsSuccess = true,
                            Message = TradeMessages.GetTradeSuccess ?? string.Empty
                        };
                    }

                    else
                    {
                        return new Result()
                        {
                            Data = new List<Trade>(),
                            Code = 404,
                            IsSuccess = true,
                            Message = TradeMessages.TradeNotFound ?? string.Empty
                        };
                    }


                }
            }
            catch (Exception ex)
            {
                throw new TradeExcption(ex.Message, ex.InnerException);
            }

        }

    }
}
