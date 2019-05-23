using System;
using System.Diagnostics.CodeAnalysis;

namespace cs_speed_practice_10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a program in C# Sharp to find the sum of all elements of the array. 

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            int[] array = new[] { 2, 5, 8 };

            var sum = 0;

            for (var i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
        }
    }
}
