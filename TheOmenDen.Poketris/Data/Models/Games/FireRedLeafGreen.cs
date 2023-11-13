using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record FireRedLeafGreen
{
    [JsonConstructor]
    public FireRedLeafGreen(
        string backDefault,
        string backShiny,
        string frontDefault,
        string frontShiny
    )
    {
        BackDefault = backDefault;
        BackShiny = backShiny;
        FrontDefault = frontDefault;
        FrontShiny = frontShiny;
    }

    [JsonPropertyName("back_default")]
    public string BackDefault { get; } = String.Empty;

    [JsonPropertyName("back_shiny")]
    public string BackShiny { get; } = String.Empty;

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; } = String.Empty;
}