namespace DiceDragon.Shared.DataTransferObjects;

public record ImageContentDto(
    byte[] Bytes,
    string Type);