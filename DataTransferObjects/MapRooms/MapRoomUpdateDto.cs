using DiceDragon.Shared.DataTransferObjects.MapItems;
using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.MapRooms;

public class MapRoomUpdateDto : MapItemUpdateDto
{
    public string? Name { get; set; }
    public List<Point>? Points { get; set; }
    public RectangleF? ViewBox { get; set; }
}