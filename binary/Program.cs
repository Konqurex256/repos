namespace binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = "";
            //int cislo = 0;
            //List<int> binary = new List<int>();
            //do
            //{
            //    Console.Write("napis cislo: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out cislo));
            //Console.Clear();
            //while (true)
            //{
            //    if (cislo % 2 == 0)
            //    {
            //        cislo = cislo / 2;
            //        binary.Add(0);
            //    }
            //    else if (cislo % 2 == 1)
            //    {
            //        cislo = cislo - 1;
            //        binary.Add(1);
            //    }
            //    if (cislo == 1 && cislo == 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(binary);
            int value = 13;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
        }
    }
}