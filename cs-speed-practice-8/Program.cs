using System;

namespace cs_speed_practice_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a program to store elements in an array and print it. 

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            int[] array = new[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            for (var i = 1; i < array.GetLength(0); i++)
            {
                i = array[i];
                Console.Write(array[i] + " ");
            }
        }
    }
}
