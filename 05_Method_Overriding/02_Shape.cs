using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Method_Overriding
{
    public abstract class ShapeTwo
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shapie into clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
