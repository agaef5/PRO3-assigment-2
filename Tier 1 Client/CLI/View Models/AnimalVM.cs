namespace WebAPI.ApiContracts;

public class AnimalVM (IAnimalApi animalApi)
{
    public async Task<CreateAnimalResponse> CreateAnimal(DateTime date, string registragionNr, double weight,
        string origin)
    {
        CreateAnimalRequest request = new CreateAnimalRequest(date, registragionNr, weight, origin)
        {
            date =  date,
            registrationNr =  registragionNr,
            weight = weight,
            origin =  origin
        };
        return await animalApi.CreateAnimal(request);
    }
}