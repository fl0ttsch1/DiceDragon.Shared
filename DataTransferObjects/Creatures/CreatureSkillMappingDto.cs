using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureSkillMappingDto
{
    public int SkillId { get; set; }
    public ProficiencyType Proficiency { get; set; }
    public int? Modifier { get; set; }
}