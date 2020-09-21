using System.Collections.Generic;
using System.Text;

namespace _05_Method_Overriding
{
    public class _02_AbstractClasses
    {
        public static void Action()
        {

            var circle = new CircleTwo();
            circle.Draw();

            var rectangle = new RectangleTwo();
            rectangle.Draw();
        }
    }
}
