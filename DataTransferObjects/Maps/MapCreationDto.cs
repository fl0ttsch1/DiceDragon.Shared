using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public class MapCreationDto
{
    public int CampaignId { get; set; }
    public required string Name { get; set; }
    public RectangleF? ViewBox { get; set; }
}