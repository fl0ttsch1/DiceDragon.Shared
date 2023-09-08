namespace DiceDragon.Shared.ValueObjects;

public record Rectangle : RectangleBase<int>
{
    public Rectangle()
    {
    }

    public Rectangle(int x, int y, int size) : base(x, y, size)
    {
    }

    public Rectangle(int x, int y, int width, int height) : base(x, y, width, height)
    {
    }
}