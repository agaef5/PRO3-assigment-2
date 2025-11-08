using System;

namespace WebApi.ApiContracts;

public class CreateAnimalRequest (DateTime date, string regNo, double weight, string origin)
{
    public string RegistrationNumber { get; set; } = string.Empty;
    public double AnimalWeight { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Origin { get; set; } = string.Empty;
}
