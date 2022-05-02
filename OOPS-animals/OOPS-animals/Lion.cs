namespace OOPS_animals;

public class Lion : Feline
{
    public override void MakeSound()
    {
        Console.WriteLine("Medium roar");
    }

    public override void Move()
    {
        Console.WriteLine("The lion does not move and sleeps pretty much all day.");
    }
}