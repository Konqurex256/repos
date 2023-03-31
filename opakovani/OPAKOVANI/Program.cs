namespace OPAKOVANI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region zaklady

            Console.WriteLine(); //vypise do konzole s novym radkem
            Console.Write(""); //vypise do konzole bez noveho radkem
            Console.ReadLine(); //precze input
            string s = ""; //promenna vyuzivana na slova
            int i = 0; //promenna vyuzivana na cisla
            bool b = true; //promenna ktzera ma dve hodnoty, bud True nebo False
            double d = 1.1; //int promenna s moznosti pro destine cislo
            Convert.ToInt32 (d); //preveze na int hodnotu
            // && //znamena "a" v podminkach
            // || //znamena "nebo" v podminkach
            // % //modus je specialni operat ktery vraci zbybajici hodnotu z deleni (10%4=2)
            if (d > i) //pokud
            {

            }
            else if (d < i) //nebo pokud
            {

            }
            else //jinak 
            {

            }
            
            do //udelej 
            {

            }
            while (b); //kdyz (prvbe se vykonna a pak zkontroluje podminku)

            while (b) //prvne zkotroluje podminku a popripadne se pak vykona
            {

            }

            for (int ii = 1; ii <= 10; ii++) //while loop na steroidech ; ukazka vypssani cisel od 1 do 10
            {
                Console.WriteLine(ii);
            }

            switch (i) //if else if else na steroidech
            {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    Console.WriteLine(1);
                    break;
            }
            
            Random random = new Random(); 
            int rand = random.Next(1, 10); //int rand prijme nahodnou hodnotu funkce random -> 1 az 10
            Console.WriteLine($"{Math.PI}"); //umozuje psat v cw bez nutnosti + ; Math. funkce
            // .Lenght() //delka daneho slova/stringu od nuly
            // .StartsWith() //vypise cim dane slovo zacina
            // .EndsWith() //vypise cim slovo konci
            // .Contains("") //vypise zda slovo obsahuje dane pismeno/char a vypise True/False
            // .IndexOf("") //vypise na jake pozici se dane pismeno /char nachazi -> od nuly
            // .ToUpper() //slovo -> SLOVO
            // .ToLower() //SLOVO -> slovo
            int[] arr = {1, 2, 3 }; //promenna obsahujici vice hodnot stejneho druhu, ma pevnou delku
            int[,] arr2d = { {1, 2 }, {3, 4 } }; //promenna obsahujici vice hodnot stejneho druhu, ma pevnou delku ale 2d
            List<int> list = new List<int>(); //pole na steroidech, nema pevnou delku


            #endregion
            #region class

            Vytah Joník = new Vytah(12);
        }
    }
    class Vytah
    {
        //konstruktor
        public Vytah(int pp) //vstup do ()
        {
            PocetPater = pp;
        }

        public int AktualniPatro = 0; //verejne pristupny, modifikovany v konstruktoru
        private int PocetPater; //pristupny pouze v class Vytah
        public bool JedNahoru() //metoda vracejici True/False
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

            while (JedNahoru()) { JedNahoru(); }
            return false;

            //if (AktualniPatro != PocetPater)
            //{
            //    for (int i = 0; i < PocetPater; i++)
            //    {
            //        AktualniPatro++;
            //    }
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public bool AzDolu()
        {
            while (JedDolu()) { JedDolu(); }
            return false;

            //if (AktualniPatro != 0)
            //{
            //    for (int i = 0; i < PocetPater; i++)
            //    {
            //        AktualniPatro--;
            //    }
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public override string ToString() //prepise co se stane kdyz cw(Joník)
        {
            return $"jsem vytah a jezdim mezi patry 0 - {PocetPater}, aktualne jsem v patre {AktualniPatro}";



            #endregion
        }
            #region momentalne



            #endregion
    }
}