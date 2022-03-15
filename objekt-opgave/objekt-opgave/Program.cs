class BankAccount
{
    int balance;

    static void Main(string[] args)
    {
        Console.WriteLine("Vælg en handling:");
        Console.WriteLine(">");
        string valg = Console.ReadLine();

        switch (int.Parse(valg))
        {
            case 1:
                Console.WriteLine(valg + " er valgt");
                break;
        }
    }

    static void Withdraw()
    {

    }

    static void Deposit()
    {

    }

    static void TotalBalance()
    {

    }
}