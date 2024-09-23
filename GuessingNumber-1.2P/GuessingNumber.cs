namespace GuessingNumber
{
    class GuessingNumber
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int input = 0;
            int number = 5;
            Boolean right = false;
            Boolean valid = false;

            // Do-While loop to run until user guesses correct number
            do
            {
                // While loop to be exited when a number betweeen 1 and 10 inclusive is provided
                while (!valid)
                {
                    // Try-catch for non-numbers
                    try
                    {
                        Console.WriteLine("Please guess a number between 1 and 10 inclusive.");
                        input = Convert.ToInt32(Console.ReadLine());
                        // If input within range, change valid boolean to true and exit loop.
                        // Otherwise, continue with the loop.
                        if (input >= 1 & input <= 10)
                        {
                            valid = true;
                        }
                        else
                        {
                            continue; // restarts validation loop
                        }
                    }
                    catch
                    {
                        continue; // restarts validation loop
                    }
                }

                // If statement to determine if guess was right
                if (input == number)
                {
                    Console.WriteLine("Congrats! You guessed the right number!");
                    right = true; // set boolean to true to exit loop.
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't the right number... Try again.");
                    valid = false; // reset boolean so that user can reenter validation loop
                    continue; // restarts entire loop
                }
            } while (!right) ;
        }
    }
}