namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guesscount = 20;

            Random random = new Random();
            int randomcislo = random.Next(1, 100);
            Console.WriteLine("Mas " + guesscount + " pokusu");
            while (guesscount > 0)
            {
                Console.WriteLine("Napis tvuj tip");
                int tip = Convert.ToInt32(Console.ReadLine());

                if (tip > randomcislo)
                {
                    Console.WriteLine("Tvuj tip je  velky");
                }
                else if (tip == randomcislo)
                {
                    Console.WriteLine("Tvuj tip je spravny!");
                    break;
                }
                else if (tip < randomcislo)
                {
                    Console.WriteLine("Tvuj tip je maly");
                }
                Console.WriteLine();
                guesscount--;

                if (guesscount == 3)
                {
                    Console.WriteLine("POZOR, MAS UZ JEN 3 POKUSY");
                }

                if (guesscount == 0)
                {
                    Console.WriteLine("Dosli ti pokusy");
                }

            }
            Console.ReadLine();
        }
    }
}