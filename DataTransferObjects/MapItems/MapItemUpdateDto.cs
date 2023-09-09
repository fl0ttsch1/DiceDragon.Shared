namespace DiceDragon.Shared.DataTransferObjects.MapItems;

public abstract class MapItemUpdateDto
{
    public int? MapId { get; set; }
    public bool? IsVisible { get; set; }
}