using System;
using System.ComponentModel.Design;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)

        {

            const int antalFörsök = 3;
            bool inLoggad = false;
            int menyVal = 0;
            var Custumer1 = new Custumer();
            decimal saldo = 0; // Startsaldo


            inLoggad = LoggaIN(Custumer1, antalFörsök);

            if (inLoggad == false)

            {
                Console.WriteLine("Du har matat in fel pinkod 3 gånger");
                Console.WriteLine("Ditt kort är spärrad");

                return;
            }
           
            
            Console.WriteLine("Välkommen");
            
            
            while (menyVal != 4)
             
            {
              Console.Clear();
              VisaMeny();
              menyVal = int.Parse(Console.ReadLine());
              

                switch (menyVal)

                {
                  case 1:
                  Console.WriteLine("Sätt in penger");
                        decimal insättning = decimal.Parse(Console.ReadLine());
                        saldo += insättning;
                        Console.WriteLine($"Du satte in {insättning} kr. Nytt saldo är {saldo}kr.");
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");

                        Console.ReadKey();

                        break;


                    case 2:
                        Console.WriteLine("Ta ut pengar");
                        decimal uttag = decimal.Parse(Console.ReadLine());

                        if (uttag > 0 && uttag <= saldo)
                        {
                            saldo -= uttag;
                            Console.WriteLine($"Du tog ut {uttag} kr. Nytt saldo är {saldo} kr");
                        }
                        else
                        {
                            Console.WriteLine("Uttaget är ogiltigt – kontrollera beloppet.");
                        }

                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
                        Console.ReadKey();
                        break;
                    
                    case 3:
                        Console.WriteLine($"Ditt saldo är {saldo} kr");
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
                        Console.ReadKey();
                        break;
                    
                    case 4:
                        Console.WriteLine("Avslutar");
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
                        Console.ReadKey();
                        break;
                    
                    default:
                        Console.WriteLine("Ogiltig val");
                        Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
                        Console.ReadKey();
                        break;
                }

                 {
                   Console.WriteLine();
                   

                 }


            }

        }

        

        public static bool LoggaIN(Custumer custumer1, int antalFörsök)
        {
            int valdPin;
            

            for (int i = 1; i <= antalFörsök; i++)
            {
                Console.Write("Ange pinkod ");
                valdPin = int.Parse(Console.ReadLine());

                if (valdPin == custumer1.PinKod)
                {
                    Console.WriteLine("Du är inloggad");
                    return true;

                }
                else
                {

                    Console.WriteLine("Fel pinkod");
                    Console.WriteLine($"Du har {antalFörsök - i} kvar");

                }
            }
            return false;
        }

        static void VisaMeny()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*---------------------*");
            Console.WriteLine("*    BANKOMAT         *");
            Console.WriteLine("*    VÄLKOMMEN        *");
            Console.WriteLine("*---------------------*");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Sätt in pengar");
            Console.WriteLine("2. Ta ut pengar");
            Console.WriteLine("3. Visa saldo");
            Console.WriteLine("4. Avsluta");


        }

    }


}
