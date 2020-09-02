using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intr_Classes
{
    class Constructor
    {

        public static void Action()
        {
            var customer = new Customer(1, "Adrian");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}