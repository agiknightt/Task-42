using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_42
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = true;
            int topListCount = 3;
            List<Player> players = new List<Player>();

            AddPlayers(players);

            while (isExit)
            {
                Console.WriteLine("1 - Показать топ 3 сервера по уровню\n\n2 -Показать топ 3 сервера по силе\n\n3 - Выйти");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        var fillteredTopLelvel = players.OrderByDescending(player => player.Level).ToList();

                        for (int i = 0; i < topListCount; i++)
                        {
                            fillteredTopLelvel[i].ShowInfo();
                        }
                        break;
                    case 2:
                        var fillteredTopPower = players.OrderByDescending(player => player.Power).ToList();

                        for (int i = 0; i < topListCount; i++)
                        {
                            fillteredTopPower[i].ShowInfo();
                        }
                        break;
                    case 3:
                        isExit = false;
                        break;
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }            
        }

        private static void AddPlayers(List<Player> players)
        {
            players.Add(new Player("Jon", 37, 370));
            players.Add(new Player("Painon", 42, 400));
            players.Add(new Player("Valter", 81, 850));
            players.Add(new Player("Restain", 50, 500));
            players.Add(new Player("Gytai", 60, 1200));
            players.Add(new Player("Gigat", 75, 900));
            players.Add(new Player("Sesta", 70, 800));
            players.Add(new Player("Tet", 80, 700));
            players.Add(new Player("Vais", 50, 300));
            players.Add(new Player("Gaga", 100, 1000));
        }
    }
    class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }
        public Player(string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Имя - {Name}\n\nУровень - {Level}\n\nСила - {Power}\n");
        }
    }
}
