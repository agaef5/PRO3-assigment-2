using System;

namespace SlaughterhouseCLI
{
    public class CliApp
    {
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
                        RegisterAnimal();
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

        private void RegisterAnimal()
        {
            var animalActions = new ManageAnimals.AnimalActions();
            animalActions.RegisterAnimal();
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
