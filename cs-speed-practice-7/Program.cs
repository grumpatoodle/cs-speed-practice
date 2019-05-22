using System;
using System.Linq;

namespace cs_speed_practice_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    // Write a formula to determine whether a word is a Palindrome or not.

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            Console.Write("Please enter a word to check if it is a Palindrome: ");
            var input = Console.ReadLine();

            char[] inputChar = input.ToCharArray();

            Array.Reverse(inputChar);
            var reverse = new string(inputChar);

            Console.WriteLine(reverse);

            bool isPalindrome = input.Equals(reverse);

            if (isPalindrome == true)
            {
                Console.WriteLine("This is a Palindrome!");
            }
            else
            {
                Console.WriteLine("This is not a Palindrome.");
            }
        }
    }
}
