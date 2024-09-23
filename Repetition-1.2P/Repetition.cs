namespace Repetition
{
    class Repetition
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int sum = 0;
            double average;
            int upperbound = 100;

            /* For loop
            for (int number = 1; number <= upperbound; number++)
            {
                sum += number;
            }
            */

            /* While loop
            int number = 1;
            while (number <= upperbound) {
                sum += number;
                Console.WriteLine("Current number: " + number.ToString() + ". The sum is " + sum.ToString());
                number++;
            }
            */

            // Do-while loop
            int number = 1;
            do
            {
                sum += number;
                number++;
            } while (number <= upperbound);

            // Calculating average
            average = (double)sum / upperbound;

            // Displaying results
            Console.WriteLine("The sum is " + sum.ToString());
            Console.WriteLine("The average is " + average.ToString());
        }
    }
}