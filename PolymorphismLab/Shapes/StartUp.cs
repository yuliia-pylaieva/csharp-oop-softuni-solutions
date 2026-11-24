namespace Shapes;

public class StartUp
{
    public static void Main()
    {
        Shape rectangle = new Rectangle(3, 4);
        Shape circle = new Circle(5);

        foreach (Shape shape in new[] { rectangle, circle })
        {
            Console.WriteLine(shape.Draw());
            Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}");
            Console.WriteLine($"Area: {shape.CalculateArea():F2}");
        }
    }
}
