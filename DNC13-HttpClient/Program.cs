using DNC13_HttpClient;
using DNC13_HttpClient.Services;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddScoped<StockService>();

// Adds Trading Options as a service
builder.Services.Configure<TradingOptions>(builder.Configuration.GetSection(nameof(TradingOptions)));


var app = builder.Build();

app.Run();
