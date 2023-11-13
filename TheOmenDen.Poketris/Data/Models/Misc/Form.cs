using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Misc;

public sealed record Form
{
    [JsonConstructor]
    public Form(
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