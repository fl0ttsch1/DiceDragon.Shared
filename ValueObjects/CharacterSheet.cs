namespace DiceDragon.Shared.ValueObjects;

using Size = Enums.Size;

public class CharacterSheet
{
    // TODO spells
    // TODO inventory (weapons!)

    public string Race { get; set; }
    public Size Size { get; set; }  // TODO fetch from dndbeyond api

    public Dictionary<string, int> ClassLevels { get; set; }
    public int Proficiency { get; set; }

    public int Speed { get; set; }
    public int Initiative { get; set; }
    public int ArmorClass { get; set; }
    public HitPoints HitPoints { get; set; }

    public List<AbilityScore> AbilityScores { get; set; }
}