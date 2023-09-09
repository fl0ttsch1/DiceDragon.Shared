using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureAbilityMappingDto
{
    public int AbilityId { get; set; }
    public int Score { get; set; }
    public ProficiencyType SaveProficiency { get; set; }
}