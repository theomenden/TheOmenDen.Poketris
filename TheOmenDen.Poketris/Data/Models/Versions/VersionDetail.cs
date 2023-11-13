using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Versions;

public sealed record VersionDetail
{
    [JsonConstructor]
    public VersionDetail(
        int rarity,
        GameVersion version
    )
    {
        Rarity = rarity;
        Version = version;
    }

    [JsonPropertyName("rarity")]
    public int Rarity { get; }

    [JsonPropertyName("version")]
    public GameVersion Version { get; }
}