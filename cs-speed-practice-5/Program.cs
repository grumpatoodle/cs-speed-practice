using System;

namespace cs_speed_practice_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            Console.Write("Please enter your age: ");
            var age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote yet.");
            }
        }
    }
}
