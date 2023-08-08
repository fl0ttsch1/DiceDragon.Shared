namespace DiceDragon.Shared.DataTransferObjects;

public record CampaignUpdateCharacterDto(
    string Id,
    string Name,
    string PlayerId,
    bool IsActive);