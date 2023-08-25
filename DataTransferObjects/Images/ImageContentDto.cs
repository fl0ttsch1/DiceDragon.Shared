namespace DiceDragon.Shared.DataTransferObjects.Images;

public record ImageContentDto(
    byte[] Bytes,
    string Type);