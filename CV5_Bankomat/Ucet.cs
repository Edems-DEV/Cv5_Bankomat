using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_Bankomat
{
    class Ucet
    {
        string id;
        int balance;
        private Bankomat bankomat;

        public Ucet(string id, int balance, Bankomat bankomat)
        {
            this.id = id;
            this.balance = balance;
            this.bankomat = bankomat;
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
            Console.WriteLine($"ATM with ID: {id} have balance of {balance}$.");
            return balance;
        }

        //potrba odebrat i z bankomatu (odebiram pouze z uctu)
        public void Vklad(int addedBalance) {
            DoplnHotovost(addedBalance);
            //bankomat.DoplnHotovost(addedBalance);
        }
        public void VyberHotovosti(int removeBalance) {
            OdeberHotovost(removeBalance);
            bankomat.OdeberHotovost(removeBalance);
        }
        public int Info() => Report();
    }
}
