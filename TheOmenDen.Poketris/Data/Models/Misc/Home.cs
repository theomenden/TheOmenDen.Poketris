using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Misc;

public sealed record Home
{
    [JsonConstructor]
    public Home(
        string frontDefault,
        string frontFemale,
        string frontShiny,
        string frontShinyFemale
    )
    {
        FrontDefault = frontDefault;
        FrontFemale = frontFemale;
        FrontShiny = frontShiny;
        FrontShinyFemale = frontShinyFemale;
    }

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_female")]
    public string FrontFemale { get; } = String.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; } = String.Empty;

    [JsonPropertyName("front_shiny_female")]
    public string FrontShinyFemale { get; } = String.Empty;
}