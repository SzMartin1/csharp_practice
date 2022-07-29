using System;
using System.Collections.Generic;
using System.Text;

namespace basics_of_csharp
{
    abstract class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
}
