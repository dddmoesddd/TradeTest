namespace TradeTest.FrameWork
{
    public class Utility
    {

        public static string query = @"WITH   
InstrumentQuery  AS(
select      [InstrumentId] InstrumentID, max([DateEn]) MaxDate   from 
[dbo].[Trade]  group by [InstrumentId]
)
select  query.InstrumentID, ins.Name,Trade.ClosePrice ,query.MaxDate from 
InstrumentQuery query  
left  join  [dbo].[Trade] trade  on   query.InstrumentID=trade.[InstrumentId] 
left join [dbo].[Instrument] ins  on  ins.[Id]=query.InstrumentID 
where trade.[DateEn]=query.MaxDate";
    }
}
