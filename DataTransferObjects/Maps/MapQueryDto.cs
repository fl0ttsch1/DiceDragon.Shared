namespace DiceDragon.Shared.DataTransferObjects.Maps;

public record MapQueryDto
{
    public int? CampaignId { get; set; }
    public bool? IsActive { get; set; }
}