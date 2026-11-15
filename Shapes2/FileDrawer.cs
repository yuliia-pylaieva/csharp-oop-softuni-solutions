namespace Shapes2;

public class FileDrawer : IDrawer
{
    public void DrawFigure(string figureToDraw)
    {
        string path = "../../../file.txt";
        File.WriteAllText(path, figureToDraw);
    }
}