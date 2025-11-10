namespace SharedHTTPs.AnimalContracts;

public class AnimalHttpResponse
{
    public long AnimalId { get; set; }
    public string? RegistrationNumber { get; set; }
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDateUtc { get; set; }
    public string? Farm { get; set; }
}

