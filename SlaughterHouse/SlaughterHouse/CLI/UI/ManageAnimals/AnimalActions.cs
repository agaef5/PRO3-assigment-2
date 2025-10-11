using System;

namespace SlaughterhouseCLI.ManageAnimals
{
    public class AnimalActions
    {
        public void RegisterAnimal()
        {
            Console.Write("Enter animal ID: ");
            string animalId = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter animal name: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter animal weight (kg): ");
            double weight = double.Parse(Console.ReadLine() ?? string.Empty);
            // Store the animal data (I don't know if this should be done by me or by someone else  :D)
            Console.WriteLine($"Animal {name} with ID {animalId} has been registered.");
        }
    }
}
