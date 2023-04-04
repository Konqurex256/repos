using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;

namespace GoblinAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("-LEVEL 1-");
            Console.WriteLine("\"Šlimák\"");
            Enemy Šlimák = new Enemy(100, "Šlimák", 40);

            int health = 50;
            for (int zivoty = 200; zivoty >= 0;)
            {
                Random random = new Random();
                int PD = random.Next(1, 10);
                string akce = "";

                Console.Write("Akce: ");

                akce = Console.ReadLine();


                switch (akce)
                {
                    case "attack":
                        Console.WriteLine("-40 životů");
                        zivoty = (zivoty - 40);
                        if (zivoty > 0)
                        {
                            Console.WriteLine(zivoty);
                        }
                        else if (zivoty < 0)
                        {
                            break;
                        }

                        Thread.Sleep(500);
                        break;
                    case "heal":
                        Console.WriteLine("+10 hp");
                        health = (health + 10);
                        Console.WriteLine(health);
                        Thread.Sleep(500);
                        break;
                    default:
                        Console.Write("neplatná akce\n\n");
                        break;

                }

                switch (PD)
                {
                    case 4:
                    case 6:
                    case 10:
                        health = health - 20;
                        Console.WriteLine($"Oh ne, dostal si damage, ted mas {health}hp");
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

            Console.WriteLine();
            Console.WriteLine("\nHurá, porazil jsi Šlimáka!\n");
            Console.WriteLine("-LEVEL 2-");
            Console.WriteLine("\"Petr\"");
            Console.WriteLine("damage + 10");
            Console.WriteLine("heal + 5");

            for (int zivoty = 500; zivoty >= 0;)
            {
                Random random = new Random();
                int PD = random.Next(1, 10);
                string akce = "";

                Console.Write("Akce: ");

                akce = Console.ReadLine();


                switch (akce)
                {
                    case "attack":
                        Console.WriteLine("-40 životů");
                        zivoty = (zivoty - 40);
                        if (zivoty > 0)
                        {
                            Console.WriteLine(zivoty);
                        }
                        else if (zivoty < 0)
                        {
                            break;
                        }
                        
                        Thread.Sleep(500);
                        break;
                    case "heal":
                        Console.WriteLine("+10 hp");
                        health = (health + 10);
                        Console.WriteLine(health);
                        Thread.Sleep(500);
                        break;
                    default:
                        Console.Write("neplatná akce\n\n");
                        break;

                }

                switch (PD)
                {
                    case 4:
                    case 6:
                    case 10:
                        health = health - 20;
                        Console.WriteLine($"Oh ne, dostal si damage, ted mas {health}hp");
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

            Console.WriteLine();
            Console.WriteLine("\nHurá, porazil jsi Petra!\n");
            Console.WriteLine("-LEVEL 3-");
            Console.WriteLine("\"Petr\"");
            Console.WriteLine("damage + 10");
            Console.WriteLine("heal + 5");

            for (int zivoty = 800; zivoty >= 0;)
            {
                Random random = new Random();
                int PD = random.Next(1, 10);
                string akce = "";

                Console.Write("Akce: ");

                akce = Console.ReadLine();


                switch (akce)
                {
                    case "attack":
                        Console.WriteLine("-50 životů");
                        zivoty = (zivoty - 50);
                        if (zivoty > 0)
                        {
                            Console.WriteLine(zivoty);
                        }
                        else if (zivoty < 0)
                        {
                            break;
                        }

                        Thread.Sleep(500);
                        break;
                    case "heal":
                        Console.WriteLine("+15 hp");
                        health = (health + 15);
                        Console.WriteLine(health);
                        Thread.Sleep(500);
                        break;
                    default:
                        Console.Write("neplatná akce\n\n");
                        break;

                }

                switch (PD)
                {
                    case 4:
                    case 6:
                    case 10:
                        health = health - 20;
                        Console.WriteLine($"Oh ne, dostal si damage, ted mas {health}hp");
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
                    //default:
                    //    break;
                }
            }
        }
    }

    class Enemy
    {

        public int hp;
        public string jmeno;


        public Enemy(int hp, string jmeno, int pd)
        {
            this.hp = hp;
            this.jmeno = jmeno;
            this.pd = pd;
        }

        



    }
}


//  Thread.Sleep(500);

/*
    Random rand = new Random().Next(1, 5);
    int randNum = rand.Next(1, 5);
    string questString = questions.GetValue(quest, randNum);
*/