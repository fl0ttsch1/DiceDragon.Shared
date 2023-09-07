using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.ValueObjects;

public class SavingThrow
{
    // TODO special modifiers e.g. advantage on CON against poison

    public int Modifier { get; set; }
    public ProficiencyType ProficiencyType { get; set; }
}