namespace DiceDragon.Shared.DataTransferObjects.Characters;

public record CharacterQueryDto
{
    public int? CampaignId { get; init; }
    public int? MapId { get; init; }
    public string? PlayerId { get; init; }
}