namespace DiceDragon.Shared.DataTransferObjects.MapTiles;

public class MapTileDto
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int ImageId { get; set; }
    public required string ImageUrl { get; set; }

    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
}