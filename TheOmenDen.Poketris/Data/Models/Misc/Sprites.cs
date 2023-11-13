using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Versions;

namespace TheOmenDen.Poketris.Data.Models.Misc;

public sealed record Sprites
{
    [JsonConstructor]
    public Sprites(
        string backDefault,
        string backFemale,
        string backShiny,
        string backShinyFemale,
        string frontDefault,
        string frontFemale,
        string frontShiny,
        string frontShinyFemale,
        Other other,
        GameGenerationVersions versions
    )
    {
        BackDefault = backDefault;
        BackFemale = backFemale;
        BackShiny = backShiny;
        BackShinyFemale = backShinyFemale;
        FrontDefault = frontDefault;
        FrontFemale = frontFemale;
        FrontShiny = frontShiny;
        FrontShinyFemale = frontShinyFemale;
        Other = other;
        Versions = versions;
    }

    [JsonPropertyName("back_default")]
    public string BackDefault { get; } = String.Empty;

    [JsonPropertyName("back_female")]
    public string BackFemale { get; } = String.Empty;

    [JsonPropertyName("back_shiny")]
    public string BackShiny { get; } = String.Empty;

    [JsonPropertyName("back_shiny_female")]
    public string BackShinyFemale { get; } = String.Empty;

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_female")]
    public string FrontFemale { get; } = String.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; } = String.Empty;

    [JsonPropertyName("front_shiny_female")]
    public string FrontShinyFemale { get; } = String.Empty;

    [JsonPropertyName("other")]
    public Other Other { get; }

    [JsonPropertyName("versions")]
    public GameGenerationVersions Versions { get; }
}