using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Games;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public sealed record Gen4
{
    [JsonConstructor]
    public Gen4(
        DiamondPearl diamondPearl,
        HeartGoldSoulSilver heartGoldSoulSilver,
        Platinum platinum
    )
    {
        DiamondPearl = diamondPearl;
        HeartGoldSoulSilver = heartGoldSoulSilver;
        Platinum = platinum;
    }

    [JsonPropertyName("diamond-pearl")]
    public DiamondPearl DiamondPearl { get; }

    [JsonPropertyName("heartgold-soulsilver")]
    public HeartGoldSoulSilver HeartGoldSoulSilver { get; }

    [JsonPropertyName("platinum")]
    public Platinum Platinum { get; }
}