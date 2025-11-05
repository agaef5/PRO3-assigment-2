using Google.Protobuf.WellKnownTypes;
using SlaughterHouse.Api; // generated from your proto

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.Services.AddGrpcClient<SlaughterHouse.Api.SlaughterHouseService.SlaughterHouseServiceClient>(o =>
    o.Address = new Uri("http://localhost:9090"));

var app = builder.Build();
app.MapOpenApi();

app.MapGet("/slaughterhouse/animals", async (SlaughterHouseService.SlaughterHouseServiceClient client) =>
{
    var res = await client.GetAllAnimalsAsync(new Google.Protobuf.WellKnownTypes.Empty());
    return Results.Ok(res.Animals);
});

app.MapGet("/_probe/tier3", async (SlaughterHouseService.SlaughterHouseServiceClient c) =>
{
    try
    {
        var deadline = DateTime.UtcNow.AddSeconds(3);
        var res = await c.GetAllAnimalsAsync(new Empty(), deadline: deadline);
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

