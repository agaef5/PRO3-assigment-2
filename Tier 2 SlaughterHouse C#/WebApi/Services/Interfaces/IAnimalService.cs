using SlaughterHouse.Api;
using WebApi.Domains.DTOs;

namespace WebApi.Gateways.Clients;

public interface IAnimalService{
    
        Task<AnimalResponse> AddAnimalAsync(AnimalDto dto);
        Task<AllAnimalsResponse> GetAllAnimalsAsync();
    }