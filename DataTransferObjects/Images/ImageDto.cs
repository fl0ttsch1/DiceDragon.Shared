namespace DiceDragon.Shared.DataTransferObjects.Images;

public class ImageDto
{
    public int Id { get; set; }
    public required string ContentType { get; set; }
    public string? Name { get; set; }
    public Uri? Source { get; set; }
}