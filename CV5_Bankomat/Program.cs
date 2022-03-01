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

            infoTable();
            while (on)
            {
                Console.Write("Action: ");
                string input = Console.ReadLine();
                input = input.ToLower(); //regex by byl lepsi
                if (input == "exit" || input == "q" || input == "odejit")
                {
                    on = false;
                    Console.Clear();
                    Console.WriteLine($"Press any key to exit application ...");
                    Console.ReadKey();
                    Environment.Exit(0); //total application kill

                }
                string id;
                int amount;
                Console.Write("ID: "); //loop pro overeni spravnosti ID
                id = Console.ReadLine();
                if (input == "vyber" || input == "vklad")
                {
                    Console.Write("Amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (input == "vyber")
                    {
                        vyberById(id, amount);
                    }
                    else if(input == "vklad")
                    {
                        vkladById(id, amount);
                    }
                }
                else if (input == "report")
                {
                    infoById(id);
                }
                else
                {
                    continue;
                }
                infoShort();
            }





            void infoTable()
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Choose type of action:");
                Console.WriteLine("(vyber) - windrow funds");
                Console.WriteLine("(vklad) - add funds");
                Console.WriteLine("(report) - information about balance");
                Console.WriteLine("--------------------------------------");
            }
            void infoShort()
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("(vyber) (vklad) (report)");
                Console.WriteLine("-------------------------");
            }

            #region Ugly Switches
            void vyberById(string id, int amount)
            {
                switch (id)
                {
                    case "1":
                        w1.OdeberHotovost(amount);
                        break;
                    case "2":
                        w2.OdeberHotovost(amount);
                        break;
                    case "10":
                        a1.VyberHotovosti(amount);
                        break;
                    case "20":
                        a2.VyberHotovosti(amount);
                        break;
                    default:
                        break;
                }
            }
            void vkladById(string id, int amount)
            {
                switch (id)
                {
                    case "1":
                        w1.DoplnHotovost(amount);
                        break;
                    case "2":
                        w2.DoplnHotovost(amount);
                        break;
                    case "10":
                        a1.Vklad(amount);
                        break;
                    case "20":
                        a2.Vklad(amount);
                        break;
                    default:
                        break;
                }
            }
            void infoById(string id)
            {
                switch (id)
                {
                    case "1":
                        w1.Report();
                        break;
                    case "2":
                        w2.Report();
                        break;
                    case "10":
                        a1.Info();
                        break;
                    case "20":
                        a2.Info();
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }
    }
}
