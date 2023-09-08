namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public record CreaturePlacementDto : CreatureMovementDto
{
    public int? MapId { get; set; }
}