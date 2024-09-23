namespace Birds_6._1P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating birds
            Bird bird1 = new Bird();
            Bird bird2 = new Bird();

            // Setting names
            bird1.name = "Feathers";
            bird2.name = "Holly";

            // Creating penguins
            Penguin penguin1 = new Penguin();
            Penguin penguin2 = new Penguin();

            // Setting names
            penguin1.name = "Happy Feet";
            penguin2.name = "Gloria";

            // Creating ducks
            Duck duck1 = new Duck();
            Duck duck2 = new Duck();

            // Setting properties
            duck1.name = "Daffy";
            duck1.size = 15;
            duck1.kind = "Mallard";

            duck2.name = "Donald";
            duck2.size = 20;
            duck2.kind = "Decoy";

            /*
            // Creating a list of Birds
            List<Bird> birds = new List<Bird>();

            // Adding objects
            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(penguin1);
            birds.Add(penguin2);
            birds.Add(duck1);
            birds.Add(duck2);

            // Printing out each bird
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }
            */

            // Creating a list of Ducks
            List<Duck> ducksToAdd = new List<Duck>()
            {
                duck1,
                duck2,
            };

            // Creating IEnumerable
            IEnumerable<Bird> upcastDucks = ducksToAdd;

            // Creating a list of Birds, again + adding a new bird
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { name = "Feather"});

            // Adding ducks into the list of Birds
            birds.AddRange(upcastDucks);

            // Printing out each bird, again
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}
