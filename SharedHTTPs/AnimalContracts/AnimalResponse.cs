namespace SharedHTTPs.AnimalContracts;

public class AnimalResponse
{
    public long AnimalId { get; set; }
    public string RegistrationNumber { get; set; }
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; }
}