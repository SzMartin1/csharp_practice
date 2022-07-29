using System;
using System.Collections.Generic;
using System.Text;

namespace basics_of_csharp
{
    class Human
    {
        public String name;
        public int age;
        
        public Human(String name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }
    }
}
