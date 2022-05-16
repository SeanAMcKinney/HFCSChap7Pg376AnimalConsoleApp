using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCSChap7Pg376AnimalConsoleApp
{
    abstract class Animal
    {
        public abstract void MakeNoise();
    }//end class

    class Hippo : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Grunt");
        }

        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim!");
        }

    }//end class

    abstract class Canine : Animal
    {
        public bool BelongsToPack { get; protected set; } = false;
    }//end class

    class Wolf : Canine
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNoise()
        {
            if (BelongsToPack)
            {
                Console.WriteLine("I'm in a pack.");
                Console.WriteLine("Aroooooo!");
            }
        }

        public void HuntInPack()
        {
            if (BelongsToPack)
            {
                Console.WriteLine("I'm going hunting with my pack!");
            }
            else
            {
                Console.WriteLine("I'm not in a pack.");
            }
        }
    }//end class


    class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals =
            {
                new Wolf(false),
                new Hippo(),
                new Wolf(true),
                new Wolf(false),
                new Hippo()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeNoise();
                if (animal is Hippo hippo)
                {
                    hippo.Swim();
                }

                if (animal is Wolf wolf)
                {
                    wolf.HuntInPack();
                }

                Console.WriteLine();
            }

        }//end main
    }//end class
}//end namespace
