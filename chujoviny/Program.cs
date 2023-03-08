using System.Security;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region cislicka nebo nevim co to je za shit

            /*
            for (int num = 1; num <= 1000; num++)
            {
                Console.WriteLine(num);
            }

            //=

            int opakovani1 = 0;
            int num1 = 1;
            do
            {
                Console.WriteLine(num1);

                opakovani1++;
                num1++;

            } while (opakovani1 < 1000);

            //=

            bool rep = true;
            int num2 = 1;
            int opakovani2 = 1;
            while (rep == true)
            {
                Console.WriteLine(num2);
                num2++;
                opakovani2++;

                if (num2 == 1001)
                {
                    break;
                }
            }
            
            */

            #endregion
            #region idk

            /*
            first = input("first: ")
            second = input(second: ")
            sum = int(first) + int(second)
            print(sum)

            Console.Write("First: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write(first + second);
            */

            /*
            int m = 0;
            int h = 0;
            for (int s = 1; s >= 0; s++)
            {
                Console.WriteLine(s);
                Thread.Sleep(1000);
                if (s == 60)
                {
                    s = 0;
                    m++;
                    Console.WriteLine($"je {h}:{m}:{s}");
                }
                if (m == 60)
                {
                    m = 0;
                    h++;
                    Console.WriteLine($"je {h}:{m}:{s}");
                }
            */

            #endregion
            #region The Fibonacci sequence

            /*   The Fibonacci sequence

            int num1 = 0;
            int num2 = 1;
            int num3 = 0;
            int repeat = 15;
               while (repeat > 0)
               {
                   num3 = (num1 + num2);
                   Console.WriteLine(num3);
                   num1 = num2;
                   num2 = num3;
                   repeat--;
               }
            //*/

            #endregion
            #region vytah

            int patra = 0;
            do
            {
                Console.Write("AHoj, Já jsem výtah Joník. Zvol mi počet pater: ");
            }
            while (!int.TryParse(Console.ReadLine(), out patra));
            
            Vytah Joník = new Vytah(patra);

            Console.WriteLine("napis tebou zvolenou akci z vyberu: ");
            Console.WriteLine("'jednahoru', 'jeddolu', 'aznahoru', 'azdolu'");
            string vyber = Console.ReadLine();
            vyber = vyber.ToLower();
            bool Swicth = false;
            do
            {
                Console.Clear();
                switch (vyber)
                {

                    case "jednahoru":
                        Joník.JedNahoru();
                        Console.WriteLine(Joník);
                        Swicth = true;
                        break;
                    case "jeddolu":
                        Joník.JedDolu();
                        Console.WriteLine(Joník);
                        Swicth = true;
                        break;
                    case "aznahoru":
                        Joník.AzNahoru();
                        Console.WriteLine(Joník);
                        Swicth = true;
                        break;
                    case "azdolu":
                        Joník.AzDolu();
                        Console.WriteLine(Joník);
                        Swicth = true;
                        break;
                    default:
                        Console.WriteLine("spatne zadana operace, zkus to znovu");
                        vyber = Console.ReadLine();
                        Console.WriteLine();
                        break;
                }
            }
            while (Swicth == false);


            #region 7patro
            //for (int i = 0; i < 7; i++)
            //{
            //    Joník.JedNahoru();
            //}
            //Console.WriteLine(Joník);
            #endregion
        }
    }
    class Vytah
    {
        //konstruktor
        public Vytah(int pp)
        {
            pocetPater = pp;
        }

        public int AktualniPatro = 0;
        private int pocetPater;
        public bool JedNahoru()
        {
            if (AktualniPatro >= pocetPater)
            {
                return false;
            }
            AktualniPatro++;
            return true;
        }

        public bool JedDolu()
        {
            if (AktualniPatro <= 0)
            {
                return false;
            }
            AktualniPatro--;
            return true;
        }

        public bool AzNahoru()
        {
            //if (AktualniPatro != pocetPater)
            //{
            //    for (int i = 0; i < pocetPater; i++)
            //    {
            //        AktualniPatro++;
            //    }
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            while (JedNahoru()) { JedNahoru(); return true; } return false;
        }

        public bool AzDolu()
        {
            if (AktualniPatro != 0)
            {
                for (int i = 0; i < pocetPater; i++)
                {
                    AktualniPatro--;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Jsem výtah Joník a jezdímm mezi patry 0 - {pocetPater}, aktuálně jsem v patře {AktualniPatro}";

            //*/

            #endregion

        }
    }
}