using CLI.ApiContracts;

namespace CLI.APIs.Animal;

public interface IAnimalApi
{
    Task<CreateAnimalResponse> CreateAnimal(CreateAnimalRequest request, CancellationToken ct = default);
}