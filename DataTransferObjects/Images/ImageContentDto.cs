namespace DiceDragon.Shared.DataTransferObjects.Images;

public class ImageContentDto : ImageDto
{
    public required byte[] Content { get; set; }
}