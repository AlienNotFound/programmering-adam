namespace OOPS_animals
{
    public class Cat : Feline
    {
        string name;

        override public void MakeSound()
        {
            Console.WriteLine("mew");
        }
    }
}
