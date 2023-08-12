namespace DiceDragon.Shared.ValueObjects;

public class ViewBox
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }

    public override string ToString()
    {
        return string.Join(" ", X, Y, Width, Height);
    }
}