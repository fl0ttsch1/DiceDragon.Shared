using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects;

// TODO background color/image
public class MapDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public RectangleF ViewBox { get; set; }
    public required List<MapTileDto> Tiles { get; set; }
    public required List<MapTokenDto> Tokens { get; set; }
}