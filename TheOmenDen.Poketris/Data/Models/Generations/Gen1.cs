using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Games;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public sealed record Gen1
{
    [JsonConstructor]
    public Gen1(
        RedBlue redBlue,
        Yellow yellow
    )
    {
        RedBlue = redBlue;
        Yellow = yellow;
    }

    [JsonPropertyName("red-blue")]
    public RedBlue RedBlue { get; }

    [JsonPropertyName("yellow")]
    public Yellow Yellow { get; }
}
