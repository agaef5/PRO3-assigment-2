using SharedHTTPs.AnimalContracts;
using SlaughterHouse.Api;

namespace WebApi.Domains;

public class AnimalConverter
{

    public static AnimalHttpResponse ToHttp(Animal animal)
    {

        // TODO: change FARM 
        return new AnimalHttpResponse
        {
            AnimalId = animal.AnimalId,
            AnimalWeight = animal.AnimalWeight,
            ArrivalDateUtc = animal.ArrivalDate.ToDateTime(),
            Farm = animal.Farm,
            RegistrationNumber = animal.RegistrationNumber
        };
    }
    
    
}