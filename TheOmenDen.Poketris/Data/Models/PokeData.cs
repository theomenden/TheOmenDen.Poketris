using System.Text.Json.Serialization;
using TheOmenDen.Poketris.Data.Models.Abilities;
using TheOmenDen.Poketris.Data.Models.Details;
using TheOmenDen.Poketris.Data.Models.Games;
using TheOmenDen.Poketris.Data.Models.Misc;

namespace TheOmenDen.Poketris.Data.Models;
public sealed record PokeData
{
    [JsonConstructor]
    public PokeData(
        List<AbilityGeneral> abilities,
        int baseExperience,
        List<Form> forms,
        List<GameVersionIndex> gameIndices,
        int height,
        List<HeldItem> heldItems,
        int id,
        bool isDefault,
        string locationAreaEncounters,
        List<Move> moves,
        string name,
        int order,
        List<AbilityGeneral> pastAbilities,
        List<TypeGeneral> pastTypes,
        Species species,
        Sprites sprites,
        List<Stat> stats,
        List<TypeGeneral> types,
        int weight
    )
    {
        Abilities = abilities;
        BaseExperience = baseExperience;
        Forms = forms;
        GameIndices = gameIndices;
        Height = height;
        HeldItems = heldItems;
        Id = id;
        IsDefault = isDefault;
        LocationAreaEncounters = locationAreaEncounters;
        Moves = moves;
        Name = name;
        Order = order;
        PastAbilities = pastAbilities;
        PastTypes = pastTypes;
        Species = species;
        Sprites = sprites;
        Stats = stats;
        Types = types;
        Weight = weight;
    }

    [JsonPropertyName("abilities")]
    public IReadOnlyList<AbilityGeneral> Abilities { get; } = new List<AbilityGeneral>().AsReadOnly();

    [JsonPropertyName("base_experience")]
    public int BaseExperience { get; }

    [JsonPropertyName("forms")]
    public IReadOnlyList<Form> Forms { get; } = new List<Form>().AsReadOnly();

    [JsonPropertyName("game_indices")]
    public IReadOnlyList<GameVersionIndex> GameIndices { get; } = new List<GameVersionIndex>().AsReadOnly();

    [JsonPropertyName("height")]
    public int Height { get; }

    [JsonPropertyName("held_items")]
    public IReadOnlyList<HeldItem> HeldItems { get; } = new List<HeldItem>().AsReadOnly();

    [JsonPropertyName("id")]
    public int Id { get; }

    [JsonPropertyName("is_default")]
    public bool IsDefault { get; }

    [JsonPropertyName("location_area_encounters")]
    public string LocationAreaEncounters { get; } = String.Empty;

    [JsonPropertyName("moves")]
    public IReadOnlyList<Move> Moves { get; } = new List<Move>().AsReadOnly();

    [JsonPropertyName("name")]
    public string Name { get; } = String.Empty;

    [JsonPropertyName("order")]
    public int Order { get; }

    [JsonPropertyName("past_abilities")]
    public IReadOnlyList<AbilityGeneral> PastAbilities { get; } = new List<AbilityGeneral>().AsReadOnly();

    [JsonPropertyName("past_types")]
    public IReadOnlyList<TypeGeneral> PastTypes { get; } = new List<TypeGeneral>().AsReadOnly();

    [JsonPropertyName("species")]
    public Species Species { get; }

    [JsonPropertyName("sprites")]
    public Sprites Sprites { get; }

    [JsonPropertyName("stats")]
    public IReadOnlyList<Stat> Stats { get; } = new List<Stat>().AsReadOnly();

    [JsonPropertyName("types")]
    public IReadOnlyList<TypeGeneral> Types { get; } = new List<TypeGeneral>().AsReadOnly();

    [JsonPropertyName("weight")]
    public int Weight { get; }
}