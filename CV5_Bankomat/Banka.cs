using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_Bankomat
{
    class Banka
    {
        private string id;
        private int balance;

        public Banka(string id, int balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public void DoplnHotovost(int addedBalance) => balance += addedBalance;
        public void OdeberHotovost(int removeBalance)
        {
            if (removeBalance < balance)
            {
                balance -= removeBalance;
                Console.WriteLine($"NEW total balance: {balance}");
            }
            else
            {
                ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You don't have enough money to windrow selected amount.");
                Console.ForegroundColor = originalColor;
            }
        }
        public int Report()
        {
            string deviceType = (id.Length == 1) ? "ATM" : "Account"; //limited on - atm always have only one digit
            Console.WriteLine($"{deviceType} with ID: {id} have balance of {balance}$.");
            return balance;
        }
    }
}
