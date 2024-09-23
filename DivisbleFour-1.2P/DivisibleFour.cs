namespace DivisibleFour
{
    class DivisibleFour
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int n = 0;
            Boolean divFour = false;
            Boolean divFive = false;

            // Input
            try
            {
                Console.WriteLine("Enter a number.");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }

            // For loop
            for (int i = 1; i <= n; i++)
            {
                // Check if i is divisble by 4.
                if (i % 4 == 0)
                {
                    divFour = true;
                }

                // Check if i is divisble by 5.
                if (i % 5 == 0)
                {
                    divFive = true;
                }

                // Print number if number is divisible by 4 AND not by 5.
                if (divFour & !divFive)
                {
                    Console.WriteLine(i);
                }

                // Reset booleans for next loop
                divFour = false;
                divFive = false;
            }
        }
    }
}