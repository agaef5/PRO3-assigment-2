namespace WebApi.Domains.DTOs;

// Used for HTTP responses
public record AnimalDto(
    int AnimalId,
    string RegistrationNumber,
    double AnimalWeight,
    DateTime ArrivalDate,
    string Origination);

public record CreateAnimalDto(
    string RegistrationNumber,
    double AnimalWeight,
    DateTime ArrivalDate,
    string Origination);
    