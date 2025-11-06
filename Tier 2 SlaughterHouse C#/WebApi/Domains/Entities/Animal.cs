using WebApi.Domains.DTOs;

namespace WebApi.Domains.Entities;

public class Animal(int animalId, string regNum, DateTime arrDate, double weight, string origination)
{
   public int AnimalId { get; set; } = animalId;
   public string RegistrationNumber { get; set; } = regNum;
   public DateTime ArrivalDate { get; set; } = arrDate;
   public double AnimalWeight { get; set; } = weight;
   public string Origination { get; set; } = origination;
   // public string Species {get; set;}

   public AnimalDto ToDto()
   {
      return new AnimalDto(AnimalId, RegistrationNumber, AnimalWeight,
         ArrivalDate, Origination);
   }

   public static Animal FromDto(AnimalDto dto)
   {
      return new Animal(dto.AnimalId, dto.RegistrationNumber, dto.ArrivalDate,
         dto.AnimalWeight, dto.Origination);
   }
   
}