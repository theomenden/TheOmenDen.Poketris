using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record Xy
{
    [JsonConstructor]
    public Xy(
        string frontDefault,
        object frontFemale,
        string frontShiny,
        object frontShinyFemale
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
    public object FrontFemale { get; } = String.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; } = String.Empty;

    [JsonPropertyName("front_shiny_female")]
    public object FrontShinyFemale { get; } = String.Empty;
}