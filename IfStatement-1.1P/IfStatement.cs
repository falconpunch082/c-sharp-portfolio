
using System;

namespace IfStatement
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Enter a number betweeen 1 to 9:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Try-catch error-handling if input is between 1 to 9
            try
            {
                if (number == 1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number == 2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number == 3)
                {
                    Console.WriteLine("THREE");
                }
                else if (number == 4)
                {
                    Console.WriteLine("FOUR");
                }
                else if (number == 5)
                {
                    Console.WriteLine("FIVE");
                }
                else if (number == 6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number == 7)
                {
                    Console.WriteLine("SEVEN");
                }
                else if (number == 8)
                {
                    Console.WriteLine("EIGHT");
                }
                else if (number == 9)
                {
                    Console.WriteLine("NINE");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}