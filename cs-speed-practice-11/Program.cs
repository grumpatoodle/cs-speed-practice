using System;

namespace cs_speed_practice_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a program in C# Sharp to copy the elements one array into another array.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            int[] array1 = new[] { 15, 10, 12 };

            for (var i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }

            
        }
    }
}
