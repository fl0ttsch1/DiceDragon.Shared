using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects;

public class TokenBaseDto
{
    public required string ImageUrl { get; set; }
    public Rectangle Bounds { get; set; }
    public bool IsVisible { get; set; }
}