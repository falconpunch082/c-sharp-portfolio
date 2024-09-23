using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds_6._1P
{
    // Parent bird class
    class Bird
    {
        public string name {  get; set; }

        public Bird()
        {

        }

        public virtual void fly()
        {
            Console.WriteLine("Flap, flap, flap");
        }

        public override string ToString()
        {
            return "A bird called " + name;
        }
    }

    class Penguin : Bird
    {
        public override void fly()
        {
            Console.WriteLine("Penguins cannot fly.");
        }

        public override string ToString()
        {
            return "A penguin named " + base.name;
        }
    }

    class Duck : Bird
    {
        public double size { get; set; }
        public string kind { get; set; }

        public override string ToString()
        {
            return "A duck named " + base.name + " is a " + size + " inch " + kind;
        }
    }
}
