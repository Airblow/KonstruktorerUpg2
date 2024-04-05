using System;
using System.Security.Cryptography;

namespace KonstruktorerUpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Namn p1 = new Namn();

            bool failsafe = false;

            while (failsafe != true)
            {
                try
                {
                    Console.WriteLine("Vad är ditt förnman?");
                    p1.NamnFörnamn = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Vad är ditt efternamn?");
                    p1.NamnEfternamn = Console.ReadLine();
                    Console.Clear();

                    p1.NamnOutput(p1.NamnFörnamn, p1.NamnEfternamn);
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök igen.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.ReadKey();

        }
        
    }

}
