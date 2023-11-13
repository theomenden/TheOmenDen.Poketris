using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Abilities;

public sealed record AbilityDetail
{
    [JsonConstructor]
    public AbilityDetail(
        string name,
        string url
    )
    {
        Name = name;
        Url = url;
    }

    [JsonPropertyName("name")]
    public string Name { get; } = String.Empty;

    [JsonPropertyName("url")]
    public string Url { get; } = String.Empty;
}
