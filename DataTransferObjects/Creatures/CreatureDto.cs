using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureDto : IEquatable<CreatureDto>
{
    // TODO list of abilities?
    
    public int Id { get; init; }
    public int? CampaignId { get; set; }
    public string? PlayerId { get; set; }

    public required string Name { get; set; }
    public bool IsDisabled { get; set; }

    public bool CanMove { get; set; }
    public int MovementSpeed { get; set; }
    public int ProficiencyBonus { get; set; }
    public int InitiativeBonus { get; set; }

    public bool IsDead { get; set; }
    public int ArmorClass { get; set; }
    public int CurrentHitPoints { get; set; }
    public int TemporaryHitPoints { get; set; }
    public int TotalHitPoints { get; set; }
    public required List<Condition> Conditions { get; set; }

    public int ThumbnailId { get; set; }
    public required string ThumbnailUrl { get; set; }

    public SizeType SizeType { get; set; }
    public int? PositionMapId { get; set; }
    public int? PositionX { get; set; }
    public int? PositionY { get; set; }

    public bool Equals(CreatureDto? other)
    {
        return Id == other?.Id;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as CreatureDto);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}