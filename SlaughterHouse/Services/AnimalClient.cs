using Google.Protobuf.WellKnownTypes;
using SlaughterHouse.Api;

namespace SlaughterHouse.Services;

public class AnimalClient(SlaughterHouseService.SlaughterHouseServiceClient svC)
{
    private readonly SlaughterHouseService.SlaughterHouseServiceClient _svC =
        svC;
    
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
        return await _svC.AddAnimalAsync(request);
    } 
}