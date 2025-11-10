using System;

namespace WebApi.ApiContracts;

public class CreateAnimalRequest
{
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; } = string.Empty;
}
