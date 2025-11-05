using Google.Protobuf.WellKnownTypes;
using SlaughterHouse.Api;

namespace WebApi.Gateways.Clients;

public class AnimalClient(SlaughterHouseService.SlaughterHouseServiceClient svC)
{
    public async Task<AnimalResponse> AddAnimalAsync(string regNum, double weight, DateTime arrivalDate)
    {
        var arrivalUtc = arrivalDate.Kind == DateTimeKind.Utc
            ? arrivalDate
            : arrivalDate.ToUniversalTime();
        
        Animal animal = new Animal
        {
            AnimalWeight = weight,
            ArrivalDate = Timestamp.FromDateTime(arrivalUtc),
            RegistrationNumber = regNum
        };
        AnimalRequest request = new AnimalRequest { Animal = animal };
        return await svC.AddAnimalAsync(request);
    } 
}