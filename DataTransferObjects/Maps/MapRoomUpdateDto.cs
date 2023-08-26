using DiceDragon.Shared.ValueObjects;
using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public class MapRoomUpdateDto
{
    public string? Name { get; set; }
    public List<Point>? Points { get; set; }
    public DimensionsF? ViewBox { get; set; }
    public bool? IsActive { get; set; }
}