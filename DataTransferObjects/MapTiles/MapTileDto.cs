using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.MapTiles;

public class MapTileDto
{
    public int Id { get; set; }
    public int ImageId { get; set; }
    public required string ImageUrl { get; set; }
    public required RectangleF Bounds { get; set; }
}