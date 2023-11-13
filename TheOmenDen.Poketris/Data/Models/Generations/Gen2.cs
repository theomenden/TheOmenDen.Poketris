using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Games;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public sealed record Gen2
{
    [JsonConstructor]
    public Gen2(
        Crystal crystal,
        Gold gold,
        Silver silver
    )
    {
        Crystal = crystal;
        Gold = gold;
        Silver = silver;
    }

    [JsonPropertyName("crystal")]
    public Crystal Crystal { get; }

    [JsonPropertyName("gold")]
    public Gold Gold { get; }

    [JsonPropertyName("silver")]
    public Silver Silver { get; }
}