using System.Text.Json.Serialization;
using DiceDragon.Shared.DataTransferObjects.Characters;
using DiceDragon.Shared.DataTransferObjects.Monsters;
using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

[JsonPolymorphic(TypeDiscriminatorPropertyName = nameof(Type))]
[JsonDerivedType(typeof(CharacterDto), (int)CreatureType.Character)]
[JsonDerivedType(typeof(MonsterDto), (int)CreatureType.Monster)]
public abstract class CreatureDto : IEquatable<CreatureDto>
{
    public CreatureType Type { get; init; }
    public int Id { get; init; }
    
    public int? CampaignId { get; set; }
    public string? CampaignName { get; set; }
    
    public string? PlayerId { get; set; }
    public string? PlayerName { get; set; }
    
    public int ThumbnailId { get; set; }
    public required string ThumbnailUrl { get; set; }

    // basics
    public required string Name { get; set; }
    public SizeType SizeType { get; set; }
    public int ProficiencyBonus { get; set; }
    public int InitiativeBonus { get; set; }
    public int ArmorClass { get; set; }
    
    // health
    public bool IsDead { get; set; }
    public int CurrentHitPoints { get; set; }
    public int TemporaryHitPoints { get; set; }
    public int TotalHitPoints { get; set; }
    public required List<Condition> Conditions { get; set; }

    // position
    public int? PositionMapId { get; set; }
    public int? PositionX { get; set; }
    public int? PositionY { get; set; }
    
    // movement
    public bool CanMove { get; set; }
    public int MovementSpeed { get; set; }
    
    public required List<CreatureAbilityDto> Abilities { get; set; }
    public required List<CreatureSkillDto> Skills { get; set; }

    public bool Equals(CreatureDto? other) => Id == other?.Id;
    public override bool Equals(object? obj) => Equals(obj as CreatureDto);
    public override int GetHashCode() => Id.GetHashCode();
}
