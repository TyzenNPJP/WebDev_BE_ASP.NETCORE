using DNC13_HttpClient.Services;

namespace DNC13_HttpClient.ServiceContracts
{
    public interface IStockService
    {
        Task<Dictionary<string, object>?> GetStockQuote(string stock_symbol);
    }
}
