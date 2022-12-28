using Clodweather.Temperature.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TemperatureDbContext>(
    opts =>
    {
        opts.EnableSensitiveDataLogging();
        opts.EnableDetailedErrors();
        opts.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
    }, ServiceLifetime.Transient
);


var app = builder.Build();

//app.MapGet("/observation/{zip}", async (string zip, [FromQuery] int? days, TemperatureDbContext db) =>
//{
//    if (days == null || days < 1 || days > 30)
//    {
//        return Results.BadRequest("Please provide 'days' query parameter between 1 and 30");
//    }

//    var startData = DateTime.UtcNow - TimeSpan.FromDays(days.Value);
//    var results = await db.Temperature.Where(precip => precip.ZipCode == zip && precip.CreatedOn > startData).ToListAsync();

//    return Results.Ok(results);
//});


app.Run();