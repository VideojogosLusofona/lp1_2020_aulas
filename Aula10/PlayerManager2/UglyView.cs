using System;
using System.Collections.Generic;

namespace PlayerManager2
{
    public class UglyView : IView
    {
        private Controller controller;
        // private List<Player> list;

        public UglyView(Controller controller) //, List<Player> list)
        {
            this.controller = controller;
            // this.list = list;
        }

        public int MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List player with score greater than");
            Console.WriteLine("0. Exit");
            Console.WriteLine("");
            Console.Write("> ");

            return int.Parse(Console.ReadLine());
        }

        public void InvalidOption()
        {
            Console.WriteLine("\nInvalid option! Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        public void ShowPlayers(IEnumerable<Player> players)
        {
            Console.WriteLine();
            foreach (Player p in players)
            {
                Console.WriteLine($"-> {p}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
        }

        public Player AskForPlayer()
        {
            string name;
            int score;

            Console.WriteLine();
            Console.WriteLine("Insert player data");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.Write("Name > ");
            name = Console.ReadLine();
            Console.Write("Score > ");
            score = int.Parse(Console.ReadLine());

            return new Player(name, score);
        }

        public int AskForMinimumScore()
        {
            Console.WriteLine();
            Console.Write("Minimum score? > ");
            return int.Parse(Console.ReadLine());
        }
    }
}