using System;

namespace cs_speed_practice_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a C# Sharp program to find whether a given year is a leap year or not.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            Console.Write("Please enter a year (YYYY) to find out if it is a leap year: ");
            var year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 || year % 400 == 0)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("This is not a leap year, it is just a common year.");
            }
        }
    }
}
