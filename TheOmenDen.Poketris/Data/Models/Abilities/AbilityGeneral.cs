using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Abilities;

public sealed record AbilityGeneral
{
    [JsonConstructor]
    public AbilityGeneral(
        AbilityDetail ability,
        bool isHidden,
        int slot
    )
    {
        Ability = ability;
        IsHidden = isHidden;
        Slot = slot;
    }

    [JsonPropertyName("ability")]
    public AbilityDetail Ability { get; }

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; }

    [JsonPropertyName("slot")]
    public int Slot { get; }
}