using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;
public record MapTileCreationDto(
    int ImageId,
    DimensionsF Bounds,
    string? Name);
