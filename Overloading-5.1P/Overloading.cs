namespace Overloading_5._1P
{
    class Overloading
    {
        public static void methodToBeOverloaded(String name)
        {
            Console.WriteLine("Name: " + name);
        }

        public static void methodToBeOverloaded(String name, int age)
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }

        static void Main(string[] args)
        {
            methodToBeOverloaded("Bro");

            methodToBeOverloaded("Brother", 10); // differing inputs based on parameters provided
        }
    }
}
