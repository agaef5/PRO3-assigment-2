using System;

namespace CLI.ApiContracts;

public class CreateAnimalResponse
{
    public int AnimalId { get; set; }
    public string RegistrationNumber { get; set; }
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; } = string.Empty;
}
