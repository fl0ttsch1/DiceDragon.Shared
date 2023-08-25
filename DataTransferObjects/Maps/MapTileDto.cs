using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public class MapTileDto
{
    public int Id { get; set; }
    public required DimensionsF Bounds { get; set; }

    public int ImageId { get; set; }
    public required string ImageUrl { get; set; }
}