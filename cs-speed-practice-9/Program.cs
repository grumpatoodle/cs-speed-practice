using System;

namespace cs_speed_practice_9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a program in C# Sharp to read n number of values in an array and display it in reverse order.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            int[] array = new[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (var i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
