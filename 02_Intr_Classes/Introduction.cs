using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intr_Classes
{
    class Introduction
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }

            // Instance Method
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }
        }
        public static void Action()
        {
            var person = Person.Parse("John");
            person.Introduce("Adrian");
        }
    }
}
