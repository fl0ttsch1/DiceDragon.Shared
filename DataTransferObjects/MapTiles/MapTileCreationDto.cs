using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.MapTiles;

public record MapTileCreationDto
{
    public int ImageId { get; set; }
    public string? ImageUrl { get; set; }
    public required RectangleF Bounds { get; set; }
    public string? Name { get; set; }
}