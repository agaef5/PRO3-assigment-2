using CLI.ApiContracts;

using System.Threading.Tasks;
using CLI.ViewModels;

namespace CLI.Views;

public class AnimalView (AnimalVM animalVM)
{
    public async Task CreateAnimal()
    {
        Console.WriteLine("--- Animal Creation ---");
        
        Console.WriteLine("1/3 Introduce registration nr: ");
        var registrationNumber = Console.ReadLine();

        Console.WriteLine("2/3 Introduce weight: ");
        var animalWeight = Console.ReadLine();
        
        Console.WriteLine("3/3 Introduce farm: ");
        var farm = Console.ReadLine();

        CreateAnimalResponse response = await animalVM.CreateAnimal(DateTime.Now, registrationNumber, Convert.ToDouble(animalWeight), farm);
        
        Console.WriteLine($"Animal created successfully:\nid: {response.AnimalId},created at: {response.ArrivalDate}, \n date:{response.ArrivalDate},\n registration number: {response.RegistrationNumber} , \n weight: {response.RegistrationNumber}, \n origin: {response.Farm} ");
    }
}