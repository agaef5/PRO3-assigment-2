using System;
using SlaughterHouse.Gateways;
using SlaughterHouse.Services;
using SlaughterhouseCLI.ManageAnimals;

namespace SlaughterhouseCLI
{
    public class CliApp
    {
        private readonly SlaughterHouseGateway _gateway;
        private readonly AnimalClient _animalClient;

        private readonly AnimalActions _animalActions;

        public CliApp()
        {
            _gateway = new SlaughterHouseGateway();
            _animalClient = new AnimalClient(_gateway.Client);

            _animalActions = new AnimalActions(_animalClient);
        }
        
        public void Start()
        {
            bool running = true;
            
            while (running)
            {
                Console.WriteLine("Welcome to the Slaughterhouse CLI!");
                Console.WriteLine("1. Register Animal");
                Console.WriteLine("2. Cut Animal into Parts");
                Console.WriteLine("3. Pack Product");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RegisterAnimalAsync().GetAwaiter().GetResult();
                        break;
                    case "2":
                        CutAnimal();
                        break;
                    case "3":
                        PackProduct();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private async Task RegisterAnimalAsync()
        {
            await _animalActions.RegisterAnimal();
        }

        private void CutAnimal()
        {
            var partActions = new ManageParts.PartActions();
            partActions.CutAnimal();
        }

        private void PackProduct()
        {
            var productActions = new ManageProducts.ProductActions();
            productActions.PackProduct();
        }
    }
}
