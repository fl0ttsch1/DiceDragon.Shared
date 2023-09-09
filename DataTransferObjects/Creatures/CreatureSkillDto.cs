using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureSkillDto
{
    public int SkillId { get; set; }
    public required string SkillName { get; set; }
    public required ProficiencyType Proficiency { get; set; }
    public int Modifier { get; set; }

    public int AbilityId { get; set; }
    public required string AbilityName { get; set; }
    public required string AbilityAbbreviation { get; set; }
}