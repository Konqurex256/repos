using System.Threading.Channels;
using System.Xml;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region prestupny rok
            /*
            int rok = 0;
            do
            {
                Console.Clear();
                Console.Write("zadej rok: ");
            }
            while (!int.TryParse(Console.ReadLine(), out rok)) ;
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {
                Console.WriteLine("je prestupny");
            }
            else
            {
                Console.WriteLine("neni prestupny");
            }
            */
            #endregion
            #region cisla51020
            /*
            int cislo = 0;
            do
            {
                Console.Write("zadej číslo: ");
            }
            while (!int.TryParse(Console.ReadLine(), out cislo));

            Console.Clear();

            switch (cislo)
            {
                case 5:
                    Console.WriteLine("číslo je 5");
                    break;
                case 10:
                    Console.WriteLine("číslo je 10");
                    break;
                case 20:
                    Console.WriteLine("číslo je 20");
                    break;
                default:
                    Console.WriteLine("číslo je jiné");
                    break;
            }
            */
            #endregion
            #region znamky
            /*
            int cislo = 0;
            do
            {
                do
                {
                    Console.Write("zadej počet bodů: ");
                }
                while (!int.TryParse(Console.ReadLine(), out cislo));

            }
            while (cislo > 10);

            Console.Clear();

            switch (cislo)
            {
                case 10:
                case 9:
                    Console.WriteLine(1);
                    break;
                case 8:
                    Console.WriteLine(2);
                    break;
                case 7:
                case 6:
                    Console.WriteLine(3);
                    break;
                case 5:
                    Console.WriteLine(4);
                    break;
                default:
                    Console.WriteLine(5);
                    break;
            }
            */
            #endregion
            #region idkslovo
            /*
            while (true)
            {
                Console.WriteLine("napis slovo");
                string slovo = Console.ReadLine();
                if (slovo.StartsWith("prvni") && slovo.EndsWith("druhe"))
                {
                    Console.WriteLine("správné slovo");
                    break;
                }
                else
                {
                    Console.WriteLine("špatné slovo");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region clanek trim
            /*
            char[] znaky = new char[4] { '?', ',', '.', '!' };
            Console.Write("článek: ");
            string clanek = Console.ReadLine();
            clanek = clanek.Trim(znaky);
            Console.WriteLine(clanek + "?");
            */
            #endregion
            #region tolower
            /*
            Console.WriteLine("napiš dvě slova");
            Console.Write("první: ");
            string jedna = Console.ReadLine();
            Console.Write("druhá: ");
            string dva = Console.ReadLine();
            Console.WriteLine(jedna.ToLower());
            Console.WriteLine(dva.ToUpper());
            */
            #endregion
            #region contains
            /*
            do
            {
                Console.Write("napiš slovo:");
                string slovo = Console.ReadLine();
                if (slovo.Contains("mama"))
                {
                    Console.WriteLine("obsahuje \"mama\"");
                    Console.WriteLine("je tlustá");
                    break;
                }
                else
                {
                    Console.WriteLine("neobsahuje \"mama\"");
                }
                Console.WriteLine();

            } while (true);
            */
            #endregion
            #region mail
            /*
            Console.Write("napiš mail:");
            string slovo = Console.ReadLine();
            if (slovo.Contains('@') && slovo.Contains('.'))
            {
                Console.WriteLine("vaĺid email");
            }
            else
            {
                Console.WriteLine("invalid email");
            }
            */
            #endregion
            #region index of
            /*
            Console.Write("napis slovo: ");
            string slovo = Console.ReadLine();
            if (slovo.Contains('a'))
            {
                Console.WriteLine(slovo.IndexOf('o'));
            }
            else
            {
                Console.WriteLine("neobsahuje \"a\"");
            }
            */
            #endregion
            #region for arr
            /*

            int[] ints = new int[6] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

            */
            #endregion
            #region foreach
            /*

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            */
            #endregion
            #region tvoje mama je tlusta
            /*

            string[] slova = { "tvoje", "mama", "je", "tlusta" };
            foreach (string s in slova)
            {
                Console.WriteLine(s);
            }

            */
            #endregion
            #region for arr
            /*

            int[] ints = { 1, 2, 3, 4 };

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

            */
            #endregion
            #region split
            /*

            Console.Write("napis slova: ");
            string slovo = Console.ReadLine();

            string[] s = slovo.Split(" ");
            Console.WriteLine(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"{i + 1} => ");
            }
            
            */
            #endregion
            #region join
            /*

            int[] ints = new int[4];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            string cislice = string.Join(", ", ints);
            Console.WriteLine(cislice);

            */
            #endregion
            #region list
            /*

            List<int> list = new List<int>();
            Console.WriteLine("napis nekolik cisel, pak napis \"stop\"");
            string imput;
            int cislicko;
            while (true)
            {
                imput = Console.ReadLine();
                if (int.TryParse(imput, out cislicko))
                {
                    list.Add(cislicko);
                }
                if (imput == "stop")
                {
                    break;
                }
            }
            Console.WriteLine("suda cisla: ");
            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine("\nlicha cisla: ");
            foreach (int i in list)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine("\n");

            */
            #endregion
            #region list2
            /*
            List<int> list = new List<int>();
            Console.WriteLine("napis nekolik cisel, pak napis \"stop\"");
            string imput;
            int cislicko;
            while (true)
            {
                imput = Console.ReadLine();
                if (int.TryParse(imput, out cislicko))
                {
                    list.Add(cislicko);
                }
                if (imput == "stop")
                {
                    break;
                }
            }
            list.Sort();
            Console.WriteLine(String.Join(", ", list));
            do
            {
                Console.WriteLine("napis dalsi cislo");
                imput = Console.ReadLine();
            } while (!int.TryParse(imput, out cislicko));
            list.Add(cislicko);
            Console.WriteLine(String.Join(", ", list));
        }
        */
            #endregion
            #region zadani

            //int[] cisla = new int[4];

            //for (int i = 0; i < cisla.Length; i++)
            //{
            //    //dodelat: dowhile/while a tryparse
            //    cisla[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //string spojenaCisla = String.Join(", ", cisla);
            //Console.WriteLine(spojenaCisla);

            #endregion
            #region list
            /*
            int[] ints = new int[4];

            for (int i = 0; i < ints.Length; i++)
            {
                do
                {
                    Console.Write("napis 4 cisla: ");
                }
                while (!int.TryParse(Console.ReadLine(), out ints[i]));

            }
            Console.Clear();

            string cislice = string.Join(", ", ints);
            Console.WriteLine(cislice);
            */
            #endregion
            #region and gate
            /*

            Console.Write("napis prvni bool: ");
            string j = Console.ReadLine();
            bool jedna;
            if (j.ToLower() == "true")
            {
                jedna = true;
            }
            else
            {
                jedna = false;
            }
            Console.Write("napis druhy bool: ");
            string jj = "a";
            jj = Console.ReadLine();
            bool dva;
            if (jj.ToLower() == "true")
            {
                dva = true;
            }
            else
            {
                dva = false;
            }

            Console.WriteLine(And(jedna, dva));
        }

        static bool And(bool uno, bool dos)
        {
            if (uno == dos && (uno || dos) != false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
            #endregion
            #region metody
            /*             

            int[] poleCisel = new int[10];

            for (int i = 0; i < poleCisel.Length; i++)
            {
                poleCisel[i] = nacti();
            }

            Console.Clear();

            int prumer = vypocitejPrumer(poleCisel);

            vypis("prumer tvych cisel je: " + Convert.ToString(prumer));
        }

        static int vypocitejPrumer(int[] pole)
        {
            int soucet = 0;

            foreach (int cislo in pole)
            {
                soucet += cislo;
            }

            int avg = soucet / pole.Length;
            return avg;
        }


        static int nacti()
        {
            Console.WriteLine("zadej cislo");
            int cislo = Convert.ToInt32(Console.ReadLine());
            return cislo;
        }

        static void vypis(string slovo)
        {
            Console.WriteLine(slovo);
        

        */
            #endregion
            #region telcislo
            /*

            Console.WriteLine("zadejte telefonni cislo");
            string tf = Console.ReadLine();
            
            //while (!(delka(tf) && spcx(tf) && prenum(tf)))
            //{
            //    Console.WriteLine("vasr tel. cislo neni spravne, zkus to znovu");
            //    tf = Console.ReadLine();
            //}

            while (true)
            {
                if (!delka(tf))
                {
                    Console.WriteLine("telefonni cislo neni dostatecne dlouhe");
                    break;
                }
                else if (!spcx(tf))
                {
                    Console.WriteLine("telefonni cislo ma spatne napsane mezery");
                    break;
                }
                else if (!prenum(tf))
                {
                    Console.WriteLine("telefonni cislo ma spatne predcisli");
                    break;
                }
                else
                {
                    Console.WriteLine("cislo je ve spravnem formatu");
                    break;
                }
            }
            //Console.WriteLine("cislo je ve spravnem formatu");
        }
        static bool delka(string cislo)
        {
            return cislo.Length == 16;
        }

        static bool spcx(string tf)
        {
            return tf.Substring(4, 1) == " " && tf.Substring(8, 1) == " " && tf.Substring(12, 1) == " ";
        }

        static bool prenum(string tf)
        {
            if (tf.StartsWith("+420"))
            {
                return true;
            }
            return false;

            */
            #endregion
            #region vytah
            /*
            
            Vytah Joník = new Vytah(12);
            for (int i = 0; i < 7; i++)
            {
                Joník.JedNahoru();
            }
            Console.WriteLine(Joník);
        }
    }
    class Vytah
    {
        //konstruktor
        public Vytah(int pp)
        {
            PocetPater = pp;
        }
        
        public int AktualniPatro = 0;
        private int PocetPater;
        public bool JedNahoru()
        {
            if (AktualniPatro >= PocetPater)
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
            if (AktualniPatro != PocetPater)
            {
                for (int i = 0; i < PocetPater; i++)
                {
                    AktualniPatro++;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AzDolu()
        {
            if (AktualniPatro != 0)
            {
                for (int i = 0; i < PocetPater; i++)
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
            return $"jsem vytah a jezdim mezi patry 0 - {PocetPater}, aktualne jsem v patre {AktualniPatro}";
        
        */
            #endregion
            #region zvire
            /*
            
            //Pes Evzen = new Pes("Evzen", 23, "Cerna");
            //Console.WriteLine(Evzen.Jmeno + Evzen.Vek + Evzen.BarvaSrsti);
            //Evzen.OzvySe();
            //Evzen.kousniMichala();

        }
    }

    abstract class Zvire
    {

        public int Vek { get; private set; }
        public string Barva { get; private set; }

        protected Zvire(int vek, string barva)
        {
            Vek = vek;
            Barva = barva;
        }


    }
    abstract class Savec
    {

        private string _zvuk;

        protected Savec(string zvuk)
        {
            _zvuk = zvuk;
        }

        public void OzvySe()
        {
            Console.WriteLine(_zvuk);
        }

    }
    abstract class Ryba
    {
        public string Oblibenejidlo { get; private set; }
        private string _zvuk;

        protected Ryba(string oblibenejidlo, string zvuk) : base()
        {
            Oblibenejidlo = oblibenejidlo;
            _zvuk = zvuk;
        }

        public void OzvySe()
        {
            Console.WriteLine(_zvuk);
        }
        public void Plav()
        {
            Console.WriteLine("plavu");
        }

    }

    class Michal
    {
        public int IQ { get; private set; }

        public Michal(int iQ)
        {
            IQ = iQ;
        }
        public void Mluv()
        {


            */
            #endregion
        }
    }
}
