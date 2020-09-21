using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04_Access_Modifiers
{
    class Box
    {
        public static void Action()
        {
            //boxing of elements = performance penalty
            var list = new ArrayList();
            list.Add(1);
            list.Add("Adrian");
            list.Add(DateTime.Now);

            var anotherList = new List<int>();
            var names = new List<string>();


        }
    }
}
