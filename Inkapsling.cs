

namespace De_fyra_OOP_principerna
{

    public class BankAccount
    {
        // här ska jag skapa en klass BankAccount med private fält balance

        private decimal balance;

        // här ska vi ha metoder för Deposit och Withdraw som uppdaterar balance på ett säkert sätt

        // här ska vi ha metod för att sätta in pengar på kontot och penagar ska inte kunna sättas in om beloppet är negativt

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Insättning på {amount} kr. Nytt saldo: {balance} kr.");
            }
            else
            {
                Console.WriteLine("Insättningsbelopp måste vara större än 0.");
            }
        }

        // här ska vi ha metod för att ta ut pengar från kontot och pengar ska inte kunna tas ut om beloppet är större än saldot
        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Uttag på {amount} kr. Nytt saldo: {balance} kr.");
            }
            // om beloppet är större än saldot ska vi skriva ut ett felmeddelande
            else if (amount > balance)
            {
                Console.WriteLine("Uttagsbeloppet överstiger saldot.");
            }

        }

        // här ska vi ha metod för att kolla saldot på kontot
        public decimal getbalance(decimal amount)
        {
            return balance;
        }








    }
}
