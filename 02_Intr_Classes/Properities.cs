using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intr_Classes
{
    class Properities
    {
        public static void Action()
        {
            var person = new Persons(new DateTime(1997, 9, 2));
            Console.WriteLine(person.Age);

        }
    }
}
