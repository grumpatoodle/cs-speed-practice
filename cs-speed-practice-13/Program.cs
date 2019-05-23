using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace cs_speed_practice_13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a program in C# Sharp to print all unique elements in an array.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            var array = new[] { 4, 9, 9, 48, 6, 3, 12 };

            var uniqueValues = GetUniqueValues(array);
            
            foreach (var item in uniqueValues)
            {
                Console.WriteLine($"The unique value is: {item}");
            }
        }

        public List<int> GetUniqueValues(int[] array)
        {
            var numberOfNumbersFound = new Dictionary<int, int>();

            for (var i = 0; i < array.GetLength(0); i++)
            {
                if (!numberOfNumbersFound.ContainsKey(array[i]))
                {
                    numberOfNumbersFound.Add(array[i], 0);
                }

                numberOfNumbersFound[array[i]]++;
            }

            var uniqueNumbersFound = new List<int>();

            foreach (var fooFoo in numberOfNumbersFound)
            {
                if (fooFoo.Value == 1)
                {
                    uniqueNumbersFound.Add(fooFoo.Key);
                }
            }

            return uniqueNumbersFound;
        }
    }
}
