using System;

namespace datatyper
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Opgave 1.1");

            Console.WriteLine("Int typen fylder " + sizeof(int) + " bytes");
            Console.WriteLine("Bool typen fylder " + sizeof(bool) + " bytes");
            Console.WriteLine("Char typen fylder " + sizeof(char) + " bytes");
            Console.WriteLine("Decimal typen fylder " + sizeof(decimal) + " bytes");

            Console.WriteLine("\n--- Opgave 1.2");

            int charVal = char.MaxValue;

            Console.WriteLine("Int typens max værdi er " + int.MaxValue);
            Console.WriteLine("Char typens max er " + charVal);
            Console.WriteLine("Decimal typens max er " + decimal.MaxValue);

            Console.WriteLine("\n--- Opgave 1.3");
            Console.WriteLine("----- Type size diagram");

            Console.Write("Int   ");
            for(int i = 0; i < sizeof(int); i++)
            {
                Console.Write("-");
            }

            Console.Write("\nChar  ");
            for (int i = 0; i < sizeof(char); i++)
            {
                Console.Write("-");
            }

            Console.Write("\nFloat ");
            for (int i = 0; i < sizeof(float); i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n\n--- Opgave 1.4");
            unsafe
            {
                int number = 78;
                int* pointerToNumber = &number;
                Console.WriteLine($"Int værdi: {number}");
                Console.WriteLine($"Værdiens Hex adresse: {(long)pointerToNumber:X}");
            }
        }
    }
}


