namespace DiceDragon.Shared.DataTransferObjects.Campaigns;

public class CampaignDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int? ActiveMapId { get; set; }
}