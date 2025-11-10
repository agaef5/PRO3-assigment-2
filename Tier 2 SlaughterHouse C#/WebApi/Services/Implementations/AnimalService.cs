using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using SharedHTTPs.AnimalContracts;
using SlaughterHouse.Api;
using WebApi.Domains;
using WebApi.Gateways.Clients;
using WebApi.Services.Interfaces;

namespace WebApi.Services.Implementations;

public class AnimalService(
    SlaughterHouseService.SlaughterHouseServiceClient client) : IAnimalService
{
    [HttpPost]
    public async Task<AnimalHttpResponse?> CreateAnimalAsync(CreateAnimalHttpRequest req)
    {
        
        if (req == null) throw new ArgumentNullException(nameof(req));
        
        var utcArrival = DateTime.SpecifyKind(req.ArrivalDateUtc, DateTimeKind.Utc);
        
        var protoAnimal = new Animal
        {
            AnimalWeight = req.AnimalWeight,
            ArrivalDate = Timestamp.FromDateTime(utcArrival),
            // Ori = req.Farm ?? "TEMP_FARM"
        };

        try
        {
            var resp = await client.AddAnimalAsync(new AnimalRequest { Animal = protoAnimal });
            return AnimalConverter.ToHttp(resp.Animal);
        }
        catch (Grpc.Core.RpcException ex)
        {
            var diag = ex.Trailers.GetValue("grpc-status-details-bin"); // may be null
            var msg  = ex.Status.Detail;
            Console.Write((ex, "AddAnimal failed. Detail: {Detail}. Trailers: {Trailers}", msg, diag));
            throw; // keep your 500 for now
        }
        
        
        // AnimalRequest request = new AnimalRequest
        // {
        //     Animal = 
        //     {
        //         AnimalWeight = createAnimalHttpRequest.AnimalWeight,
        //         ArrivalDate = createAnimalHttpRequest.ArrivalDate.ToTimestamp(),
        //         // Origin = createAnimalRequest.Farm
        //     }
        // };
        // var response = await client.AddAnimalAsync(request);
        // return AnimalConverter.ToHttp(response.Animal);
    }

    [HttpGet]
    public async Task<List<AnimalHttpResponse>> GetAllAnimalsAsync()
    {
        var list = await client.GetAllAnimalsAsync(new Empty());
        List<Animal> listOfAnimals = list.Animals.ToList();

        return listOfAnimals.Select(animal => AnimalConverter.ToHttp(animal)).ToList();

    }

    [HttpGet]
    public async Task<AnimalHttpResponse?> GetAnimalByIdAsync(long id)
    {
        GetAnimalRequest request = new GetAnimalRequest { AnimalId = id };
        var response = await client.GetAnimalAsync(request);

        return AnimalConverter.ToHttp(response.Animal);
    }
}