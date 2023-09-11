using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureMovementDto
{
    public CreatureType CreatureType { get; set; }
    public int CreatureId { get; set; }
    public int Y { get; set; }
    public int X { get; set; }
}