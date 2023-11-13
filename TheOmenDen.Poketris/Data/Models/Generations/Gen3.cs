using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Games;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public record Gen3
{
    [JsonConstructor]
    public Gen3(
        Emerald emerald,
        FireRedLeafGreen fireRedLeafGreen,
        RubySapphire rubySapphire
    )
    {
        Emerald = emerald;
        FireRedLeafGreen = fireRedLeafGreen;
        RubySapphire = rubySapphire;
    }

    [JsonPropertyName("emerald")]
    public Emerald Emerald { get; }

    [JsonPropertyName("firered-leafgreen")]
    public FireRedLeafGreen FireRedLeafGreen { get; }

    [JsonPropertyName("ruby-sapphire")]
    public RubySapphire RubySapphire { get; }
}