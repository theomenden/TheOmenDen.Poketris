using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Details;

public sealed record TypeGeneral
{
    [JsonConstructor]
    public TypeGeneral(
        int slot,
        TypeDetails type
    )
    {
        Slot = slot;
        TypeDetails = type;
    }

    [JsonPropertyName("slot")]
    public int Slot { get; }

    [JsonPropertyName("type")]
    public TypeDetails TypeDetails { get; }
}