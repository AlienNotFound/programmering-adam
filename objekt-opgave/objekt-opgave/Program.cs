using System;
class BankAccount
{
    private static double balance;
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        bool restart = true;
        while (restart)
        {
            Console.WriteLine("Vælg en handling:");
            Console.WriteLine("1. Hæv penge");
            Console.WriteLine("2. Indsæt penge");
            Console.WriteLine("3. Vis balance på konto");
            Console.Write(">");
            string valg = Console.ReadLine();

            if (valg == "" || !int.TryParse(valg, out int number))
            {
                Console.WriteLine("Stop being an idiot\n");
            } else
            {
                switch (int.Parse(valg))
                {
                    case 1:
                        Withdraw();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        TotalBalance();
                        break;
                    default:
                        Console.WriteLine("Stop being an idiot\n");
                        break;
                }
            }            
        }
    }

    static void Withdraw()
    {
        Console.WriteLine("Indstast det ønskede beløb, der skal hæves fra kontoen:");
        Console.Write(">");
        double beloeb = double.Parse(Console.ReadLine());
        if((balance - beloeb) < 0)
        {
            Console.WriteLine("Du kan ikke trække over på denne konto!\n");
        }
        else
        {
            Console.WriteLine("\nPengene blev hævet!\nNy saldo: " + (balance - beloeb + "\n"));
            balance -= beloeb;
        }
    }

    static void Deposit()
    {
        Console.WriteLine("Indstast det ønskede beløb, der skal indsættes på kontoen:");
        Console.Write(">");
        double beloeb = double.Parse(Console.ReadLine());
        Console.WriteLine("\nPengene blev overført!\nNy saldo: " + (balance + beloeb + "\n"));
        balance += beloeb;
    }

    static void TotalBalance()
    {
        Console.WriteLine("Den nuværende balance på kontoen er: " + balance + "\n");
    }
}