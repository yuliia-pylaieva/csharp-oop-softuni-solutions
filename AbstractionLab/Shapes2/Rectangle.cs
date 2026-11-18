namespace Shapes2;

public class Rectangle : IDrawable
{
    private readonly IDrawer _drawer;

    public Rectangle(IDrawer drawer)
    {
        _drawer = drawer;
    }

    public void Draw()
    {
        _drawer.DrawFigure("Rectangle");
    }
}