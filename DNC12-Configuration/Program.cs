// CONFIGURATION
// Storing and Reading API keys from appsettings.json

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseRouting();
app.UseStaticFiles();
app.MapControllers();

app.Run();
