namespace SharedHTTPs.AnimalContracts;

public record GetAnimalByIdRequest
{
    public long AnimalId { get; set; }
}