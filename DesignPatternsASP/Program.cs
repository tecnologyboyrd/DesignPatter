using DesignPatternsASP.Interfaces;
using DesignPatternsASP.Setups;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Tools.Earn;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var pathLog = builder.Services.AddTransient<ImySetup, MySetups2>();

builder.Services.Configure<MySetups>(builder.Configuration.GetSection("MySetups2"));
builder.Services.AddTransient((factory) =>
{
    return new LocalEarnFactory(builder.Configuration.GetSection("MySetups2").GetValue<decimal>("LocalPercentage"));
});

builder.Services.AddTransient((factory) =>
{
    return new ForeignEarnFactory(builder.Configuration.GetSection("MySetups2").GetValue<decimal>("ForeignPercentage"), builder.Configuration.GetSection("MySetups2").GetValue<decimal>("Extra"));
});



builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
