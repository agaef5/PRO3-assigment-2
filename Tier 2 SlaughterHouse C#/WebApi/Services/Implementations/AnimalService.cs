using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using SlaughterHouse.Api;
using WebApi.Domains;
using WebApi.Domains.DTOs;
using WebApi.Gateways.Clients;

namespace WebApi.Services.Implementations;

public class AnimalService(
    SlaughterHouseService.SlaughterHouseServiceClient client) : IAnimalService
{
    [HttpPost]
    public async Task<AnimalDto> CreateAnimalAsync(CreateAnimalDto dto)
    {
        AnimalRequest request = new AnimalRequest {Animal = AnimalConverter.CreateToProto(dto)};
        var response = await client.AddAnimalAsync(request);
        return AnimalConverter.ToDto(response.Animal);
    }

    [HttpGet]
    public async Task<List<AnimalDto>> GetAllAnimalsAsync()
    {
        var list = await client.GetAllAnimalsAsync(new Empty());
        List<Animal> listOfAnimals = list.Animals.ToList();

        return listOfAnimals.Select(animal => AnimalConverter.ToDto(animal)).ToList();

    }

    public async Task<AnimalDto> GetAnimalByIdAsync(int id)
    {
        GetAnimalRequest request = new GetAnimalRequest { AnimalId = id };
        var response = await client.GetAnimalAsync(request);

        return AnimalConverter.ToDto(response.Animal);
    }
}