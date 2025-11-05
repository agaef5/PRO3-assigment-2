using System;

namespace SlaughterhouseCLI.ManageParts
{
    public class PartActions
    {
        public void CutAnimal()
        {
            Console.Write("Enter animal ID to cut: ");
            string animalId = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter part ID: ");
            string partId = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter part type: ");
            string partType = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter part weight (kg): ");
            double weight = double.Parse(Console.ReadLine() ?? string.Empty);
            // Store the part details (I don't know if this should be done by me or by someone else  :D)
            Console.WriteLine($"Part {partType} with ID {partId} has been cut from animal {animalId}.");
        }
    }
}
