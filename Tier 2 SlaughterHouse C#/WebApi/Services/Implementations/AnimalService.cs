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
    public async Task<AnimalHttpResponse> CreateAnimalAsync(CreateAnimalHttpRequest createAnimalHttpRequest)
    {
        AnimalRequest request = new AnimalRequest
        {
            Animal = 
            {
                AnimalWeight = createAnimalHttpRequest.AnimalWeight,
                ArrivalDate = createAnimalHttpRequest.ArrivalDate.ToTimestamp()
                    // Farm = createAnimalRequest.Farm
            }
        };
        var response = await client.AddAnimalAsync(request);
        return AnimalConverter.ToHttp(response.Animal);
    }

    [HttpGet]
    public async Task<List<AnimalHttpResponse>> GetAllAnimalsAsync()
    {
        var list = await client.GetAllAnimalsAsync(new Empty());
        List<Animal> listOfAnimals = list.Animals.ToList();

        return listOfAnimals.Select(animal => AnimalConverter.ToHttp(animal)).ToList();

    }

    public async Task<AnimalHttpResponse> GetAnimalByIdAsync(int id)
    {
        GetAnimalRequest request = new GetAnimalRequest { AnimalId = id };
        var response = await client.GetAnimalAsync(request);

        return AnimalConverter.ToHttp(response.Animal);
    }
}