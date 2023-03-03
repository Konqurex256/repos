namespace vyznemaneni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int I = 0;
            int II = 0;
            int III = 0;
            int IV = 0;
            int V = 0;
            int znamka = 0;


            for (int i = 0; i <= 14; i++)
            {
                Console.Write("znamka: ");
                int.TryParse(Console.ReadLine(), out znamka);
                switch (znamka)
                {
                    case 1:
                        I++;
                        break;
                    case 2:
                        II++;
                        break;
                    case 3:
                        III++;
                        break;
                    case 4:
                        IV++;
                        break;
                    case 5:
                        V++;
                        break;
                }
            }
            int ctp = III + IV + V;
            if (I > II && ctp == 0)
            {
                Console.WriteLine("vyznamenani");
            }
            else
            {
                Console.WriteLine("bez vyznamenani");
            }
        }
    }
}