using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Misc;

public sealed record OfficialArtwork
{
    [JsonConstructor]
    public OfficialArtwork(
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