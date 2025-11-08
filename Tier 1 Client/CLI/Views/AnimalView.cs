using WebAPI.ApiContracts;
using System.Threading.Tasks;

namespace CLI.Views;

public class AnimalView (AnimalVM animalVM)
{
    public async Task CreateAnimal()
    {
        Console.WriteLine("--- Animal Creation ---");
        Console.WriteLine("1/4 Introduce date: ");
        var dateAnimal = Console.ReadLine();
        
        Console.WriteLine("3/4 Introduce registration nr: ");
        var registrationNrAnimal = Console.ReadLine();

        Console.WriteLine("2/4 Introduce weight: ");
        var weightAnimal = Console.ReadLine();
        
        Console.WriteLine("4/4 Introduce origin: ");
        var originAnimal = Console.ReadLine();

        CreateAnimalResponse response = await animalVM.CreateAnimal(dateAnimal, registrationNrAnimal, weightAnimal, originAnimal);
        
        Console.WriteLine($"Animal created successfully:\nid: {response.Id},created at: {response.CreatedAt}, \n date:{response.ArrivalDate},\n registration numnber: {response.RegistrationNumber} , \n weight: {response.RegistrationNumber}, \n origin: {response.Origin} ");
    }
}