using DiceDragon.Shared.DataTransferObjects.MapItems;
using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.MapRooms;

public class MapRoomDto : MapItemDto
{
    public required string Name { get; set; }
    public required List<Point> Points { get; set; }
    public RectangleF? ViewBox { get; set; }
}