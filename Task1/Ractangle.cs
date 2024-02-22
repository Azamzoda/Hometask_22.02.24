public class Ractangle
{
    public int Width;
    public int Height;
    public string Color;
    public int GetArea()
    {
        return Width/Height;
    }
    public int GetPerimeter()
    {
        return 2*(Width+Height);
    }
}