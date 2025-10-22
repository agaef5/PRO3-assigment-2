using System;
using SlaughterHouse.Services;

namespace SlaughterhouseCLI.ManageAnimals
{
    public class AnimalActions(AnimalClient client)
    {
        public async Task RegisterAnimal()
        {
            Console.Write("Enter animal's registration number: ");
            string regNum = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter animal weight (kg): ");
            double weight = double.Parse(Console.ReadLine() ?? string.Empty);

            try
            {
                var response =
                    await client.AddAnimalAsync(regNum, weight,
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
