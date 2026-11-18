namespace Shapes;

public class Rectangle : IDrawable
{
    private int height;
    private int width;

    public Rectangle(int width, int height)
    {
        if (width < 1) throw new ArgumentOutOfRangeException(nameof(width), "Width must be at least 1");
        if (height < 1) throw new ArgumentOutOfRangeException(nameof(height), "Height must be at least 1");
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        DrawLine(this.width, '*', '*');
        for (int i = 1; i < this.height - 1; ++i)
            DrawLine(this.width, '*', ' ');
        DrawLine(this.width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < width - 1; ++i)
            Console.Write(mid);
        Console.WriteLine(end);
    }
}