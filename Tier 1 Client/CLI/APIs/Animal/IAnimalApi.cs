namespace WebAPI.ApiContracts;

public interface IAnimalApi
{
    Task<CreateAnimalResponse> CreateAnimal(CreateAnimalRequest request, CancellationToken ct = default);
}