using System;

namespace WebApi.ApiContracts;

public class CreateAnimalResponse
{
     public long AnimalId { get; set; }
    public string RegistrationNumber { get; set; }
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; }
}
