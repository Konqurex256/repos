namespace procvicovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = new int[4];

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write("napis 4 cisla: ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out ints[i]));

            //}
            //Console.Clear();

            //string cislice = string.Join(", ", ints);
            //Console.WriteLine(cislice);


            int[] ints = new int[4];
            int n = 4;
            for (int i = 0; i < ints.Length; i++)
            {
                do
                {
                    Console.Write($"Napis ještě {n} čísla: ");
                }
                while (!int.TryParse(Console.ReadLine(), out ints[i]));

                n--;
            }

            string vysledek = string.Join(", ", ints);
            Console.WriteLine(vysledek);
        }
    }
}