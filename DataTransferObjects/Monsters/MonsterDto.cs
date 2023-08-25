using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Monsters;
public class MonsterDto
{
    // TODO senses?

    public int Id { get; set; }
    public required string Name { get; set; }

    public int MovementSpeed { get; set; }
    public int ArmorClass { get; set; }
    public required HitPoints HitPoints { get; set; }

    public MapPosition? Position { get; set; }
}