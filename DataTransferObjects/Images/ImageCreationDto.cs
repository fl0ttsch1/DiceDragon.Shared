namespace DiceDragon.Shared.DataTransferObjects.Images;
public class ImageCreationDto
{
    public required string Name { get; set; }
    public required byte[] Content { get; set; }
    public required string ContentType { get; set; }
    public Uri? Url { get; set; }
}
