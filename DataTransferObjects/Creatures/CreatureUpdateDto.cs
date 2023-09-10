using DiceDragon.Shared.Enums;
using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public abstract class CreatureUpdateDto
{
    public int? CampaignId { get; set; }
    public string? PlayerId { get; set; }
    public int? ThumbnailId { get; set; }
    public string? ThumbailUrl { get; set; }

    public string? Name { get; set; }
    public SizeType? Size { get; set; }
    
    public bool? IsLocked { get; set; }
    public int? MovementSpeed { get; set; }
    public int? ProficiencyBonus { get; set; }
    public int? InitiativeBonus { get; set; }

    public bool? IsDead { get; set; }
    public int? ArmorClass { get; set; }
    public List<Condition>? Conditions { get; set; }
    
    public int? CurrentHitPoints { get; set; }
    public int? TemporaryHitPoints { get; set; }
    public int? TotalHitPoints { get; set; }
    
    public int? PositionMapId { get; set; }
    public int? PositionX { get; set; }
    public int? PositionY { get; set; }
    
    public List<CreatureAbilityMappingDto>? Abilities { get; set; }
    public List<CreatureSkillMappingDto>? Skills { get; set; }
}