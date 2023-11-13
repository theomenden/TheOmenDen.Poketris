using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Details;

public sealed record MoveDetail
{
    [JsonConstructor]
    public MoveDetail(
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