using System;

namespace basics_of_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            //Outputs
            Console.Write("Hey ");
            Console.WriteLine("Martin");
            /*
             * this
             * is
             * a multiline
             * comment
             
            Console.WriteLine("Szabó\nMartin");
            Console.ReadKey();//prevents the program from closing
            */
            #endregion

            #region
            /*
            //variables
            //step 1 Declaration
            //step 2 Initialization

            //integer
            int x; //Declaration
            x = 123; //Initialization

            int y = 321; //both of them

            int z = x + y;

            int age = 21;

            //floatnumber (double)

            double height = 172.5;

            //boolean (can only be true or false)

            bool alive = true;

            //char (Can only store 1 character)

            char symbol = '$';

            //strings
            String name = "Szabó Martin";
            Console.WriteLine("Hello"+name);
            Console.WriteLine("Your age is "+age);
            Console.WriteLine("Your heihgt is " + height + "cm");
            Console.WriteLine("Are you alive? " +alive);
            Console.WriteLine("Your symbol is "+symbol);
            */
            #endregion

            #region
            /*
            //typcasting = Converting a value to a different datatype
            //             Useful when we accept user input (string)
            //             Different datatypes can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);
            int c = 123;
            double d = Convert.ToDouble(c) +0.1;
            int e = 21132;
            String f = Convert.ToString(e);

            String g = "$";

            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a);
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);
            Console.WriteLine(f.GetType());
            Console.WriteLine(f);
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);
            Console.WriteLine(j.GetType());
            Console.WriteLine(j);
            */
            #endregion

            #region
            /*
            //User input
            Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " +name);
            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are "+age+" years old! ");
            Console.WriteLine("How tall are u? ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You are "+height+"cm tall. ");


            Console.ReadKey();
            */
            #endregion

            #region
            /*
            //mathclass
            //few useful mathclass

            double x = 3.14;

            double b = 19.6;

            double c = -33;
            Console.WriteLine(Math.Pow(x, 3));
            Console.WriteLine(Math.Sqrt(b));
            Console.WriteLine(Math.Round(b));
            Console.WriteLine(Math.Abs(c));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Max(x,b));
            Console.WriteLine(Math.Min(x,b));


            */
            #endregion

            #region
            /*
            //random numbers

            Random random = new Random();

            int num = random.Next(1, 21);
            int num2 = random.Next(1, 21);
            int num3 = random.Next(1, 21);

            //double num2 = random.NextDouble();

            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
            */
            #endregion

            #region
            //rock paper scissors game
            /*
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player!= "PAPER" &&player !="SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }

                switch(random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("player: "+player);
                Console.WriteLine("computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer=="ROCK")
                        {
                            Console.WriteLine("Its a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lost!");
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("Its a draw");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lost!");
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer=="SCISSORS")
                        {
                            Console.WriteLine("Its a draw!");
                        }
                        else if (computer=="ROCK")
                        {
                            Console.WriteLine("You lost!");
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again? YES/NO: ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "YES")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Good bye!");
            */
            #endregion

            #region
            /*
            //arrays = a variable that can store multiple values. fixed size
            //String[] cars = { "BMW", "Mustang", "Corvette" };
            String[] cars = new string[3];
            cars[0] = "Audi";
            cars[1] = "BMW";
            cars[2] = "DODGE";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            */
            #endregion

            #region
            /*
            //methods = performs a section of code, whenever it's called "invoked".
            //          benefit = Let's us reuse code without writing it multiple times.
            String name = "Szabó Martin";
            int age = 21;
            singHappyBirthday(name,age);

            Console.ReadKey();
            */
            #endregion

            #region
            /*
            //method overloading = methods share same name, but different parameters
            //                     name + parameters = signature
            //                     methods must have a unique signature

            double total;
            total = Multiply(2, 3, 4);
            Console.WriteLine(total);
            Console.ReadKey();
            */
            #endregion

            #region
            /*
            //params keyword
            double total = CheckOut(21.24, 32.23, 435.23, 4234.3, 3.3);
            Console.WriteLine(total);
            */
            #endregion

            #region
            /*
            //exception handling
            // exceptions are errors that occur during executin
            //try = try some code that is considered "dangerous"
            //catch = catches and handles exceptions when they occur
            //finally = always executes regardless if exception is caught or not

            try
            {
                Console.WriteLine("Enter number 1: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                int y = Convert.ToInt32(Console.ReadLine());

                double result = x / y;
                Console.WriteLine("Result = " + result);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter only numbers please!");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting");
            }
            */
            #endregion

            #region
            /*
            //multidimensional arrays

            String[] ford = {"Mustang","F-150","Explorer"};
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };

            String[,] parkingLot = {{"Mustang","F-150","Explorer"},
                                    { "Corvette", "Camaro", "Silverado" },
                                    { "Corolla", "Camry", "Rav4" }
                                   };
            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";

            
            foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
            }

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i,j]+ " ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
            #endregion

            #region
            //object = an instance of a class
            //         A class can be used as a blueprint to create objects (OOP)
            //         objects can have fields and methods (characteristics and actions)

            Human human = new Human("Rick",101);
            Human human2 = new Human("Morty",18);

            

            human.Eat();
            human.Sleep();

            human2.Eat();
            human2.Sleep();


            #endregion

            #region
            //Constructors

            Car car1 = new Car("Ford","Mustang",2022,"red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();
            #endregion

            #region
            // static modifier
            // - declare a static member, which belongs to the class itself
            //  rather than to any specific object
            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();
            #endregion

            #region
            //overloaded constructors
            Pizza pizza1 = new Pizza("Stuffed crust", "tomato sauce", "mozzarella");
            Pizza pizza2 = new Pizza("Normal crust", "garlic sauce", "Cheddar", "Salami");
            #endregion

            #region
            //inheritance = 1 or more child classes recieving fields, methods etc. from a common parent

            Auto auto = new Auto();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            Console.WriteLine(auto.speed);
            Console.WriteLine(auto.wheels);

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            #endregion

            #region
            //abstract classes = modifier that indicates missing components or incomplete implementation
            //Vehicle vehicle = new Vehicle();  Vehicle is abstract, so i can't make an object from it

            #endregion

            #region
            //array of objects
            Cheese[] blockOfCheese = new Cheese[3];

            Cheese cheese1 = new Cheese("Cheddar", "Awesome", 1500);
            Cheese cheese2 = new Cheese("Trappista", "Great", 750);
            Cheese cheese3 = new Cheese("Mozzarella", "Average", 1000);

            blockOfCheese[0] = cheese1;
            blockOfCheese[1] = cheese2;
            blockOfCheese[2] = cheese3;

            Console.WriteLine(blockOfCheese[0].name);
            Console.WriteLine(blockOfCheese[1].name);
            Console.WriteLine(blockOfCheese[2].name);

            //OR

            foreach (Cheese cheese in blockOfCheese)
            {
                Console.WriteLine(cheese.name);
            }
            #endregion

            #region
            //objects as arguments

            Cheese cheese4 = new Cheese("Karaván", "Best", 2000);

            ChangePrice(cheese4, 3500);
            Console.WriteLine(cheese4.price);
            #endregion

            #region
            //method overriding = provides a new version of a method inherited from a parent class
            //                    inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism
            #endregion


        }

        public static void ChangePrice(Cheese cheese,int price)
        {
            cheese.price = price;
        }


        static void singHappyBirthday(string birthdayBoy, int yearsOld)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear "+birthdayBoy+"!");
            Console.WriteLine("You are"+yearsOld+"years old!");
            Console.WriteLine("Happy birthday to you!");
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
