using Microsoft.AspNetCore.Builder;

using Bookstore.Web.Startup;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

Console.WriteLine("📡 Connection string: " + connectionString);


builder.ConfigureConfiguration();

builder.ConfigureServices();

builder.ConfigureAuthentication();

builder.ConfigureDependencyInjection();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(80); // ????? ?? HTTP ???? 80
});


var app = builder.Build();

await app.ConfigureMiddlewareAsync();

app.Run();