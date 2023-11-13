using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Details;

namespace TheOmenDen.Poketris.Data.Models.Versions;

public sealed record VersionGroupDetail
{
    [JsonConstructor]
    public VersionGroupDetail(
        int levelLearnedAt,
        MoveLearnMethod moveLearnMethod,
        VersionGroup versionGroup
    )
    {
        LevelLearnedAt = levelLearnedAt;
        MoveLearnMethod = moveLearnMethod;
        VersionGroup = versionGroup;
    }

    [JsonPropertyName("level_learned_at")]
    public int LevelLearnedAt { get; }

    [JsonPropertyName("move_learn_method")]
    public MoveLearnMethod MoveLearnMethod { get; }

    [JsonPropertyName("version_group")]
    public VersionGroup VersionGroup { get; }
}