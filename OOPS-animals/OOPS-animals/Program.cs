using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_animals
{
    internal class Program
    {
        private static Animal a;
        private static Animal b;
        private static Animal c;
        private Cat myCat;

        public void AnimalsInfo()
        {
            Console.WriteLine("\t--//  Welcome to EverGreen Zoo  //--");
            Console.WriteLine("\tWhere would you like to go?");
            Console.WriteLine("\t1. Felines\t\t2. Canines");
            Console.WriteLine();
            Console.Write(">");
            string choice = Console.ReadLine();

            switch (int.Parse(choice))
            {
                case 1: Console.WriteLine("You're visiting the felines");
                    break;
                case 2: Console.WriteLine("You're visiting the canines");
                    break;
            }
            
            /*Animal[] animals = new Animal[3];

            animals[0] = new Cat();
            animals[1] = new Dog();
            animals[2] = new Lion();

            foreach (Animal ani in animals)
            {
                ani.Move();
            }
            
            Console.WriteLine("\n----------\n\n");
            
            myCat = new Cat();
            myCat.numLegs = 4;
            myCat.MakeSound();

            Tiger myTiger = new Tiger();
            myTiger.MakeSound();

            Lion myLion = new Lion();
            myLion.MakeSound();

            a = new Animal();
            a.race = "possum";
            a.numLegs = 10;
            a.Move();

            b = new Animal();
            b.race = "crane";
            b.numLegs = 2;
            b.Move();

            c = new Animal();
            c.race = "rat";
            c.numLegs = 30000;
            c.Move();*/
        }

        public static void Main(string[] args)
        {
            new Program().AnimalsInfo();
            
        }
    }
}
