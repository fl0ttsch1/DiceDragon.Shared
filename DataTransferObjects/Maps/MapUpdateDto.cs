using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public record MapUpdateDto
{
    public string? Name { get; set; }
    public DimensionsF? ViewBox { get; set; }
    public bool? IsActive { get; set; }
}