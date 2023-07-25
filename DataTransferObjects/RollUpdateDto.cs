namespace DiceDragon.Shared.DataTransferObjects;

public record RollUpdateDto(
    DateTime DateTime,
    //string CampaignId,
    string CharacterId,
    bool IsPrivate,

    string Action,
    string Type,
    string? With,
    string Notation,

    int? Total,
    string? Result);