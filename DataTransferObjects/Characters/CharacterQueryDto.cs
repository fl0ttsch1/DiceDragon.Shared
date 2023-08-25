namespace DiceDragon.Shared.DataTransferObjects.Characters;

public record CharacterQueryDto
{
    public int? CampaignId { get; set; }
    public int? MapId { get; set; }
    public string? PlayerId { get; set; }
}