using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/observation/{zipCode}", (string zipCode, [FromQuery] int? days) =>
{
    return Results.Ok("ZipCode is: " + zipCode);
}); 

app.Run();
