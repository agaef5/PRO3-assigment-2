using SharedHTTPs.AnimalContracts;
using WebApi.Services.Interfaces;

namespace WebApi.Controllers;

public class AnimalControllers
{
    public static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/slaughterhouse/animals", async (IAnimalService service) =>
        {
            var res = await service.GetAllAnimalsAsync();
            return Results.Ok(res);
        });
        
        app.MapPost("/slaughterhouse/animals", async (CreateAnimalHttpRequest dto, IAnimalService service) =>
            {
                AnimalHttpResponse created = await service.CreateAnimalAsync(dto);
                return Results.Created($"/api/animals/{created.AnimalId}", created);
            }
            );

        app.MapGet("slaughterhouse/animals/{id:long}",
            async (int id, IAnimalService service) =>
            {
                var animal = await service.GetAnimalByIdAsync(id);
                return Results.Ok(animal);
            });
    }
    
    
}