using System;
using System.Collections.Generic;

namespace P02.Graphic_Editor
{
    public static class Program
    {
        private static void Main()
        {
            var editor = new GraphicEditor();
            var shapes = new List<IShape>
           {
               new Circle(),
               new Rectangle(),
               new Circle()
           };
            try
            {
                var editedShapes = new List<IShape>();
                if (editedShapes == null) throw new ArgumentNullException(nameof(editedShapes));

                foreach (var shape in shapes)
                {
                    editor.DrawShape(shape);
                }

                foreach (var shape in editedShapes)
                {
                    Console.WriteLine(shape.ToString());
                }
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
        }
    }
}
