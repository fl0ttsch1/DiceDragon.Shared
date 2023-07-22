using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterSheetDto
{
    public string Race { get; set; }
    public string Classes { get; set; }
    public int Proficiency { get; set; }

    public int Speed { get; set; }
    public int Initiative { get; set; }
    public int ArmorClass { get; set; }
    public HitPoints HitPoints { get; set; }

    public List<AbilityScoreDto> AbilityScores { get; set; }
}