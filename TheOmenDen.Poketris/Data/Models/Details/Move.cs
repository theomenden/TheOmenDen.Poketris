using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Versions;

namespace TheOmenDen.Poketris.Data.Models.Details;

public sealed record Move
{
    [JsonConstructor]
    public Move(
        MoveDetail move,
        List<VersionGroupDetail> versionGroupDetails
    )
    {
        MoveDetail = move;
        VersionGroupDetails = versionGroupDetails;
    }

    [JsonPropertyName("move")]
    public MoveDetail MoveDetail { get; }

    [JsonPropertyName("version_group_details")]
    public IReadOnlyList<VersionGroupDetail> VersionGroupDetails { get; } = new List<VersionGroupDetail>().AsReadOnly();
}