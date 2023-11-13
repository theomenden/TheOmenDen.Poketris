using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Games;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public sealed record Gen5
{
    [JsonConstructor]
    public Gen5(
        BlackWhite blackWhite
    )
    {
        BlackWhite = blackWhite;
    }

    [JsonPropertyName("black-white")]
    public BlackWhite BlackWhite { get; }
}