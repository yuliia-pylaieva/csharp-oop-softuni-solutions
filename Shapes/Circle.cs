namespace Shapes;

public class Circle : IDrawable
{
    private int radius;

    public Circle(int radius)
    {
        if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Radius cannot be negative");
        this.radius = radius;
    }

    public void Draw()
    {
        if (this.radius == 0)
        {
            Console.WriteLine("*");
            return;
        }

        double rIn = this.radius - 0.4;
        double rOut = this.radius + 0.4;
        for (double y = this.radius; y >= -this.radius; --y)
        {
            for (double x = -this.radius; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= rIn * rIn && value <= rOut * rOut)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}