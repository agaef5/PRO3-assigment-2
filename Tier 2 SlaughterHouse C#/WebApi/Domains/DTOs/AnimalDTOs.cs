namespace WebApi.Domains.DTOs;

// Used for HTTP responses
public record AnimalDto(
    long AnimalId,
    string RegistrationNumber,
    double AnimalWeight,
    DateTime ArrivalDate,
    string Farm);

public record CreateAnimalDto(
    double AnimalWeight,
    DateTime ArrivalDate,
    string Farm);
    