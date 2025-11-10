using Google.Protobuf.WellKnownTypes;
using SlaughterHouse.Api;
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

app.Logger.LogInformation("Tier3 gRPC at {Addr}", builder.Configuration["Tier3:GrpcAddress"]);

app.Run();

