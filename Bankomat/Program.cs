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
            
          

           
  
            
            return false;
        }

    }


}
