using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public class MapRoomUpdateDto
{
    public List<Point>? Points { get; set; }
    public bool? IsActive { get; set; }
}