namespace DiceDragon.Shared.ValueObjects;

public class DimensionsF
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }

    public DimensionsF()
    {

    }

    public DimensionsF(float x, float y, float width, float height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }
}