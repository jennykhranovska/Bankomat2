namespace Bankomat
{
    internal class BankKonto
    {
        private decimal saldo;  // Bara ett fält för saldo

        // Publik egenskap som bara läser saldo
        public decimal Balance
        {
            get { return saldo; }
        }

        // Metod för att sätta in pengar
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                saldo += amount;
            }
            else
            {
                Console.WriteLine("Beloppet måste vara positivt.");
            }
        }

        // Metod för att ta ut pengar
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Beloppet måste vara positivt.");
                return false;
            }
            if (amount > saldo)
            {
                Console.WriteLine("Otillräckligt saldo.");
                return false;
            }

            saldo -= amount;
            return true;
        }
    }
}
