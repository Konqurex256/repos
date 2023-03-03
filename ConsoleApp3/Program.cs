using System.Runtime.CompilerServices;

namespace training
{
    internal class Calculator
    {
        static void Main(string[] args)
        {

            bool rep = true;
            do
            {
                Console.WriteLine("Napiš první číslo");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Napiš druhé číslo");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sčítání: " + (num1 + num2));
                Console.WriteLine("Odčítání: " + (num1 - num2));
                Console.WriteLine("Násobení: " + Math.Round((num1 * num2)), 2);
                Console.WriteLine("Dělení: " + Math.Round((num1 / num2), 2));
                Console.WriteLine("Druhá mocnina prvního čísla: " + Math.Round((num1 * num1)), 2);
                Console.WriteLine("Druhá mocnina druhého čísla: " + Math.Round((num2 * num2)), 2);
                Console.WriteLine("Druhá odmocnina prvního čísla: " + Math.Round((Math.Sqrt(num1)), 2));
                Console.WriteLine("Druhá odmocnina druhého čísla: " + Math.Round((Math.Sqrt(num2)), 2));
                Console.WriteLine("Třetí mocnina prvního čísla: " + Math.Round((num1 * num1 * num1)), 2);
                Console.WriteLine("Třetí mocnina druhého čísla: " + Math.Round((num2 * num2 * num2), 2));
                Console.WriteLine("Třetí odmocnina prvního čísla: " + Math.Round((Math.Cbrt(num1)), 2));
                Console.WriteLine("Třetí odmocnina druhého čísla: " + Math.Round((Math.Cbrt(num2)), 2));
                Console.WriteLine();

                Console.WriteLine("Přejete si počítat znovu?");
                Console.WriteLine("y/n");
                if (Console.ReadLine() == "y")
                {
                    rep = true;
                    Console.Clear();
                }
                else break;

            } while (rep == true);

        }
    }
}