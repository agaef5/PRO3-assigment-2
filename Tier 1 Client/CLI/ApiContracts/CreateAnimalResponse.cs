using System;

namespace WebApi.ApiContracts;

public class CreateAnimalResponse
{
     public int AnimalId { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Origin { get; set; } = string.Empty;
}
