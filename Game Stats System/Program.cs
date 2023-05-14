using System;

namespace CMPE103OOP
{
    class Program
    {
        static void Main()
        {
        //Character Base Stats
        int AiVit = 82; 
        int AiStr = 42; 
        int AiEnd = 56;
        int AiAg = 37;
        int AiInt = 50;
        int AiDex = 45;
        int LiVit = 85; 
        int LiStr = 45; 
        int LiEnd = 50;
        int LiAg = 35;
        int LiInt = 54;
        int LiDex = 50;
        
        //Equipped Item Stats
        int bVit = 37; 
        int bStr = 34;
        int bEnd = 0;
        int bAg = 17; 
        int bInt = 0;
        int bDex = 19;
        
        //Character Overall Stats
        int AoVit = AiVit + bVit;
        int AoStr = AiStr + bStr;
        int AoEnd = AiEnd + bEnd;
        int AoAg = AiAg + bAg;
        int AoInt = AiInt + bInt;
        int AoDex = AiDex + bDex;
        int LoVit = LiVit + bVit;
        int LoStr = LiStr + bStr;
        int LoEnd = LiEnd + bEnd;
        int LoAg = LiAg + bAg;
        int LoInt = LiInt + bInt;
        int LoDex = LiDex + bDex;

        Console.WriteLine("------TEYVAT WELCOMES YOU!------");
        Console.WriteLine("Choose a character:");
        Console.WriteLine("Enter 1 to select Aether.");
        Console.WriteLine("Enter 2 to select Lumine.");
        
        int charChoice;
        while (true) {
            Console.WriteLine("Enter your selection: ");
            if (int.TryParse(Console.ReadLine(), out charChoice))
        {
            if (charChoice == 1 || charChoice == 2)
        {
            break;
        }}
            Console.WriteLine("Unrecognized Input. Try Again!");
        }

        switch (charChoice)
        {
            case 1:
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------GAME CHARACTER STATS------");
            Console.WriteLine("Enter 1 to View Base Stats.");
            Console.WriteLine("Enter 2 to Check Equipped Item.");
            Console.WriteLine("Enter 3 to View Overall Stats.");
            Console.WriteLine("Enter 4 to Exit Game Stats.");
            
            while (true) {
            Console.WriteLine("Enter your selection: ");
            int statInput = Convert.ToInt32(Console.ReadLine());
                if (statInput == 1)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("------Aether's Base Stats------" );
                Console.WriteLine("Vitality: " + AiVit);
                Console.WriteLine("Strength: " + AiStr);
                Console.WriteLine("Endurance: " + AiEnd);
                Console.WriteLine("Agility: " + AiAg);
                Console.WriteLine("Intelligence: " + AiInt);
                Console.WriteLine("Dexterity: " + AiDex);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("------GAME CHARACTER STATS------");
                Console.WriteLine("Enter 1 to View Base Stats.");
                Console.WriteLine("Enter 2 to Check Equipped Item.");
                Console.WriteLine("Enter 3 to View Overall Stats.");
                Console.WriteLine("Enter 4 to Exit Game Stats.");

            } else if (statInput == 2)    
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("------Ceremonial War-Plume------");
                Console.WriteLine("Vitality: +" + bVit);
                Console.WriteLine("Strength: +" + bStr);
                Console.WriteLine("Agility: +" + bAg);
                Console.WriteLine("Dexterity: +" + bDex);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("------GAME CHARACTER STATS------");
                Console.WriteLine("Enter 1 to View Base Stats.");
                Console.WriteLine("Enter 2 to Check Equipped Item.");
                Console.WriteLine("Enter 3 to View Overall Stats.");
                Console.WriteLine("Enter 4 to Exit Game Stats.");

            } else if (statInput == 3)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("-----Aether's Overall Stats-----");
                Console.WriteLine("Vitality: " + AoVit);
                Console.WriteLine("Strength: " + AoStr);
                Console.WriteLine("Endurance: " + AoEnd);
                Console.WriteLine("Agility: " + AoAg);
                Console.WriteLine("Intelligence: " + AoInt);
                Console.WriteLine("Dexterity: " + AoDex);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("------GAME CHARACTER STATS------");
                Console.WriteLine("Enter 1 to View Base Stats.");
                Console.WriteLine("Enter 2 to Check Equipped Item.");
                Console.WriteLine("Enter 3 to View Overall Stats.");
                Console.WriteLine("Enter 4 to Exit Game Stats.");

            } else if (statInput == 4)
            {
                Console.WriteLine("-------Session Terminated-------");
                break;
            }else 
            {
                Console.WriteLine("Unrecognized Input, Try Again!");
            }}
            break;
            
            case 2:
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------GAME CHARACTER STATS------");
            Console.WriteLine("Enter 1 to View Base Stats.");
            Console.WriteLine("Enter 2 to Check Equipped Item.");
            Console.WriteLine("Enter 3 to View Overall Stats.");
            Console.WriteLine("Enter 4 to Exit Game Stats.");
            
            while (true) {
            Console.WriteLine("Enter your selection: ");
            int statInput = Convert.ToInt32(Console.ReadLine());
                if (statInput == 1)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("------Lumine's Base Stats------" );
                Console.WriteLine("Vitality: " + LiVit);
                Console.WriteLine("Strength: " + LiStr);
                Console.WriteLine("Endurance: " + LiEnd);
                Console.WriteLine("Agility: " + LiAg);
                Console.WriteLine("Intelligence: " + LiInt);
                Console.WriteLine("Dexterity: " + LiDex);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("------GAME CHARACTER STATS------");
                Console.WriteLine("Enter 1 to View Base Stats.");
                Console.WriteLine("Enter 2 to Check Equipped Item.");
                Console.WriteLine("Enter 3 to View Overall Stats.");
                Console.WriteLine("Enter 4 to Exit Game Stats.");

            } else if (statInput == 2)    
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("------Ceremonial War-Plume------");
                Console.WriteLine("Vitality: +" + bVit);
                Console.WriteLine("Strength: +" + bStr);
                Console.WriteLine("Agility: +" + bAg);
                Console.WriteLine("Dexterity: +" + bDex);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("------GAME CHARACTER STATS------");
                Console.WriteLine("Enter 1 to View Base Stats.");
                Console.WriteLine("Enter 2 to Check Equipped Item.");
                Console.WriteLine("Enter 3 to View Overall Stats.");
                Console.WriteLine("Enter 4 to Exit Game Stats.");

            } else if (statInput == 3)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("-----Lumine's Overall Stats-----");
                Console.WriteLine("Vitality: " + LoVit);
                Console.WriteLine("Strength: " + LoStr);
                Console.WriteLine("Endurance: " + LoEnd);
                Console.WriteLine("Agility: " + LoAg);
                Console.WriteLine("Intelligence: " + LoInt);
                Console.WriteLine("Dexterity: " + LoDex);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("------GAME CHARACTER STATS------");
                Console.WriteLine("Enter 1 to View Base Stats.");
                Console.WriteLine("Enter 2 to Check Equipped Item.");
                Console.WriteLine("Enter 3 to View Overall Stats.");
                Console.WriteLine("Enter 4 to Exit Game Stats.");

            } else if (statInput == 4)
            {
                Console.WriteLine("-------Session Terminated-------");
                break;
            }else 
            {
                Console.WriteLine("Unrecognized Input, Try Again!");
            }}
            break;
        }
    }    
}}
