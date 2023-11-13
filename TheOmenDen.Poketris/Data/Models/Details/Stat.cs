using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Details;

public sealed record Stat
{
    [JsonConstructor]
    public Stat(
        int baseStat,
        int effort,
        StatDetails stat
    )
    {
        BaseStat = baseStat;
        Effort = effort;
        StatDetail = stat;
    }

    [JsonPropertyName("base_stat")]
    public int BaseStat { get; }

    [JsonPropertyName("effort")]
    public int Effort { get; }

    [JsonPropertyName("stat")]
    public StatDetails StatDetail { get; }
}