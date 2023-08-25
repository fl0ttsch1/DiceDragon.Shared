namespace DiceDragon.Shared.ValueObjects;

public class Dimensions
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public Dimensions()
    {

    }

    public Dimensions(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public Dimensions(int x, int y, int size) : this(x, y, size, size)
    {

    }
}