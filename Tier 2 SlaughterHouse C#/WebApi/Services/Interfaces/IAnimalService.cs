using SlaughterHouse.Api;
using WebApi.Domains.DTOs;

namespace WebApi.Gateways.Clients;

public interface IAnimalService{
    
        Task<AnimalDto> CreateAnimalAsync(CreateAnimalDto dto);
        Task<List<AnimalDto>> GetAllAnimalsAsync();
        Task<AnimalDto> GetAnimalByIdAsync(int id);
}