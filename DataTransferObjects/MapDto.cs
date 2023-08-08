using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects;


// TODO background color/image
public record MapDto(
    int Id,
    string Name,
    RectangleF ViewBox,
    List<MapTileDto> Tiles);