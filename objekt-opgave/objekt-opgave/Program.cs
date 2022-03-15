using System;
class BankAccount
{
    static int balance;
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        bool restart = true;
        while (restart)
        {
            Console.WriteLine("Vælg en handling:");
            Console.WriteLine("1. Hæv penge");
            Console.WriteLine("2. Indsæt penge");
            Console.Write(">");
            string valg = Console.ReadLine();

            switch (int.Parse(valg))
            {
                case 1:
                    Withdraw();
                    break;
                case 2:
                    Deposit();
                    break;
            }
        }
    }

    static void Withdraw()
    {
        Console.WriteLine("Indstast det ønskede beløb, der skal hæves fra kontoen:");
        Console.Write(">");
        int beloeb = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPengene blev hævet!\nNy saldo: " + (balance - beloeb + "\n"));
        balance -= beloeb;
    }

    static void Deposit()
    {
        Console.WriteLine("Indstast det ønskede beløb, der skal indsættes på kontoen:");
        Console.Write(">");
        int beloeb = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPengene blev overført!\nNy saldo: " + (balance + beloeb + "\n"));
        balance += beloeb;
    }

    static void TotalBalance()
    {

    }
}