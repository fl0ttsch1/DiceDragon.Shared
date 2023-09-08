using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.MapRooms;

public class MapRoomCreationDto
{
    public int MapId { get; set; }
    public required string Name { get; set; }
    public required List<Point> Points { get; set; }
    public RectangleF? ViewBox { get; set; }
    public bool IsActive { get; set; }
}