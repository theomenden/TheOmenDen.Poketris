using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Versions;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record GameVersionIndex
{
    [JsonConstructor]
    public GameVersionIndex(
        int gameIndex,
        GameVersion version
    )
    {
        GameIndex = gameIndex;
        Version = version;
    }

    [JsonPropertyName("game_index")]
    public int GameIndex { get; }

    [JsonPropertyName("version")]
    public GameVersion Version { get; }
}