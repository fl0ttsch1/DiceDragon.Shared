using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects;

public class AbilityDto
{
    public int AbilityId { get; set; }
    public required string AbilityName { get; set; }
    public required string AbilityAbbreviation { get; set; }

    public int Score { get; set; }
    public int ScoreModifier { get; set; }

    public ProficiencyType SaveProficiency { get; set; }
    public int SaveModifier { get; set; }
}