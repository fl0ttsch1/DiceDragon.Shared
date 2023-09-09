namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureQueryDto
{
    public int? CampaignId { get; set; }
    public int? MapId { get; set; }
    public string? PlayerId { get; set; }
}