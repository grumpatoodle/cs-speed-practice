using System;

namespace cs_speed_practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a C# Sharp program to accept two integers and check whether they are equal or not.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            Console.Write("Please enter a number: ");
            var x = Console.ReadLine();
            Console.Write("Please enter a second number: ");
            var y = Console.ReadLine();

            if (x == y)
            {
                Console.WriteLine("Yay! Your numbers are equal to each other!");
            }
            else
            {
                Console.WriteLine("Awww. Your numbers are not equal to each other.");
            }
        }
    }
}
