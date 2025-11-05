using SlaughterHouse.Api; // generated from your proto

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapOpenApi();

app.MapGet("/slaughterhouse/animals", async (SlaughterHouseService.SlaughterHouseServiceClient client) =>
{
    var res = await client.GetAllAnimalsAsync(new Google.Protobuf.WellKnownTypes.Empty());
    return Results.Ok(res.Animals);
});

app.Run();