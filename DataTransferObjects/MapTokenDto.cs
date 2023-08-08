using DiceDragon.Shared.Enums;
using DiceDragon.Shared.ValueObjects;
using System.Drawing;

namespace DiceDragon.Shared.DataTransferObjects;

public class MapTokenDto
{
    public TokenType CreatureType { get; set; }
    public int Id { get; set; }

    public required string Name { get; set; }
    public required HitPoints HitPoints { get; set; }
    public Affiliation Affiliation { get; set; }

    public required string ImageUrl { get; set; }
    public Rectangle Bounds { get; set; }
    public bool IsVisible { get; set; }
}