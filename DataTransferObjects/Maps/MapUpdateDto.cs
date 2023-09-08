using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public record MapUpdateDto
{
    public int? CampaignId { get; set; }
    public bool? IsActive { get; set; }

    public string? Name { get; set; }
    public RectangleF? ViewBox { get; set; }
}