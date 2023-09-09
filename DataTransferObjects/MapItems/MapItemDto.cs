namespace DiceDragon.Shared.DataTransferObjects.MapItems;

public abstract class MapItemDto
{
    public int Id { get; set; }
    public int MapId { get; set; }
    public bool IsVisible { get; set; }
}