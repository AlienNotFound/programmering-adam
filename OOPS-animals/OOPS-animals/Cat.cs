namespace OOPS_animals
{
    public class Cat : Feline
    {
        string name;

        public override void MakeSound()
        {
            Console.WriteLine("mew");
        }

        public override void Move()
        {
            Console.WriteLine("The cat stalks prey.");
        }
    }
}
