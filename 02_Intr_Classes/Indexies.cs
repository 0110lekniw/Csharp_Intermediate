using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intr_Classes
{

    public class Indexies
    {

        public static void Action()
        {
            var cookie = new HttpClass();
            cookie["name"] = "Adrian";
            Console.WriteLine(cookie["name"]);
        }
    }
}
