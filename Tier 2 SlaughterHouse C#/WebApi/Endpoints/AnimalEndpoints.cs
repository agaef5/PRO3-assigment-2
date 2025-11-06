using Google.Protobuf.WellKnownTypes;
using SlaughterHouse.Entities;
using WebApi.Domains.DTOs;
using WebApi.Gateways.Clients;

namespace WebApi.Endpoints;

public class AnimalEndpoints
{
    public static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/slaughterhouse/animals", async (IAnimalService service) =>
        {
            var res = await service.GetAllAnimalsAsync();
            return Results.Ok(res.Animals);
        });
        
        
        app.MapPost("/api/animals", async (AnimalDto dto, IAnimalService service) =>
            Results.Created($"/api/animals/{dto.AnimalId}", 
                await service.AddAnimalAsync(dto)));
        
        // app.MapGet("slaughterhouse/animals/{id}", async ())
    }
    
    
}