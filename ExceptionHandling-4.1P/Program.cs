namespace ExceptionHandling_4._1P
{
    class Program
    {
        // Declaring necessary variables for the demonstration
        private static int recursionLimit = 1000;
        private static int recursionDepth = 0;

        // Creating functions for demonstration
        static void RecursiveMethod()
        {
            recursionDepth++;
            if (recursionDepth > recursionLimit)
            {
                throw new StackOverflowException("Recursion limit exceeded"); // preventing actual overflow by setting recursion limit to 1000
            }

            Console.WriteLine($"Recursion depth: {recursionDepth}");
            RecursiveMethod();
        }

        static void PrintString(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "Argument cannot be null");
            }
            Console.WriteLine(str);
        }

        static void PrintNumberInRange(int number)
        {
            if (number < 0 || number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 0 and 100");
            }
            Console.WriteLine(number);
        }

        static void SetAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative", nameof(age));
            }
            Console.WriteLine($"Age is set to: {age}");
        }

        // Errors handled here
        static void Main(string[] args)
        {
            // a) NullReferenceException
            try
            {
                string str = null;
                Console.WriteLine(str.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // b) IndexOutOfRangeException
            try
            {
                int[] arr = new int[5];
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // d) OutOfMemoryException
            try
            {
                int[] largeArray = new int[int.MaxValue];
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // e) DivideByZeroException
            try
            {
                int zero = 0;
                int result = 10 / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // f) ArgumentNullException
            try
            {
                string nullArg = null;
                PrintString(nullArg);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // g) ArgumentOutOfRangeException
            try
            {
                PrintNumberInRange(101);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // h) FormatException
            try
            {
                int invalidNumber = int.Parse("NotANumber");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // i) ArgumentException
            try
            {
                SetAge(-1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // j) SystemException
            try
            {
                throw new SystemException("Custom system exception");
            }
            catch (SystemException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }

            // c) StackOverflowException - put this last because it gets messy
            try
            {
                RecursiveMethod();
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }
        }
    }
}
