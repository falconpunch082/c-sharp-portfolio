namespace Animals_6._2P
{
    public class TestAnimal
    {
        public static void Main(String[] args)
        {
            // Using the subclasses
            Cat cat1 = new Cat();
            cat1.Greeting();  // Fixed method name
            Dog dog1 = new Dog();
            dog1.Greeting();  // Fixed method name
            BigDog bigDog1 = new BigDog();
            bigDog1.Greeting();  // Fixed method name

            // Using Polymorphism
            Animal animal1 = new Cat();
            animal1.Greeting();  // Fixed method name
            Animal animal2 = new Dog();
            animal2.Greeting();  // Fixed method name
            Animal animal3 = new BigDog();
            animal3.Greeting();  // Fixed method name
            // Animal animal4 = new Animal(); // Cannot instantiate abstract class

            /* ^^^^^^^^
             * These lines demonstrate polymorphism because animal1, animal2, and animal3 
             * are all of type Animal, but they execute the overridden Greeting methods 
             * of their respective actual types.
             */

            // Downcast
            Dog dog2 = (Dog)animal2;
            BigDog bigDog2 = (BigDog)animal3;
            Dog dog3 = (Dog)animal3;
            // Cat cat2 = (Cat)animal2;  // Invalid cast, commented out
            dog2.Greeting(dog3);
            dog3.Greeting(dog2);
            dog2.Greeting(bigDog2);
            bigDog2.Greeting(dog2);
            bigDog2.Greeting(bigDog1);
        }
    }
}
