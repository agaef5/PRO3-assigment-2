using SharedHTTPs.AnimalContracts;
using WebApi.Services.Interfaces;

namespace WebApi.Controllers;

public class AnimalControllers
{
    public static void Map(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/slaughterhouse/animals");
        
        group.MapGet("", async (IAnimalService service) =>
        {
            var res = await service.GetAllAnimalsAsync();
            return Results.Ok(res);
        });
        
        group.MapPost("", async (CreateAnimalHttpRequest request, IAnimalService service) =>
            {
                try{
                    AnimalHttpResponse? created = await service.CreateAnimalAsync(request);
                    // return created is null ? Results.Empty : Results.Created($"/slaughterhouse/animals/{created.AnimalId}", created);
                    return created is null ? Results.Empty : Results.Created($"/slaughterhouse/animals", created);
                    
                }catch (Exception e)
                {
                    app.ServiceProvider.GetRequiredService<ILoggerFactory>()
                        .CreateLogger("Animals").LogError(e, "Create failed");
                    return Results.Problem(e.Message, statusCode: 500);
                }
            }
            );

        group.MapGet("/{id:long}",
            async (long id, IAnimalService service) =>
            {
                var animal = await service.GetAnimalByIdAsync(id);
                return animal is null ? Results.NotFound() : Results.Ok(animal);;
            }).WithName("GetAnimalById");
    }
    
    
}