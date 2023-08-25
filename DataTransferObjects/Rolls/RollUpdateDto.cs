namespace DiceDragon.Shared.DataTransferObjects.Rolls;

public record RollUpdateDto(
    DateTime DateTime,
    int CharacterId,
    bool IsPrivate,

    string Action,
    string Type,
    string? With,
    string Notation,

    int? Total,
    string? Result);