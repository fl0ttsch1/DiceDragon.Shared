namespace DiceDragon.Shared.ValueObjects;

public abstract record RectangleBase<T> where T : struct
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Width { get; set; }
    public T Height { get; set; }

    public RectangleBase()
    {
    }

    public RectangleBase(T x, T y, T size) : this(x, y, size, size)
    {
    }

    public RectangleBase(T x, T y, T width, T height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }
}