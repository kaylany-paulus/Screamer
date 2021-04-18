using System;

namespace Screamer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numericalFeeling;
            string userName, feeling;
            int numericName;

            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("\nBem vindo ao programa!");
            Console.ResetColor();
            Console.Write("\n\nPor favor me diga seu nome...: ");
            userName= Console.ReadLine();
            bool nameVerification= Int32.TryParse(userName, out numericName );
            if (nameVerification)
            {
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"\nESTA OPÇÃO ({numericName}) NÃO É VÁLIDA."); 
                Console.ResetColor();
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\n\nObrigada pelo acesso!");
                Console.ResetColor();
                Console.ReadKey(); 
                Environment.Exit(-1);
            }
            Console.Write("\nPor favor me diga o que está sentindo da maneira mais profunda possível..: ");
            feeling= Console.ReadLine();
            bool feelingCheck= Int32.TryParse(feeling, out numericalFeeling);
            if (feelingCheck)
            {
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"\nESTA OPÇÃO ({numericName}) NÃO É VÁLIDA."); 
                Console.ResetColor();
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\n\nObrigada pelo acesso!");
                Console.ResetColor();
                Console.ReadKey(); 
                Environment.Exit(-1);
            }
            Console.Clear();
            Console.WriteLine($"\n{feeling.ToUpper()}");
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"\n\n{userName.ToUpper()}PORQUE VOCÊ ESTÁ GRITANDO COMIGO, EU NÃO SOU SURDA!!!!");
            Console.ResetColor();
            Console.WriteLine("\nViu! Eu também sei gritar.");

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\n\nObrigada pelo acesso!");
            Console.ResetColor();

        }
    }
}
