using CLI.ApiContracts;
using CLI.APIs.Animal;

namespace CLI.ViewModels;

public class AnimalVM (IAnimalApi animalApi)
{
    public async Task<CreateAnimalResponse> CreateAnimal(DateTime arrivalDate, string registrationNumber, double animalWeight,
        string farm)
    {
        CreateAnimalRequest request = new CreateAnimalRequest(arrivalDate, registrationNumber, animalWeight, farm)
        {
            ArrivalDate =  arrivalDate,
            RegistrationNumber =  registrationNumber,
            AnimalWeight = animalWeight,
            Farm =  farm
        };
        return await animalApi.CreateAnimal(request);
    }
}