using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numNPCs;
            Perks[] npcPerks;

            // Ask for the number of NPCs
            Console.Write("How many NPC? ");
            numNPCs = int.Parse(Console.ReadLine());

            // Create the array of NPC perks
            npcPerks = new Perks[numNPCs];

            // For each NPC, ask for its perks
            for (int n = 0; n < numNPCs; n++)
            {
                // User input
                string input;

                // Stealth?
                Console.Write($"Does NPC {n} has stealth (y/n)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Stealth;
                }

                // Combat?
                Console.Write($"Does NPC {n} has combat (y/n)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Combat;
                }

                // Lockpick?
                Console.Write($"Does NPC {n} has lockpick (y/n)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Lockpick;
                }

                // Luck?
                Console.Write($"Does NPC {n} has luck (y/n)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Luck;
                }
            }

            // Show on screen the perks of all NPCs
            // If NPC has Combat & Luck print special message
            foreach (Perks perks in npcPerks)
            {
                Perks special = Perks.Combat | Perks.Luck;
                Console.WriteLine($"NPC has {perks}");
                if ((perks & special) == special)
                {
                    Console.WriteLine("\tYou shall win all fights");
                }
            }
        }
    }
}
