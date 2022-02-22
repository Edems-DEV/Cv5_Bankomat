using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_Bankomat
{
    class Bankomat : Banka
    {
        private string id;
        private int balance;

        public Bankomat(string id, int balance) : base(id, balance)
        {
            this.id = id;
            this.balance = balance;
        }
    }
}
