namespace WebApi.Domains.Entities;

public class Animal(int animalId, string regNum, DateTime arrDate, double weight, string origination)
{
   public long AnimalId { get; set; } = animalId;
   public string RegistrationNumber { get; set; } = regNum;
   public DateTime ArrivalDate { get; set; } = arrDate;
   public double AnimalWeight { get; set; } = weight;
   public string Origination { get; set; } = origination;
   // public string Species {get; set;}
   
}