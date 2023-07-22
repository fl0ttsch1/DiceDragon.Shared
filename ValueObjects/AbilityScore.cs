using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.ValueObjects;

public class AbilityScore
{
    public Ability Ability { get; set; }
    public int Score { get; set; }

    public SavingThrow SavingThrow { get; set; }
    public List<Skill> Skills { get; set; }
}