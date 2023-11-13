using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record Emerald
{
    [JsonConstructor]
    public Emerald(
        string frontDefault,
        string frontShiny
    )
    {
        FrontDefault = frontDefault;
        FrontShiny = frontShiny;
    }

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; } = String.Empty;
}