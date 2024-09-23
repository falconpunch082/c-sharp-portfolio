using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_5._1P
{
    // Base animal class
    class AnimalWithInheritance
    {
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String colour;

        public AnimalWithInheritance(String name, String diet, String location, double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        public virtual void eat()
        {
            Console.WriteLine("An animal eats");
        }

        public void sleep()
        {
            // Code for the animal to sleep
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("An animal makes a noise");
        }

        public virtual void hunt()
        {
            Console.WriteLine("An animal hunts");
        }

    }

    // Feline child class
    class Feline : AnimalWithInheritance
    {
        // Feline special variable
        private String species;

        // Constructor
        public Feline(String name, String diet, String location, double weight, int age, String colour, String species) : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }
    }

    // Bird child class
    class Bird : AnimalWithInheritance
    {
        // Bird special variables
        private String species;
        private double wingSpan;

        // Constructor
        public Bird(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.wingSpan = wingSpan;
        }
        
        // Bird special method
        public virtual void fly()
        {
            Console.WriteLine("A bird flies.");
        }
    }

    // Different types of animals
    class Tiger : Feline
    {
        // Tiger special variables
        private String colourStripes;

        // Constructor
        public Tiger(String name, String diet, String location, double weight, int age, String colour, String species, String colourStripes) : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

        // Tiger special methods
        public override void makeNoise()
        {
            Console.WriteLine("ROARRRRRRRRR");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 20lbs of meat");
        }

        public override void hunt()
        {
            Console.WriteLine("I pounce on my prey by my own.");
        }
    }

    class Lion : Feline
    {
        // Constructor
        public Lion(String name, String diet, String location, double weight, int age, String colour, String species) : base(name, diet, location, weight, age, colour, species)
        {

        }
    }

    class Wolf : AnimalWithInheritance
    {
        // Constructor
        public Wolf(String name, String diet, String location, double weight, int age, String colour) : base(name, diet, location, weight, age, colour)
        {

        }

        // Wolf special methods
        public override void makeNoise()
        {
            Console.WriteLine("AWOOOOOOOOOO");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 10lbs of meat");
        }

        public override void hunt()
        {
            Console.WriteLine("I lurk with my pack and then catch my prey together.");
        }
    }

    class Eagle : Bird
    {

        // Constructor
        public Eagle(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) : base(name, diet, location, weight, age, colour, species, wingSpan)
        {
            
        }

        // Eagle special methods
        public void layEgg()
        {
            // Code to allow eagles to lay eggs
        }

        public override void makeNoise()
        {
            Console.WriteLine("CAWWWWWWWWWW");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 1lb of fish");
        }

        public override void hunt()
        {
            Console.WriteLine("I swoop on my prey.");
        }

        public override void fly()
        {
            Console.WriteLine("I fly with grace.");
        }
    }

    class Penguin : Bird
    {
        // Constructor
        public Penguin(String name, String diet, String location, double weight, int age, String colour, String species, double wingSpan) : base(name, diet, location, weight, age, colour, species, wingSpan)
        {

        }

        // Penguin special methods
        public override void fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
