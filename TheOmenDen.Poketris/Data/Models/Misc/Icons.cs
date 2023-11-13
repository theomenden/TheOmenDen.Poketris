using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Misc;

public sealed record Icons
{
    [JsonConstructor]
    public Icons(
        string frontDefault,
        string frontFemale
    )
    {
        FrontDefault = frontDefault;
        FrontFemale = frontFemale;
    }

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_female")]
    public string FrontFemale { get; } = String.Empty;
}