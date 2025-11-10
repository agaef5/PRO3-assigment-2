namespace SharedHTTPs.AnimalContracts;

public record CreateAnimalHttpRequest
{
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDateUtc { get; set; }
    public string? Farm { get; set; }
}

