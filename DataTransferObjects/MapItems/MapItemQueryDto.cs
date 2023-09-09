namespace DiceDragon.Shared.DataTransferObjects.MapItems;

public abstract class MapItemQueryDto
{
    public int? MapId { get; set; }
    public bool? IsVisible { get; set; }
}