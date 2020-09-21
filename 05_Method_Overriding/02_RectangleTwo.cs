using System;

namespace _05_Method_Overriding
{
    public class RectangleTwo : ShapeTwo
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }
}
