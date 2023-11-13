using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models;

public record PokemonBaseApiResult
{
    [JsonConstructor]
    PokemonBaseApiResult(string name, string url) => (Name, Url) = (name, url);

    [JsonPropertyName("name")] public string Name { get; } = String.Empty;

    [JsonPropertyName("url")] public string Url { get; } = String.Empty;
}

public sealed record PokemonBaseData
{
    [JsonConstructor]
    PokemonBaseData(int count, string next, string previous, IReadOnlyList<PokemonBaseApiResult> results)
    {
        Count = count;
        Next = next;
        Previous = previous;
        Results = results;
    }

    [JsonPropertyName("count")]
    public int Count { get; }
    [JsonPropertyName("next")]
    public string Next { get; } = String.Empty;
    [JsonPropertyName("previous")]
    public string Previous { get; } = String.Empty;
    [JsonPropertyName("results")]
    public IReadOnlyList<PokemonBaseApiResult> Results { get; } = new List<PokemonBaseApiResult>().AsReadOnly();
}