using System.Net.Http.Json;

namespace WebAPI.ApiContracts;

public class AnimalApi(HttpClient client) : IAnimalApi
{
    public async Task<CreateAnimalResponse> CreateQuest(CreateAnimalRequest request, CancellationToken ct = default)
    {
        using var response =
            await client.PostAsJsonAsync("api/quests", request, ct);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<CreateAnimalResponse>(
                cancellationToken: ct);
        }

        throw new HttpRequestException($"CreateQuest failed: {(int)response.StatusCode}");
    }
}