using System;
using System.Collections.Generic;
using System.Text;

namespace basics_of_csharp
{
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
    }
}
