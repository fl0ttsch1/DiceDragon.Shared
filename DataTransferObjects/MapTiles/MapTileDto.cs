using DiceDragon.Shared.DataTransferObjects.MapItems;

namespace DiceDragon.Shared.DataTransferObjects.MapTiles;

public class MapTileDto : MapItemDto
{
    public int ImageId { get; set; }
    public required string ImageUrl { get; set; }

    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
}