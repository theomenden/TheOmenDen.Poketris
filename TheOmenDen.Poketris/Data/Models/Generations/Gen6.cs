using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Games;

namespace TheOmenDen.Poketris.Data.Models.Generations;

public sealed record Gen6
{
    [JsonConstructor]
    public Gen6(
        OmegaRubyAlphaSapphire omegaRubyAlphaSapphire,
        Xy xy
    )
    {
        OmegaRubyAlphaSapphire = omegaRubyAlphaSapphire;
        XY = xy;
    }

    [JsonPropertyName("omegaruby-alphasapphire")]
    public OmegaRubyAlphaSapphire OmegaRubyAlphaSapphire { get; }

    [JsonPropertyName("x-y")]
    public Xy XY { get; }
}