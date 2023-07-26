using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects;

public class RollCreationDto
{
    public required string CharacterId { get; set; }
    public bool IsPrivate { get; set; }

    public required string Action { get; set; } // e.g. AbilityScore
    public required string Key { get; set; }    // e.g. Strength
    public RollModifier Modifier { get; set; }
}