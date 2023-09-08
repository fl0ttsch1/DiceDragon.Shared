namespace DiceDragon.Shared.ValueObjects;

public record RectangleF : RectangleBase<float>
{
    public RectangleF()
    {
    }

    public RectangleF(float x, float y, float size) : base(x, y, size)
    {
    }

    public RectangleF(float x, float y, float width, float height) : base(x, y, width, height)
    {
    }
}