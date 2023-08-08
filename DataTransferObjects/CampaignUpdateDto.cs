namespace DiceDragon.Shared.DataTransferObjects;

public record CampaignUpdateDto(
    string Id,
    string Name, 
    List<CampaignUpdateCharacterDto> Characters);