using System;

namespace WebApi.ApiContracts;

public record CreateAnimalRequest
{
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; };
}
