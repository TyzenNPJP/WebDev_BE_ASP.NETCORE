using IProducts;
using Products;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Dependency injection 
// Relate the two class libraries
builder.Services.Add(new ServiceDescriptor(typeof(IProductCatagories), typeof(ProductCatagories), ServiceLifetime.Transient));

var app = builder.Build();

app.MapControllers();

app.Run();