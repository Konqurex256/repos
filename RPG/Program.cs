using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;

namespace GoblinAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region kecy okolo
            Console.WriteLine("Ahoj, vítej v mé hře, toto je klasické RPG, jménem Goblin Advanture\n");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.WriteLine(".\n");

            Console.WriteLine($"Ahoj, vítej v Goblin Adventure!\n");
            Thread.Sleep(1000);

            Console.WriteLine("Pro začátek ti řeknu jak se tato hra hraje\n");
            Thread.Sleep(500);
            Console.WriteLine("útok - ATTACK\nvyléčení - HEAL\n");
            Thread.Sleep(500);
            Console.WriteLine("Prozatím tato hra bude mít 5 levelů (to je hodně na konzolovou aplikaci:>)");
            Console.WriteLine("Tak jdeme na to ne? :D\n\n");
            Thread.Sleep(500);
            Console.Clear();
            #endregion
            int pzivoty = 50;
            Console.WriteLine("-LEVEL 1-");
            Console.WriteLine("\"Šlimák\"");
            
            Enemy Šlimák = new Enemy(100, 10, 15, "Šlimák"); //hp_boss prichozi_dmg odchozi_dmg name
            php = 100;
            Šlimák.start();

            #region for
            //for (int zivoty = 200; zivoty >= 0;)
            //{
            //    Random random = new Random();
            //    int PD = random.Next(1, 10);
            //    string akce = "";

            //    Console.Write("Akce: ");

            //    akce = Console.ReadLine();


            //    switch (akce)
            //    {
            //        case "attack":
            //            Console.WriteLine("-40 životů");
            //            zivoty = (zivoty - 40);
            //            if (zivoty > 0)
            //            {
            //                Console.WriteLine(zivoty);
            //            }
            //            else if (zivoty < 0)
            //            {
            //                break;
            //            }

            //            Thread.Sleep(500);
            //            break;
            //        case "heal":
            //            Console.WriteLine("+10 hp");
            //            health = (health + 10);
            //            Console.WriteLine(health);
            //            Thread.Sleep(500);
            //            break;
            //        default:
            //            Console.Write("neplatná akce\n\n");
            //            break;

            //    }

            //    switch (PD)
            //    {
            //        case 4:
            //        case 6:
            //        case 10:
            //            health = health - 20;
            //            Console.WriteLine($"Oh ne, dostal si damage, ted mas {health}hp");
            //            break;
            //        case 0:
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 9:
            //            break;
            //        default:
            //            break;
            //    }

            //}
            #endregion

            Console.WriteLine();
            Console.WriteLine("\nHurá, porazil jsi Šlimáka!\n");
            Console.WriteLine("-LEVEL 2-");
            Console.WriteLine("\"Petr\"");
            Console.WriteLine("damage + 10");
            Console.WriteLine("heal + 5");

            Enemy Petr = new Enemy(300, 15, 25, "Petr"); //hp_boss prichozi_dmg odchozi_dmg name
            Šlimák.start();

            #region for
            //for (int zivoty = 500; zivoty >= 0;)
            //{
            //    Random random = new Random();
            //    int PD = random.Next(1, 10);
            //    string akce = "";

            //    Console.Write("Akce: ");

            //    akce = Console.ReadLine();


            //    switch (akce)
            //    {
            //        case "attack":
            //            Console.WriteLine("-40 životů");
            //            zivoty = (zivoty - 40);
            //            if (zivoty > 0)
            //            {
            //                Console.WriteLine(zivoty);
            //            }
            //            else if (zivoty < 0)
            //            {
            //                break;
            //            }

            //            Thread.Sleep(500);
            //            break;
            //        case "heal":
            //            Console.WriteLine("+10 hp");
            //            health = (health + 10);
            //            Console.WriteLine(health);
            //            Thread.Sleep(500);
            //            break;
            //        default:
            //            Console.Write("neplatná akce\n\n");
            //            break;

            //    }

            //    switch (PD)
            //    {
            //        case 4:
            //        case 6:
            //        case 10:
            //            health = health - 20;
            //            Console.WriteLine($"Oh ne, dostal si damage, ted mas {health}hp");
            //            break;
            //        case 0:
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 9:
            //            break;
            //        default:
            //            break;
            //    }
            //}
            #endregion

            Console.WriteLine();
            Console.WriteLine("\nHurá, porazil jsi Petra!\n");
            Console.WriteLine("-LEVEL 3-");
            Console.WriteLine("\"\"");
            Console.WriteLine("damage + 20");
            Console.WriteLine("heal +15");

            #region for
            //for (int zivoty = 800; zivoty >= 0;)
            //{
            //    Random random = new Random();
            //    int PD = random.Next(1, 10);
            //    string akce = "";

            //    Console.Write("Akce: ");

            //    akce = Console.ReadLine();


            //    switch (akce)
            //    {
            //        case "attack":
            //            Console.WriteLine("-50 životů");
            //            zivoty = (zivoty - 50);
            //            if (zivoty > 0)
            //            {
            //                Console.WriteLine(zivoty);
            //            }
            //            else if (zivoty < 0)
            //            {
            //                break;
            //            }

            //            Thread.Sleep(500);
            //            break;
            //        case "heal":
            //            Console.WriteLine("+15 hp");
            //            health = (health + 15);
            //            Console.WriteLine(health);
            //            Thread.Sleep(500);
            //            break;
            //        default:
            //            Console.Write("neplatná akce\n\n");
            //            break;

            //    }

            //    switch (PD)
            //    {
            //        case 4:
            //        case 6:
            //        case 10:
            //            health = health - 20;
            //            Console.WriteLine($"Oh ne, dostal si damage, ted mas {health}hp");
            //            break;
            //        case 0:
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 9:
            //            break;
            //        //default:
            //        //    break;
            //    }
            //}
            #endregion

            Enemy x = new Enemy(500, 25, 45, "x"); //hp_boss prichozi_dmg odchozi_dmg name
            Šlimák.start();
        }
    }

    class Enemy
    {
        public Enemy(int hp, int pd, int dmg, string jmeno)
        {
            this.hp = hp;
            this.jmeno = jmeno;
            this.pd = pd;
            this.dmg = dmg;
        }

        public int hp { get; private set; }
        public string jmeno { get; private set; }
        public int pd { get; private set; }
        public int dmg { get; private set; }
        public int php { get; set; }

        public void start()
        {
            for (int zivoty = 200; zivoty >= 0;)
            {
                string akce = "";
                Console.Write("Akce: ");
                akce = Console.ReadLine();


                switch (akce)
                {
                    case "attack":
                        Console.WriteLine($"-{dmg} životů");
                        hp = (hp - dmg);
                        if (zivoty > 0)
                        {
                            Console.WriteLine(hp);
                        }
                        else if (hp < 0)
                        {
                            break;
                        }

                        Thread.Sleep(500);
                        break;
                    case "heal":
                        Console.WriteLine("+10 hp");
                        hp = (hp + 10);
                        Console.WriteLine(hp);
                        Thread.Sleep(500);
                        break;
                    default:
                        Console.Write("neplatná akce\n\n");
                        akce = Console.ReadLine();
                        break;

                }

                Random random = new Random();
                int PD = random.Next(1, 10);

                switch (PD)
                {
                    case 4:
                    case 6:
                    case 10:
                        php -= pd;
                        Console.WriteLine($"Oh ne, dostal si damage, ted mas {php} hp");
                        break;
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 9:
                        break;
                    default:
                        break;
                }

            }
        }
    }
}


//  Thread.Sleep(500);

/*
    Random rand = new Random().Next(1, 5);
    int randNum = rand.Next(1, 5);
    string questString = questions.GetValue(quest, randNum);
*/