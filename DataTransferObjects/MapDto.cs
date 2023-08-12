using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

// TODO background color/image
public class MapDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required ViewBox ViewBox { get; set; }
    public string? CampaignId { get; set; }
}