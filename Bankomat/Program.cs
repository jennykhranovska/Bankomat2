namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)

        {

            const int antalFörsök = 3;
            bool inLoggad = false;

            var Custumer1 = new Custumer();

            inLoggad = LoggaIN(Custumer1, antalFörsök);

            if (inLoggad == false)

            {
                Console.WriteLine("Du har matat in fel pinkod 3 gånger");
                Console.WriteLine("Ditt kort är spärrad");

                return;

            }

            Console.WriteLine("Välkommen");
            VisaMeny();
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
            Console.Clear();
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
