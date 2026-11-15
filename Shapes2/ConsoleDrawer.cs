namespace Shapes2;

public class ConsoleDrawer : IDrawer
{
    public void DrawFigure(string figureToDraw)
    {
        Console.WriteLine(figureToDraw);
    }
}