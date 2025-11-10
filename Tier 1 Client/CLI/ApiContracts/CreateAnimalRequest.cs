using System;

namespace CLI.ApiContracts;

public class CreateAnimalRequest (DateTime ArrivalDate, string RegistrationNumber, double AnimalWeight, string Farm)
{
    public string RegistrationNumber { get; set; } = string.Empty;
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; } = string.Empty;
}
