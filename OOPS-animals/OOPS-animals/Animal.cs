namespace OOPS_animals
{
    public class Animal
    {
        public int numLegs;
        public string foodType;
        public string race;
        public decimal weight;
        public string color;

        public virtual void Move()
        {
            Console.WriteLine("The {0} moved, with it's {1} leg(s)!", race, numLegs);
        }

        public void Eat()
        {
            Console.WriteLine("The {0} is a {1}", race, foodType);
        }

        public void Size()
        {
            Console.WriteLine("It weighs about {0}kg!", weight);
        }
    }
}
