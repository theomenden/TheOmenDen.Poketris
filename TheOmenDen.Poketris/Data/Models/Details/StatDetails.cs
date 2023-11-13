using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Details;

public sealed record StatDetails
{
    [JsonConstructor]
    public StatDetails(
        string name,
        string url
    )
    {
        Name = name;
        Url = url;
    }

    [JsonPropertyName("name")]
    public string Name { get; }

    [JsonPropertyName("url")]
    public string Url { get; }
}