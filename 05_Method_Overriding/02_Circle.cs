using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Method_Overriding
{
    public class CircleTwo : ShapeTwo
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
