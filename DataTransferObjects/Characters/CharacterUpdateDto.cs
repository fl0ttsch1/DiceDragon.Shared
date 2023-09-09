using DiceDragon.Shared.DataTransferObjects.Creatures;

namespace DiceDragon.Shared.DataTransferObjects.Characters;

public class CharacterUpdateDto : CreatureUpdateDto
{
    public string? Race { get; set; }
    public string? Classes { get; set; }
}