using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record Crystal
{
    [JsonConstructor]
    public Crystal(
        string backDefault,
        string backShiny,
        string backShinyTransparent,
        string backTransparent,
        string frontDefault,
        string frontShiny,
        string frontShinyTransparent,
        string frontTransparent
    )
    {
        BackDefault = backDefault;
        BackShiny = backShiny;
        BackShinyTransparent = backShinyTransparent;
        BackTransparent = backTransparent;
        FrontDefault = frontDefault;
        FrontShiny = frontShiny;
        FrontShinyTransparent = frontShinyTransparent;
        FrontTransparent = frontTransparent;
    }

    [JsonPropertyName("back_default")]
    public string BackDefault { get; } = String.Empty;

    [JsonPropertyName("back_shiny")]
    public string BackShiny { get; } = String.Empty;

    [JsonPropertyName("back_shiny_transparent")]
    public string BackShinyTransparent { get; } = String.Empty;

    [JsonPropertyName("back_transparent")]
    public string BackTransparent { get; } = String.Empty;

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; } = String.Empty;

    [JsonPropertyName("front_shiny_transparent")]
    public string FrontShinyTransparent { get; } = String.Empty;

    [JsonPropertyName("front_transparent")]
    public string FrontTransparent { get; } = String.Empty;
}