namespace ArrayList_3._1P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares an array of type double with 10 elements
            double[] myArray = new double[10];

            // Assigning the first element of the array
            myArray[0] = 1.0;

            // Assigning the second element of the array
            myArray[1] = 1.1;

            // Assigning the rest of the array
            myArray[2] = 1.2;
            myArray[3] = 1.3;
            myArray[4] = 1.4;
            myArray[5] = 1.5;
            myArray[6] = 1.6;
            myArray[7] = 1.7;
            myArray[8] = 1.8;
            myArray[9] = 1.9;

            // For loop to print out elements in myArray
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The element at index " + i + " in the array is " + myArray[i]);
            }

            // Declares an array of type integer with 10 elements
            int[] mySecondArray = new int[10];

            // For loop to populate mySecondArray
            for (int i = 0;i < 10; i++)
            {
                mySecondArray[i] = i;
            }

            // For loop to print out elements in mySecondArray
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The element at index " + i + " in the array is " + mySecondArray[i]);
            }

            // Adding studentArray
            int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            // Looping through studentArray to grab total
            for (int i = 0; i < studentArray.Length; i++)
            {
                total += studentArray[i];
            }

            // Printing results
            Console.WriteLine("The total marks for the student is: " + total);
            Console.WriteLine("This consists of " + studentArray.Length + " marks.");
            Console.WriteLine("Therefore the average mark is " + (total/studentArray.Length));

            // Creating studentNames array
            String[] studentNames = new String[6];

            // For loop for user input
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine("Please enter name of student no." + (i + 1) + ": ");
                studentNames[i] = Console.ReadLine();
            }

            // Confirming contents
            foreach (String name in studentNames)
            {
                Console.WriteLine(name);
            }

            // Generating array of random integers
            int[] gacha = new int[10];
            Random randNum = new Random();
            for (int i = 0; i < gacha.Length; i++)
            {
                gacha[i] = randNum.Next(0,100);
            }

            // Declaring variables
            // int currentSize = 0; // not used
            int currentLargest, currentSmallest;

            currentLargest = gacha[0];
            currentSmallest = gacha[0];

            // For loop to find the smallest and largest number in gacha
            foreach (int x in gacha)
            {
                Console.WriteLine(x);
                if (x > currentLargest)
                {
                    currentLargest = x;
                }
                else if (x < currentSmallest)
                {
                    currentSmallest = x;
                } else
                {
                    // nothing happens
                }
            }

            Console.WriteLine($"The largest number is {currentLargest}.");
            Console.WriteLine($"The smallest number is {currentSmallest}.");

            // Declaring 2D array
            int[,] my2DArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

            // Printing contents of each array
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Creating list of names
            List<String> myStudentList = new List<string>();

            // Determine how many things to fill the list with
            Random randomValue = new Random();
            int randomNumber = randomValue.Next(1, 12);

            // Filling student list
            Console.WriteLine("You now need to add " + randomNumber + " students to your class list.");
            for (int i = 0; i < randomNumber; i++)
            {
                Console.WriteLine("Please enter name of student no." + (i + 1) + ": ");
                myStudentList.Add(Console.ReadLine());
                Console.WriteLine();
            }

            // Confirming contents
            foreach (String name in myStudentList)
            {
                Console.WriteLine(name);
            }
            
            // Palindrome method
            static bool Palindrome(int[] array)
            {
                if (array.Length < 1) // check if array length is less than 1
                {
                    return false;
                } else // check if palindrome
                {
                    for (int i = 0; i < array.Length / 2; i++)
                    {
                        if (array[i] != array[array.Length - 1 - i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            // Test cases
            int[] array1 = { 1, 2, 2, 1 };
            int[] array2 = { 1, 2, 3, 1, 3, 2, 1 };
            int[] array3 = { 3, 2, 1 };
            int[] array4 = { 4, 5, 6, 7 };
            int[] array5 = { };

            Console.WriteLine(Palindrome(array1));
            Console.WriteLine(Palindrome(array2)); 
            Console.WriteLine(Palindrome(array3));
            Console.WriteLine(Palindrome(array4));
            Console.WriteLine(Palindrome(array5));

            // Merge method
            static List<int> Merge(List<int> list_a, List<int> list_b)
            {
                // Create output list
                List<int> result = new List<int>();
                
                // Function to check if list is sorted
                static bool IsSorted(List<int> list)
                {
                    for (int i = 1; i < list.Count; i++)
                    {
                        if (list[i - 1] > list[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }

                if (IsSorted(list_a) & IsSorted(list_b)) // checks if both lists are sorted
                {
                    // Add numbers in list_a to output list
                    foreach (int x in list_a)
                    {
                        result.Add(x);
                    }

                    // Add numbers in list_b to output list
                    foreach (int x in list_b)
                    {
                        result.Add(x);
                    }

                    // Sort output list to get result
                    result.Sort();

                    return result;
                } else // this only occurs if one or more lists are not sorted
                {
                    return result; // empty list
                }
            }

            // Test cases
            List<int> list1 = new List<int> { 1, 2, 2, 5 };
            List<int> list2 = new List<int> { 1, 3, 4, 5, 7 };
            List<int> list3 = new List<int> { 5, 2, 2, 1 };
            List<int> list4 = new List<int> { };

            foreach (int x in Merge(list1, list2))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (int x in Merge(list1, list4))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (int x in Merge(list2, list3))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            // ArrayConversion method
            static int[] ArrayConversion(int[,] array)
            {
                List<int> oddValues = new List<int>(); // use a list for output because you cannot predict how many numbers

                for (int i = 0; i < array.GetLength(1); i++) // For each column...
                {
                    for (int j = 0; j < array.GetLength(0); j++) // For each row...
                    {
                        if (array[j, i] % 2 != 0) // If number is indivisble by 2 it is odd
                        {
                            oddValues.Add(array[j, i]); // Add to list
                        }
                    }
                }

                return oddValues.ToArray(); // return list as array
            }

            // Test case
            int[,] array = {{ 0, 2, 4, 0, 9, 5 }, { 7, 1, 3, 3, 2, 1 }, { 1, 3, 9, 8, 5, 6 }, { 4, 6, 7, 9, 1, 0 }};

            int[] result = ArrayConversion(array);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
