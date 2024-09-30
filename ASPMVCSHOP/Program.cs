using ASPMVCSHOP.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseDefaultServiceProvider(options => options.ValidateScopes = false);

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<AplicationDbContext>(options => 
options.UseSqlServer(configuration["Data:FoodDeliveryShopProducts:ConnectionStrings"])
);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IProductRepository,FakeProductRepository>();
builder.Services.AddTransient<IProductRepository, EFProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseStatusCodePages();
app.UseDeveloperExceptionPage();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=List}/{id?}");
    
SeedData.EnsurePopulated(app);

app.Run();
