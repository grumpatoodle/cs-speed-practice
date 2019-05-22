using System;

namespace cs_speed_practice_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a C# Sharp program to check whether a given number is positive or negative.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            Console.Write("Please enter a number: ");
            var number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("You entered a positive number.");
            }
            else
            {
                Console.WriteLine("You entered a negative number.");
            }
        }
    }
}
