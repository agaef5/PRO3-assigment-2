using System.Net.Http.Json;
using CLI.ApiContracts;

namespace CLI.APIs.Animal;

public class AnimalApi(HttpClient client) : IAnimalApi
{
    public async Task<CreateAnimalResponse> CreateAnimal(CreateAnimalRequest request, CancellationToken ct = default)
    {
        using var response =
            await client.PostAsJsonAsync("slaughterhouse/animal", request, ct);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<CreateAnimalResponse>(
                cancellationToken: ct);
        }

        throw new HttpRequestException($"CreateAnimal failed: {(int)response.StatusCode}");
    }
}