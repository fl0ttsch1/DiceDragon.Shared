namespace DiceDragon.Shared.ValueObjects;

public class Dimensions : DimensionsBase<int>
{
    public Dimensions()
    {
    }

    public Dimensions(int x, int y, int size) : base(x, y, size)
    {
    }

    public Dimensions(int x, int y, int width, int height) : base(x, y, width, height)
    {
    }
}