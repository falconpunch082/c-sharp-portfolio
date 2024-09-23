// SIT232 - 1.1P
using System;

namespace SwitchStatement
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Enter a number betweeen 1 to 9:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Switch
            switch (number)
            {
                case 1: Console.WriteLine("ONE"); break;
                case 2: Console.WriteLine("TWO"); break;
                case 3: Console.WriteLine("THREE"); break;
                case 4: Console.WriteLine("FOUR"); break;
                case 5: Console.WriteLine("FIVE"); break;
                case 6: Console.WriteLine("SIX"); break;
                case 7: Console.WriteLine("SEVEN"); break;
                case 8: Console.WriteLine("EIGHT"); break;
                case 9: Console.WriteLine("NINE"); break;
                default: Console.WriteLine("You must enter an integer between 1 and 9."); break;
            }
        }
    }
}