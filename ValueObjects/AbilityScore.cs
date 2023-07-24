namespace DiceDragon.Shared.ValueObjects;

public class AbilityScore
{
    public required string Abbreviation { get; set; }
    public required string Name { get; set; }
    public int Value { get; set; }
    public int Modifier { get; set; }

    public SavingThrow SavingThrow { get; set; }
    public List<Skill> Skills { get; set; }
}