using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Games;
using TheOmenDen.Poketris.Data.Models.Misc;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public sealed record Gen7
{
    [JsonConstructor]
    public Gen7(
        Icons icons,
        UltraSunUltraMoon ultraSunUltraMoon
    )
    {
        Icons = icons;
        UltraSunUltraMoon = ultraSunUltraMoon;
    }

    [JsonPropertyName("icons")]
    public Icons Icons { get; }

    [JsonPropertyName("ultra-sun-ultra-moon")]
    public UltraSunUltraMoon UltraSunUltraMoon { get; }
}