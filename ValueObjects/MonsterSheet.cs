namespace DiceDragon.Shared.ValueObjects;

public class MonsterSheet
{
    // TODO size
    // TODO saving throws
    // TODO skills

    public int MovementSpeed { get; set; }
    public int ArmorClass { get; set; }
    public int Initiative { get; set; }

    public required HitPoints HitPoints { get; set; }
}