using System.Text.Json.Serialization;

namespace TheOmenDen.Poketris.Data.Models.Games;

public sealed record RedBlue
{
    [JsonConstructor]
    public RedBlue(
        string backDefault,
        string backGray,
        string backTransparent,
        string frontDefault,
        string frontGray,
        string frontTransparent
    )
    {
        BackDefault = backDefault;
        BackGray = backGray;
        BackTransparent = backTransparent;
        FrontDefault = frontDefault;
        FrontGray = frontGray;
        FrontTransparent = frontTransparent;
    }

    [JsonPropertyName("back_default")]
    public string BackDefault { get; } = String.Empty;

    [JsonPropertyName("back_gray")]
    public string BackGray { get; } = String.Empty;

    [JsonPropertyName("back_transparent")]
    public string BackTransparent { get; } = String.Empty;

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; } = String.Empty;

    [JsonPropertyName("front_gray")]
    public string FrontGray { get; } = String.Empty;

    [JsonPropertyName("front_transparent")]
    public string FrontTransparent { get; } = String.Empty;
}