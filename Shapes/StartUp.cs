// See https://aka.ms/new-console-template for more information

namespace Shapes
{
    public static class StartUp
    {
        public static void Main()
        {
            try
            {
                if (!int.TryParse(Console.ReadLine(), out var radius))
                    throw new InvalidOperationException("Invalid radius");

                IDrawable circle = new Circle(radius);

                if (!int.TryParse(Console.ReadLine(), out var width))
                    throw new InvalidOperationException("Invalid width");
                if (!int.TryParse(Console.ReadLine(), out var height))
                    throw new InvalidOperationException("Invalid height");

                IDrawable rect = new Rectangle(width, height);

                circle.Draw();
                rect.Draw();
            }
            catch (Exception e) when (e is InvalidOperationException or ArgumentException)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}