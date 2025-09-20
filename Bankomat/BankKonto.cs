using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class BankKonto


    {
        private decimal saldo;

        public decimal Balanc
        { get; set; }


        public void Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                saldo += amount;
            }
            else
            {

            }

        }
        //Metoden ska vara public, ta emot ett decimal amount.  Kontrollera Är amount positivt?
        //Finns tillräckligt saldo. Om allt är okej: minska saldot. Du kan välja att: Visa meddelande eller
        //Returnera true/false om uttaget lyckades.


        public bool Withdraw(decimal amount)
        {
            if (amount >= 0)
            {
                if (amount <= saldo)
                {
                    saldo -= amount;
                    return true;
                }
                else
                {
                    return false; // För lite pengar
                }
            }
            else
            {
                return false; // Beloppet är negativt
            }
        }

    }
}



