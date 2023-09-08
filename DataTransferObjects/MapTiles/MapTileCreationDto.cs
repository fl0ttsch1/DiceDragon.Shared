using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.MapTiles;
public record MapTileCreationDto(
    int ImageId,
    DimensionsF Bounds,
    string? Name);
