using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Versions;

public sealed record VersionGroup
{
    [JsonConstructor]
    public VersionGroup(
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