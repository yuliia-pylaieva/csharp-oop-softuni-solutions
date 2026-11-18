// See https://aka.ms/new-console-template for more information

namespace Shapes2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // IDrawer drawer = new ConsoleDrawer();
            // IDrawable rectangle= new Rectangle(drawer);
            // IDrawable triangle = new Triangle();
            // ICollection<IDrawable> shapes = new List<IDrawable>();
            // shapes.Add(rectangle);
            // shapes.Add(triangle);
            // foreach(IDrawable shape in shapes)
            // {
            //     shape.Draw();
            // }
            //
            // IDrawer drawer2 = new FileDrawer();
            // IDrawable rectangle2 = new Rectangle(drawer2);
            // rectangle2.Draw();

            IDrawer drawer3 = new WebDrawer();
            IDrawable rectangle3 = new Rectangle(drawer3);
            rectangle3.Draw();
        }
    }
}