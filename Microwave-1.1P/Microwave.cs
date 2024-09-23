using System.ComponentModel.Design;

namespace Microwave
{
    class Microwave
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int item = 0;
            int time = 0;
            double calcuation = 0;

            // Try-catch for validation
            try
            {
                // Inputs
                Console.WriteLine("How many times do you want to heat up?");
                item = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How long does it take to heat up one item?");
                time = Convert.ToInt32(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Invalid response. Enter a number.");
            }
            
            // Providing heating duration recommendation based on item and time.
            if (item > 3)
            {
                Console.WriteLine("It is not recommended that you heat more than 3 items.");
            } else if (item == 3)
            {
                calcuation = time * 2;
                Console.WriteLine("You should heat it up for " + calcuation.ToString() + " minutes.");
            }
            else if (item == 2)
            {
                calcuation = time * 1.5;
                Console.WriteLine("You should heat it up for " + calcuation.ToString() + " minutes.");
            } else if (item == 1) {
                Console.WriteLine("You should heat it up for " + time.ToString() + " minutes.");
            } else
            {
                Console.WriteLine("You don't have any items to heat up.");
            }

        }
    }
}