using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV5_Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool on = true;
            Bankomat w1 = new Bankomat("1", 100000);
            Bankomat w2 = new Bankomat("2", 30000);
            Ucet a1 = new Ucet("10", 4000, w1);
            Ucet a2 = new Ucet("20", 8000, w2);

            while (on)
            {
                string input = Console.ReadLine();
                string id;
                switch (input)
                {
                    case "vyber":
                        Console.Write("ID: ");
                        id = Console.ReadLine();
                        //object ucet = SelectById(id); //nevim jak implementovat
                        //ucet.Vybrat(input);
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }

            object SelectById(string id)
            {
                return w1;
            }
        }
    }
}
