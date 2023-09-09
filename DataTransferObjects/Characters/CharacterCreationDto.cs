using DiceDragon.Shared.DataTransferObjects.Creatures;

namespace DiceDragon.Shared.DataTransferObjects.Characters;

public class CharacterCreationDto : CreatureCreationDto
{
    public required string Race { get; set; }
    public required string Classes { get; set; }
}