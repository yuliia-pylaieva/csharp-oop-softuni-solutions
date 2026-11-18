namespace Shapes2;

public class WebDrawer : IDrawer
{
    public void DrawFigure(string figureToDraw)
    {
        string path = "../../../file.html";

        string result = $"<html><body>{figureToDraw}</body></html>";

        File.WriteAllText(path, figureToDraw);
    }
}