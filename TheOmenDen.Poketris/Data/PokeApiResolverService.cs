using System.Text.Json;
using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;
using TheOmenDen.Poketris.Data.Models;

namespace TheOmenDen.Poketris.Data;

public interface IPokeApiResolverService
{
    ValueTask<IEnumerable<PokeData>> GetPokemonInfoAsync(CancellationToken cancellation = default);
    ValueTask<IEnumerable<PokemonBaseApiResult>> GetPokemonBaseDataAsync(int offset = 0, int limit = 150, CancellationToken cancellation = default);
}

internal sealed class PokeApiResolverService : IPokeApiResolverService
{
    private readonly ILogger _logger;
    private readonly IHttpClientFactory _httpClient;
    private readonly ILocalStorageService _localStorage;

    public PokeApiResolverService(ILogger logger, IHttpClientFactory httpClient, ILocalStorageService localStorage)
    {
        _logger = logger;
        _httpClient = httpClient;
        _localStorage = localStorage;
    }

    public async ValueTask<IEnumerable<PokeData>> GetPokemonInfoAsync(CancellationToken cancellation = default)
    {
        try
        {
            using var client = _httpClient.CreateClient("pokeapi");

            var response = await client.GetAsync("pokemon?limit=151", cancellation);

            response.EnsureSuccessStatusCode();

            await using var content = await response.Content.ReadAsStreamAsync(cancellation);

            var result = await JsonSerializer.DeserializeAsync<PokeData[]>(content, cancellationToken: cancellation);

            return result ?? Array.Empty<PokeData>();
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error while retrieving data from PokeAPI");
            return Array.Empty<PokeData>();
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "Error while deserializing data from PokeAPI");
            return Array.Empty<PokeData>();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected Error while retrieving data from PokeAPI");
            return Array.Empty<PokeData>();
        }
    }

    public async ValueTask<IEnumerable<PokemonBaseApiResult>> GetPokemonBaseDataAsync(int offset = 0, int limit = 150, CancellationToken cancellation = default)
    {
        try
        {
            if (await _localStorage.ContainKeyAsync("PokemonBaseData", cancellation))
            {
                return await _localStorage.GetItemAsync<PokemonBaseApiResult[]>("PokemonBaseData", cancellation)
                    .ConfigureAwait(false);
            }

            using var client = _httpClient.CreateClient("pokeapi");

            var response = await client.GetAsync($"pokemon/?{offset}&limit={limit}", cancellation).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            await using var content = await response.Content.ReadAsStreamAsync(cancellation);

            var result =
                await JsonSerializer.DeserializeAsync<PokemonBaseData[]>(content, cancellationToken: cancellation);

            var resultingData = result?.SelectMany(x => x.Results);

            await _localStorage.SetItemAsync("PokemonBaseData", resultingData, cancellation);

            return resultingData ?? Array.Empty<PokemonBaseApiResult>();
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error while retrieving data from PokeAPI");
            return Array.Empty<PokemonBaseApiResult>();
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "Error while deserializing data from PokeAPI");
            return Array.Empty<PokemonBaseApiResult>();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected Error while retrieving data from PokeAPI");
            return Array.Empty<PokemonBaseApiResult>();
        }
    }
}
