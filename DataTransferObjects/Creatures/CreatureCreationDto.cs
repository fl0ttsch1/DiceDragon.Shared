using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureCreationDto
{
    public int? CampaignId { get; set; }
    public string? PlayerId { get; set; }

    public required string Name { get; set; }
    public bool? IsDisabled { get; set; }

    public bool? CanMove { get; set; }
    public int MovementSpeed { get; set; }
    public int ProficiencyBonus { get; set; }
    public int InitiativeBonus { get; set; }

    public bool IsDead { get; set; }
    public int ArmorClass { get; set; }
    public int HitPointsCurrent { get; set; }
    public int HitPointsTemporary { get; set; }
    public int HitPointsTotal { get; set; }
    public List<Condition>? Conditions { get; set; }

    public int? ThumbnailId { get; set; }
    public string? ThumbnailUrl { get; set; }

    public SizeType? Size { get; set; }
    public int? PositionMapId { get; set; }
    public int? PositionX { get; set; }
    public int? PositionY { get; set; }

    public List<CreatureAbilityMappingDto>? Abilities { get; set; }
    public List<CreatureSkillMappingDto>? Skills { get; set; }
}