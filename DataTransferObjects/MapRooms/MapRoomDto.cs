using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.MapRooms;

public class MapRoomDto
{
    public int Id { get; set; }
    public int MapId { get; set; }
    public required string Name { get; set; }
    public required List<Point> Points { get; set; }
    public RectangleF? ViewBox { get; set; }
    public bool IsActive { get; set; }
}