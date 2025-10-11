using System;

namespace SlaughterhouseCLI.ManageProducts
{
    public class ProductActions
    {
        public void PackProduct()
        {
            Console.Write("Enter product type (e.g., half-animal, tray): ");
            string productType = Console.ReadLine() ?? string.Empty;
            if (productType == "half-animal")
            {
                Console.Write("Enter animal ID for half-animal product: ");
                string animalId = Console.ReadLine() ?? string.Empty;
                // Pack the half-animal product(I don't know if this should be done by me or by someone else  :D)
                Console.WriteLine($"Packing half-animal product for animal {animalId}.");
            }
            else if (productType == "tray")
            {
                Console.Write("Enter tray ID to pack: ");
                string trayId = Console.ReadLine() ?? string.Empty;
                // Pack the tray(I don't know if this should be done by me or by someone else  :D)
                Console.WriteLine($"Packing tray {trayId} for distribution.");
            }
            else
            {
                Console.WriteLine("Unknown product type.");
            }
        }
    }
}
