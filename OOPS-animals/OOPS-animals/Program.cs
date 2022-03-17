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
            c.Move();
        }

        public static void Main(string[] args)
        {
            new Program().AnimalsInfo();
            
        }
    }
}
