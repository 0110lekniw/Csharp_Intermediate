using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intr_Classes
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Access_Mod
    {
        public static void Action()
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1997, 9, 2));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
 