using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_Bankomat
{
    class Ucet : Banka
    {
        string id;
        int balance;
        private Bankomat bankomat;

        public Ucet(string id, int balance, Bankomat bankomat) : base(id, balance)
        {
            this.id = id;
            this.balance = balance;
            this.bankomat = bankomat;
        }

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
