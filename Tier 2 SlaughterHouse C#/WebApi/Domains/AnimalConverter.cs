using WebApi.Domains.DTOs;
using SlaughterHouse.Api;

namespace WebApi.Domains;

public class AnimalConverter
{
    
    public static AnimalDto ToDto(Animal animal)
    {
        // TODO: change last regNum to FARM
        return new AnimalDto((int)animal.AnimalId, animal.RegistrationNumber,
            animal.AnimalWeight, animal.ArrivalDate,
            animal.RegistrationNumber);
    }

    public static Animal CreateToProto(CreateAnimalDto dto)
    {
        var animal = new Animal
        {
            AnimalWeight = dto.AnimalWeight,
            ArrivalDate = dto.ArrivalDate
            // Farm = dto.Farm
        };
        return animal;
    }

    public static Animal AnimalToProto(AnimalDto dto)
    {
        var animal = new Animal
        {
            AnimalId = dto.AnimalId,
            RegistrationNumber = dto.RegistrationNumber,
            AnimalWeight = dto.AnimalWeight,
            ArrivalDate = dto.ArrivalDate
            // Farm = dto.Farm
        };
        return animal;
    }
}