using DiceDragon.Shared.DataTransferObjects.MapItems;

namespace DiceDragon.Shared.DataTransferObjects.MapTiles;

public class MapTileUpdateDto : MapItemUpdateDto
{
    public int? ImageId { get; set; }
    public string? ImageUrl { get; set; }
    
    public float? X { get; set; }
    public float? Y { get; set; }
    public float? Width { get; set; }
    public float? Height { get; set; }
}