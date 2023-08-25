namespace DiceDragon.Shared.DataTransferObjects.Characters;

public record CharacterPlacementDto(
    int X,
    int Y,
    int? MapId = null);