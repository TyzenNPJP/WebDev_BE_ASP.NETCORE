using DNC13_HttpClient.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using DNC13_HttpClient.Models;

namespace DNC13_HttpClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly StockService _stockService;
        private readonly IOptions<TradingOptions> _tradingOptionsObj;

        public HomeController(StockService stockService, IOptions<TradingOptions> tradingOptions)
        {
            _stockService = stockService;
            _tradingOptionsObj = tradingOptions;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            if (_tradingOptionsObj.Value.default_trading_symbol == null)
            {
                _tradingOptionsObj.Value.default_trading_symbol = "MSFT";
            }

            Dictionary<string, object>? response_dict = await _stockService.GetStockQuote(_tradingOptionsObj.Value.default_trading_symbol);

            Stock stock = new Stock() {
                stock_symbol = _tradingOptionsObj.Value.default_trading_symbol,
                open_price = Convert.ToDouble(response_dict["o"].ToString()),
                current_price = Convert.ToDouble(response_dict["c"].ToString()),
                high_price = Convert.ToDouble(response_dict["h"].ToString()),
                low_price = Convert.ToDouble(response_dict["l"].ToString())
            };

            return View(stock);
        }
    }
}
