using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects;

public class TokenDto
{
    public bool IsVisible { get; set; }
    public Rectangle Bounds { get; set; }
}