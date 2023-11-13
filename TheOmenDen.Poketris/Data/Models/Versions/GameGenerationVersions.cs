using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Generations;

namespace TheOmenDen.Poketris.Data.Models.Versions;

public sealed record GameGenerationVersions
{
    [JsonConstructor]
    public GameGenerationVersions(
        Gen1 generationI,
        Gen2 generationIi,
        Gen3 generationIii,
        Gen4 generationIv,
        Gen5 generationV,
        Gen6 generationVi,
        Gen7 generationVii,
        Gen8 generationViii
    )
    {
        GenerationI = generationI;
        GenerationIi = generationIi;
        GenerationIii = generationIii;
        GenerationIv = generationIv;
        GenerationV = generationV;
        GenerationVi = generationVi;
        GenerationVii = generationVii;
        GenerationViii = generationViii;
    }

    [JsonPropertyName("generation-i")]
    public Gen1 GenerationI { get; }

    [JsonPropertyName("generation-ii")]
    public Gen2 GenerationIi { get; }

    [JsonPropertyName("generation-iii")]
    public Gen3 GenerationIii { get; }

    [JsonPropertyName("generation-iv")]
    public Gen4 GenerationIv { get; }

    [JsonPropertyName("generation-v")]
    public Gen5 GenerationV { get; }

    [JsonPropertyName("generation-vi")]
    public Gen6 GenerationVi { get; }

    [JsonPropertyName("generation-vii")]
    public Gen7 GenerationVii { get; }

    [JsonPropertyName("generation-viii")]
    public Gen8 GenerationViii { get; }
}