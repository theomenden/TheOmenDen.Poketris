using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Misc;

public sealed record Other
{
    [JsonConstructor]
    public Other(
        DreamWorld dreamWorld,
        Home home,
        OfficialArtwork officialArtwork
    )
    {
        DreamWorld = dreamWorld;
        Home = home;
        OfficialArtwork = officialArtwork;
    }

    [JsonPropertyName("dream_world")]
    public DreamWorld DreamWorld { get; }

    [JsonPropertyName("home")]
    public Home Home { get; }

    [JsonPropertyName("official-artwork")]
    public OfficialArtwork OfficialArtwork { get; }
}