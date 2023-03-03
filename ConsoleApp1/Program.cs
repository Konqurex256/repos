namespace Kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej 1. číslo:");
            double cislo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej 2. číslo:");
            double cislo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej početní situaci (+ - * /)");
            string pocetniSituace = Console.ReadLine();

            double vysledekScitani = cislo1 + cislo2;
            double vysledekOdcitani = cislo1 - cislo2;
            double vysledekNasobeni = cislo1 * cislo2;
            double vysledekDeleni = cislo1 / cislo2;

            if (pocetniSituace == "+")
            {
                Console.WriteLine(vysledekScitani);
            }
            if (pocetniSituace == "-")
            {
                Console.WriteLine(vysledekOdcitani);
            }
            if (pocetniSituace == "*")
            {
                Console.WriteLine(vysledekNasobeni);
            }
            if (pocetniSituace == "/")
            {
                Console.WriteLine(vysledekDeleni);
            }

        }
    }
}