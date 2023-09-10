namespace DiceDragon.Shared.DataTransferObjects.Images;

public class ImageCreationDto
{
    public byte[]? Content { get; set; }
    public string? ContentType { get; set; }
    public string? Name { get; set; }
    public string? Source { get; set; }
}