using TradeCLI.Model;

namespace TradeTest.FrameWork
{
    public class Result
    {

        public  bool IsSuccess { get; set; }    
        public  string  Message { get; set; }

        public  int Code { get; set; }
        public  List<Trade>  Data { get; set; }
    }
}
