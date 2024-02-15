using DNC13_HttpClient.ServiceContracts;
using System.Text.Json;

namespace DNC13_HttpClient.Services
{
    public class StockService : IStockService
    {
        private readonly IHttpClientFactory _httpClientFactoryObj;
        private readonly IConfiguration _configurationObj;

        public StockService(IHttpClientFactory httpClientFactoryObj, IConfiguration configurationObj)
        {
            _httpClientFactoryObj = httpClientFactoryObj;
            _configurationObj = configurationObj;
        }

        public async Task<Dictionary<string, object>?> GetStockQuote(string stock_symbol)
        {
            using (HttpClient httpClientObj = _httpClientFactoryObj.CreateClient())
            {
                HttpRequestMessage httpRequestMessageObj = new HttpRequestMessage()
                {
                    RequestUri = new Uri($"https://finnhub.io/api/v1/quote?symbol={stock_symbol}&token={_configurationObj["FinnhubToken"]}"),
                    Method = HttpMethod.Get
                };
                
                HttpResponseMessage httpResponseMessageObj = await httpClientObj.SendAsync(httpRequestMessageObj);

                Stream streamObj = httpResponseMessageObj.Content.ReadAsStream();
                StreamReader streamReaderObj = new StreamReader(streamObj);
                string stream_content = streamReaderObj.ReadToEnd();

                Dictionary<string, object>? stream_content_dict = JsonSerializer.Deserialize<Dictionary<string, object>>(stream_content);

                if (stream_content_dict == null)
                {
                    throw new InvalidOperationException("No response from finnhub stock api.");
                }

                if (stream_content_dict.ContainsKey("error"))
                {
                    throw new InvalidOperationException(Convert.ToString(stream_content_dict["error"]));
                }

                return stream_content_dict;
            }
        }
    }
}
