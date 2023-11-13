using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Versions;

namespace TheOmenDen.Poketris.Data.Models.Details;

public sealed record HeldItem
{
    [JsonConstructor]
    public HeldItem(
        Item item,
        List<VersionDetail> versionDetails
    )
    {
        Item = item;
        VersionDetails = versionDetails;
    }

    [JsonPropertyName("item")]
    public Item Item { get; }

    [JsonPropertyName("version_details")]
    public IReadOnlyList<VersionDetail> VersionDetails { get; }
}