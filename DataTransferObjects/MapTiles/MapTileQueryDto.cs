using DiceDragon.Shared.DataTransferObjects.MapItems;

namespace DiceDragon.Shared.DataTransferObjects.MapTiles;

public class MapTileQueryDto : MapItemQueryDto
{
    public int ImageId { get; set; }
}