using SharedHTTPs.AnimalContracts;

namespace WebApi.Services.Interfaces;

public interface IAnimalService{
    
        Task<AnimalHttpResponse> CreateAnimalAsync(CreateAnimalHttpRequest dto);
        Task<List<AnimalHttpResponse>> GetAllAnimalsAsync();
        Task<AnimalHttpResponse> GetAnimalByIdAsync(int id);
}