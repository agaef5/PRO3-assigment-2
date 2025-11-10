namespace WebApi.Domains.DTOs;

// Used for HTTP responses
public record AnimalDTO
{
    public long AnimalId { get; set; }
    public string RegistrationNumber { get; set; }

    public double AnimalWeight { get; set; }

    public DateTime ArrivalDate { get; set; }
    public string Farm { get; set; }
}
