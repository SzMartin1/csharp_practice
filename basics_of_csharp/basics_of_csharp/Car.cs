using System;
using System.Collections.Generic;
using System.Text;

namespace basics_of_csharp
{
    class Car
    {
        String make;
        String model;
        int year;
        String color;
        public static int numberOfCars;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            numberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($" You drive the {make} {model}.");
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun.");
        }
    }
}
