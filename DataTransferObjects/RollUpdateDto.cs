namespace DiceDragon.Shared.DataTransferObjects;

public record RollUpdateDto(
    string Name,
    string Action,
    string Type,
    string Dice,
    int Total);