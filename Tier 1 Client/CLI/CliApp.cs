using CLI.ApiContracts;
using CLI.APIs.Animal;
using CLI.Views;
using CLI.ViewModels;

namespace CLI;

public class CliApp
{
    
    private static readonly HttpClient Client =new HttpClient
    {
        BaseAddress = new Uri("http://localhost:5268")
    };
    
    private static readonly IAnimalApi AnimalApi = new AnimalApi(Client);
    private static readonly AnimalVM AnimalVm = new(AnimalApi);
    private static readonly AnimalView AnimalView = new(AnimalVm);

    public void Start()
    {
        GetClient().GetAwaiter().GetResult();
        
        while (true)
        {
            Console.WriteLine("Welcome to PRO3 Slaughter House!");
            Console.WriteLine("1. Create animal");
            Console.Write("Choose an option and press Enter: ");
            
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AnimalView.CreateAnimal().GetAwaiter().GetResult();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    
    private async Task GetClient()
    {
        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {
            using HttpResponseMessage response = await Client.GetAsync("");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }

    }
}