using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record Platinum
{
    [JsonConstructor]
    public Platinum(
        string backDefault,
        string backFemale,
        string backShiny,
        string backShinyFemale,
        string frontDefault,
        string frontFemale,
        string frontShiny,
        string frontShinyFemale
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
}