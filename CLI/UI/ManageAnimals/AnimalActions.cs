using System;
using SlaughterHouse.Services;

namespace SlaughterhouseCLI.ManageAnimals
{
    public class AnimalActions(AnimalClient client)
    {
        public async Task RegisterAnimal()
        {
            Console.Write("Enter animal ID: ");
            string animalId = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter animal weight (kg): ");
            double weight = double.Parse(Console.ReadLine() ?? string.Empty);

            try
            {
                var response =
                    await client.AddAnimalAsync(Convert.ToInt32(animalId), weight,
                        DateTime.Now);
                Console.WriteLine($"Animal with ID {response.Animal.AnimalId} has been registered. Reg. number: {response.Animal.RegistrationNumber}");
            }
            catch (Grpc.Core.RpcException ex)
            {
                Console.WriteLine($"gRPC error: {ex.StatusCode} - {ex.Status.Detail}");
            }


        }
    }
}
