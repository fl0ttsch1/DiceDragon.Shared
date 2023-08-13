namespace DiceDragon.Shared.DataTransferObjects;

public class ImageDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string ContentType { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string? Url { get; set; }
}