using System;

namespace CMPE103OOP
{
    class Program
    {
        static void Main()
        {
            // Character Base Stats
            int[] EiStats = { 85, 45, 50, 35, 54, 50 };
            int[] NiStats = { 84, 47, 50, 40, 49, 45 };

            // Equipped Item Stats
            int[] bStats = { 37, 34, 0, 17, 0, 19 };

            // Character Overall Stats
            int[] EoStats = new int[6];
            int[] NoStats = new int[6];

            for (int i = 0; i < 6; i++)
            {
                EoStats[i] = EiStats[i] + bStats[i];
                NoStats[i] = NiStats[i] + bStats[i];
            }

            int EoVit = EoStats[0];
            int EoStr = EoStats[1];
            int EoEnd = EoStats[2];
            int EoAg = EoStats[3];
            int EoInt = EoStats[4];
            int EoDex = EoStats[5];

            int NoVit = NoStats[0];
            int NoStr = NoStats[1];
            int NoEnd = NoStats[2];
            int NoAg = NoStats[3];
            int NoInt = NoStats[4];
            int NoDex = NoStats[5];

            Console.WriteLine("—————— TEYVAT WELCOMES YOU! ——————");
            Console.WriteLine();
            Console.WriteLine("Choose a character:");
            Console.WriteLine("Enter 1 to select Eos.");
            Console.WriteLine("Enter 2 to select Nyx.");
            Console.WriteLine();

            int charChoice;
            while (true)
            {
                Console.Write("Enter your selection: ");
                if (int.TryParse(Console.ReadLine(), out charChoice))
                {
                    if (charChoice == 1 || charChoice == 2)
                    {
                        break;
                    }
                }
                Console.WriteLine("Unrecognized Input. Try Again!");
            }
            Console.WriteLine();

            switch (charChoice)
            {
                case 1:
                    GameStats("Eos", EiStats, bStats, EoStats);
                    break;
                case 2:
                    GameStats("Nyx", NiStats, bStats, NoStats);
                    break;
            }
        }

        static void GameStats(string charName, int[] iStats, int[] bStats, int[] oStats)
        {
            int statInput;

            do
            {
                Console.WriteLine("—————— GAME CHARACTER STATS ——————");
                Console.WriteLine("Enter 1 to View Base Stats.");
                Console.WriteLine("Enter 2 to Check Equipped Item.");
                Console.WriteLine("Enter 3 to View Overall Stats.");
                Console.WriteLine("Enter 4 to Exit Game Stats.");
                Console.WriteLine();

                Console.Write("Enter your selection: ");
                if (int.TryParse(Console.ReadLine(), out statInput))
                {
                    Console.WriteLine();

                    switch (statInput)
                    {
                        case 1:
                            Console.WriteLine($"—————— {charName}'s Base Stats ——————");
                            Console.WriteLine("Vitality: " + iStats[0]);
                            Console.WriteLine("Strength: " + iStats[1]);
                            Console.WriteLine("Endurance: " + iStats[2]);
                            Console.WriteLine("Agility: " + iStats[3]);
                            Console.WriteLine("Intelligence: " + iStats[4]);
                            Console.WriteLine("Dexterity: " + iStats[5]);
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("—————— Ceremonial War-Plume ——————");
                            Console.WriteLine("Vitality: +" + bStats[0]);
                            Console.WriteLine("Strength: +" + bStats[1]);
                            Console.WriteLine("Agility: +" + bStats[3]);
                            Console.WriteLine("Dexterity: +" + bStats[5]);
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine($"—————— {charName}'s Overall Stats ——————");
                            Console.WriteLine("Vitality: " + oStats[0]);
                            Console.WriteLine("Strength: " + oStats[1]);
                            Console.WriteLine("Endurance: " + oStats[2]);
                            Console.WriteLine("Agility: " + oStats[3]);
                            Console.WriteLine("Intelligence: " + oStats[4]);
                            Console.WriteLine("Dexterity: " + oStats[5]);
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine("—————— Session Terminated ——————");
                            break;
                        default:
                            Console.WriteLine("Unrecognized Input, Try Again!");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unrecognized Input, Try Again!");
                    Console.WriteLine();
                }
            } 
            while (statInput != 4);
        }
    }
}