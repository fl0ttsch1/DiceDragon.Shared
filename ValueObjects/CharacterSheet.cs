using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.ValueObjects;

public class CharacterSheet
{
    // TODO spells
    // TODO inventory (weapons!)

    public required string Race { get; set; }
    public Size Size { get; set; }

    public required string Classes { get; set; }
    public int ProficiencyBonus { get; set; }

    public int MovementSpeed { get; set; }  // TODO consider flying speed?
    public int ArmorClass { get; set; }
    public int Initiative { get; set; }

    public required HitPoints HitPoints { get; set; }
    public required List<string> Conditions { get; set; }

    public required List<AbilityScore> AbilityScores { get; set; }
}