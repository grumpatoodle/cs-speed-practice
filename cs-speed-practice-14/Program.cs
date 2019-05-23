using System;

namespace cs_speed_practice_14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            // declares an Array of integers. 
            int[] intArray;

            // allocating memory for 5 integers. 
            intArray = new int[5];

            // initialize the first elements 
            // of the array 
            intArray[0] = 10;

            // initialize the second elements 
            // of the array 
            intArray[1] = 20;

            // so on... 
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // accessing the elements 
            // using for loop 
            Console.WriteLine("For loop:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(" " + intArray[i]);
            }

            Console.WriteLine("For-each loop:");

            // using for-each loop 
            foreach (int i in intArray)
            {
                Console.WriteLine(" " + i);
            }

            Console.WriteLine("While loop:");

            // using while loop 
            int j = 0;
            while (j < intArray.Length)
            {
                Console.WriteLine(" " + intArray[j]);
                j++;
            }

            Console.WriteLine("Do-while loop:");

            // using do-while loop 
            int k = 0;
            do
            {
                Console.WriteLine(" " + intArray[k]);
                k++;
            } while (k < intArray.Length);
        }
    }
}
