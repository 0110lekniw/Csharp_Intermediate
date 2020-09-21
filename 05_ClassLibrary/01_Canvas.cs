using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ClassLibrary
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(); 
            }
        }
    }
}
