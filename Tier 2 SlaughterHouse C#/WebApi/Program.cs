using Google.Protobuf.WellKnownTypes;
using SlaughterHouse.Api;
using WebApi.Controllers;
using WebApi.Services.Implementations;
using WebApi.Services.Interfaces; // generated from your proto

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpcClient<SlaughterHouse.Api.SlaughterHouseService.SlaughterHouseServiceClient>(o =>
    o.Address = new Uri("http://localhost:9090"));

// TODO:add other services
builder.Services.AddScoped<IAnimalService, AnimalService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();


var app = builder.Build();
app.MapOpenApi();

AnimalControllers.Map(app);

// For testing purposes: checking if Tier 2 - Tier 3 connection works
app.MapGet("/_probe/tier3", async (SlaughterHouseService.SlaughterHouseServiceClient client) =>
{
    try
    {
        var deadline = DateTime.UtcNow.AddSeconds(3);
        var res = await client.GetAllAnimalsAsync(new Empty(), deadline: deadline);
        return Results.Ok(new {
            ok = true,
            count = res.Animals.Count
        });
    }
    catch (Exception ex)
    {
        return Results.Problem($"Tier3 call failed: {ex.Message}");
    }
});

app.Run();


