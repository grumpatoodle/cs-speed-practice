using System;

namespace cs_speed_practice_15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }
    // Bubble Sort

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            int[] array = new[] { 6,5,4,3,2,1 };

            //var highestValue = array[0];

            //for (var i = 0; i < array.GetLength(0); i++)
            //{
            //    if (array[i] > highestValue)
            //    {
            //        highestValue = array[i];
            //    }
            //}

            //Console.Write(highestValue);

            var value = array[0];

            // value = 5
            //Console.WriteLine(value);
            // i = 
            for (var i = 0; i < array.Length-1; i++)
                //Console.Write(array[i] + ".");
            {
                // j = 
                for (var j = 0; j < array.Length-1; j++)
                    //Console.Write(array[j] + "..");
                {
                    if (array[j] > array[j+1])
                    {
                        value = array[j];
                        array[j] = array[j+1];
                        array[j+1] = value;
                    }
                    foreach (var item in array)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }

            
        }
    }
}
