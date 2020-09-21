using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialised. {0}", registrationNumber);
        }
    }
}
