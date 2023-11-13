using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Misc;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public record Gen8
{
    [JsonConstructor]
    public Gen8(
        Icons icons
    )
    {
        Icons = icons;
    }

    [JsonPropertyName("icons")]
    public Icons Icons { get; }
}