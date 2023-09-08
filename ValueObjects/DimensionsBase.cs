namespace DiceDragon.Shared.ValueObjects;

public abstract class DimensionsBase<T> where T : struct
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Width { get; set; }
    public T Height { get; set; }

    protected DimensionsBase() { }
    protected DimensionsBase(T x, T y, T size) : this(x, y, size, size) { }
    
    protected DimensionsBase(T x, T y, T width, T height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }
}