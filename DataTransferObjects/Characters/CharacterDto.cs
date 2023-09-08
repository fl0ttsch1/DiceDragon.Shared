using DiceDragon.Shared.DataTransferObjects.Creatures;

namespace DiceDragon.Shared.DataTransferObjects.Characters;

public class CharacterDto : CreatureDto
{
    public required string Race { get; set; }
    public required string Classes { get; set; }

    public required List<AbilityDto> Abilities { get; set; }
    public required List<SkillDto> Skills { get; set; }
}