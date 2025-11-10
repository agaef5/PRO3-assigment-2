namespace SharedHTTPs.AnimalContracts;

public record CreateAnimalRequest
{
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; }
}
