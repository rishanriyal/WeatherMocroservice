using Microsoft.EntityFrameworkCore;
using CloudWeather.Temperature.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TempDbContext>(
    opts =>
    {
        opts.EnableSensitiveDataLogging();
        opts.EnableDetailedErrors();
        opts.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
    }, ServiceLifetime.Transient
);

var app = builder.Build();

app.Run();
