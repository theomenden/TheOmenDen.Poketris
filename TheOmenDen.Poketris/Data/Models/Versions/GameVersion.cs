using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Versions;

public sealed record GameVersion
{
    [JsonConstructor]
    public GameVersion(
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