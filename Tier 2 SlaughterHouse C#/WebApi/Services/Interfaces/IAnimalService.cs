using SharedHTTPs.AnimalContracts;

namespace WebApi.Services.Interfaces;

public interface IAnimalService{
    
        Task<AnimalHttpResponse?> CreateAnimalAsync(CreateAnimalHttpRequest request);
        Task<List<AnimalHttpResponse>> GetAllAnimalsAsync();
        Task<AnimalHttpResponse?> GetAnimalByIdAsync(long id);
}