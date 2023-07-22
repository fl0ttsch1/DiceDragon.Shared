using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects;

public record RollCreationDto(
    string CharacterId,
    string Name,
    int Index,
    RollType? Type = null);