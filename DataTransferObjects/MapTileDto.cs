using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects;

public class MapTileDto
{
    public int Id { get; set; }
    public RectangleF Bounds { get; set; }
    public required string ImageUrl { get; set; }
}