namespace DiceDragon.Shared.ValueObjects;

public class DimensionsF : DimensionsBase<float>
{
    public DimensionsF()
    {
    }

    public DimensionsF(float x, float y, float size) : base(x, y, size)
    {
    }

    public DimensionsF(float x, float y, float width, float height) : base(x, y, width, height)
    {
    }
}