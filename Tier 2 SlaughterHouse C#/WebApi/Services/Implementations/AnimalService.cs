using Google.Protobuf.WellKnownTypes;
using SlaughterHouse.Api;
using WebApi.Domains.DTOs;

namespace WebApi.Gateways.Clients;

public class AnimalService(
    SlaughterHouseService.SlaughterHouseServiceClient client) : IAnimalService
{
    public async Task<AnimalResponse> AddAnimalAsync(AnimalDto dto)
    {
        var arrivalUtc = dto.ArrivalDate.Kind == DateTimeKind.Utc
            ? dto.ArrivalDate
            : dto.ArrivalDate.ToUniversalTime();
        
        Animal animal = new Animal
        {
            AnimalWeight = dto.AnimalWeight,
            ArrivalDate = Timestamp.FromDateTime(arrivalUtc),
            RegistrationNumber = dto.RegistrationNumber,
            // Origination = dto.Origination
        };
        AnimalRequest request = new AnimalRequest { Animal = animal };
        return await client.AddAnimalAsync(request);
    }

    public async Task<AllAnimalsResponse> GetAllAnimalsAsync()
    {
        return await client.GetAllAnimalsAsync(new Empty());
    }
}