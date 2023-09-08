using DiceDragon.Shared.ValueObjects;
using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects.MapRooms;

public class MapRoomCreationDto
{
    public int MapId { get; set; }
    public required string Name { get; set; }
    public required List<Point> Points { get; set; }
    public bool IsActive { get; set; }

    public DimensionsF? ViewBox { get; set; }
}