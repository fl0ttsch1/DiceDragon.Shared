namespace DiceDragon.Shared.ValueObjects;
public record Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
    }

    public Point(int value) : this(value, value)
    {
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}