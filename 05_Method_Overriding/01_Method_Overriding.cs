using System.Collections.Generic;
using System.Text;

namespace _05_Method_Overriding
{
    class _01_Method_Overriding
    {
        public static void Action()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
}
