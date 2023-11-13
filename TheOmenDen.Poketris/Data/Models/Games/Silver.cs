using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record Silver
{
    [JsonConstructor]
    public Silver(
        string backDefault,
        string backShiny,
        string frontDefault,
        string frontShiny,
        string frontTransparent
    )
    {
        BackDefault = backDefault;
        BackShiny = backShiny;
        FrontDefault = frontDefault;
        FrontShiny = frontShiny;
        FrontTransparent = frontTransparent;
    }

    [JsonPropertyName("back_default")]
    public string BackDefault { get; } = String.Empty;

    [JsonPropertyName("back_shiny")]
    public string BackShiny { get; } = String.Empty;

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; } = String.Empty;

    [JsonPropertyName("front_transparent")]
    public string FrontTransparent { get; } = String.Empty;
}