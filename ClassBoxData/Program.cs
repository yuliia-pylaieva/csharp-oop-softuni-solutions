// See https://aka.ms/new-console-template for more information

namespace ClassBoxData;

public static class Program
{
    public static void Main(string[] args)
    {
        if (!double.TryParse(Console.ReadLine(), out double length) ||
            !double.TryParse(Console.ReadLine(), out double width) ||
            !double.TryParse(Console.ReadLine(), out double height))
        {
            Console.WriteLine("Please enter valid numbers.");
            return;
        }

        try
        {
            var box = new Box(length, width, height);
            Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}