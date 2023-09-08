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
    public bool? IsDisabled { get; set; }

    public bool? CanMove { get; set; }
    public int? MovementSpeed { get; set; }
    public int? ProficiencyBonus { get; set; }
    public int? InitiativeBonus { get; set; }
    
    public bool? IsDead { get; set; }
    public int? ArmorClass { get; set; }
    public int? HitPointsCurrent { get; set; }
    public int? HitPointsTemporary { get; set; }
    public int? HitPointsTotal { get; set; }

    public List<Condition>? Conditions { get; set; }
    public List<Condition>? ConditionsAdded { get; set; }
    public List<Condition>? ConditionsRemoved { get; set; }
}
