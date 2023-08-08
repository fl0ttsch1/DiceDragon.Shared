namespace DiceDragon.Shared.DataTransferObjects;

public record CampaignDto(
    string Id,
    string Name, 
    List<CampaignUpdateCharacterDto> Characters);