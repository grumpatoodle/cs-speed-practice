using System;
using System.Reflection.Emit;

namespace cs_speed_practice_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
    // Test Data :
    // Input the value for X coordinate : 7 
    // Input the value for Y coordinate : 9 
    // Expected Output :
    // The coordinate point (7,9) lies in the First quadrant.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            Console.Write("Please enter a value for x: ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Please enter a value for y: ");
            var y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Your coordinate is in Quadrant I.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Your coordinate is in Quardrant II.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Your coordinate is in Quadrant III.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Your coordinate is in Quadrant IV.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Your coordinate is at the origin.");
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("This coordinate is not in a Quadrant, it lies on the Y-Axis.");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine("This coordinate is not in a Quadrant, it lies on the X-Axis.");
            }
        }
    }
}
