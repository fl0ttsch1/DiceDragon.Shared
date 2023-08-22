using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects;

// TODO background color/image
public class MapDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required RectangleF ViewBox { get; set; }
    public int? CampaignId { get; set; }
}