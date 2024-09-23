namespace DoCasting
{
    class DoCasting
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int sum = 17;
            int count = 5;
            
            // Calculating average using int
            int intAverage = sum / count;
            Console.WriteLine(intAverage); // prints out 3, when it should be 3.4

            // Calculating average using double
            double doubleAverage = sum / count;
            Console.WriteLine(doubleAverage); // still prints out 3

            // Casting sum variable as double
            Console.WriteLine((double)sum / count); // prints out 3.4
        }
    }
}