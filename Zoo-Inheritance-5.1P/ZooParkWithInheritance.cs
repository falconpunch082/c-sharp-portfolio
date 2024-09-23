namespace Zoo_5._1P
{
    class ZooParkWithInheritance
    {
        static void Main(string[] args)
        {
            // Creating animals
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);
            Lion lindaLion = new Lion("Linda the Lion", "Meat", "Cat Land", 80, 6, "Orange", "Barbary");
            Penguin pennyPenguin = new Penguin("Penny the Penguin", "Fish", "Chilly Camp", 30, 2, "White", "Adelie", 20);
            AnimalWithInheritance baseAnimal = new AnimalWithInheritance("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");

            // Making noises
            baseAnimal.makeNoise();
            tonyTiger.makeNoise();

            // Eating
            tonyTiger.eat();
            baseAnimal.eat();
            williamWolf.eat();

            // Hunting
            tonyTiger.hunt();
            baseAnimal.hunt();
            edgarEagle.hunt();

            // Sleep
            baseAnimal.sleep();
            tonyTiger.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();
            tonyTiger.eat();

            // Fly
            edgarEagle.fly();
            pennyPenguin.fly();
        }
    }
}
