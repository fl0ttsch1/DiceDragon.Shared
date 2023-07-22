namespace DiceDragon.Shared.DataTransferObjects;

public record CampaignCharacterDto(
    string Id,
    string Name,
    string PlayerId,
    bool IsActive);