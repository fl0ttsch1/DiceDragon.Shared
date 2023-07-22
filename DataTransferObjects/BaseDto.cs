namespace DiceDragon.Shared.DataTransferObjects;

public abstract class BaseDto<TKey>
{
    public TKey Id { get; set; }
    public string Name { get; set; }
    public string? Notes { get; set; }
}
