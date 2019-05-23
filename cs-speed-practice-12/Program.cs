using System;

namespace cs_speed_practice_12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a program in C# Sharp to count a total number of duplicate elements in an array.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            var array = new[] { 4, 9, 9, 48, 6, 3, 12 };

            var arrayDuplicate = GetDuplicateNumbers(array);

            Console.WriteLine(arrayDuplicate);
        }

        public bool GetDuplicateNumbers(int[] array)
        {
            int number = array[0];

            for (var i = 1; i < array.GetLength(0); i++)
            {
                if (array[i] == number)
                {
                    return true;
                }

                number = array[i];
            }

            return false;
        }
    }
}
