using System;

namespace CMPE103OOP
{
    class Program
    {
        static void Main()
        {
        //Character Base Stats
        int iVit = 82; 
        int iStr = 42; 
        int iEnd = 56;
        int iAg = 37;
        int iInt = 50;
        int iDex = 45;
        
        //Equipped Item Stats
        int bVit = 37; 
        int bStr = 34;
        int bEnd = 0;
        int bAg = 17; 
        int bInt = 0;
        int bDex = 19;
        
        //Character Overall Stats
        int oVit = iVit + bVit;
        int oStr = iStr + bStr;
        int oEnd = iEnd + bEnd;
        int oAg = iAg + bAg;
        int oInt = iInt + bInt;
        int oDex = iDex + bDex;
        
        Console.WriteLine("-------WELCOME TRAVELLER!-------");
        Console.WriteLine("Enter your character's name:");
        string charName = Console.ReadLine();
        
        while (true)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("------GAME CHARACTER STATS------");
            Console.WriteLine("Enter 1 to View Base Stats.");
            Console.WriteLine("Enter 2 to Check Equipped Item.");
            Console.WriteLine("Enter 3 to View Overall Stats.");
            Console.WriteLine("Enter 4 to Exit Game Stats.");
            
            Console.WriteLine("Enter your selection: ");
            int statInput = Convert.ToInt32(Console.ReadLine());
            
            if (statInput == 1)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("-----" + charName + "'s Base Stats-----" );
                Console.WriteLine("Vitality: " + iVit);
                Console.WriteLine("Strength: " + iStr);
                Console.WriteLine("Endurance: " + iEnd);
                Console.WriteLine("Agility: " + iAg);
                Console.WriteLine("Intelligence: " + iInt);
                Console.WriteLine("Dexterity: " + iDex);
            } 
            else if (statInput == 2)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("------Ceremonial War-Plume------");
                Console.WriteLine("Vitality: +" + bVit);
                Console.WriteLine("Strength: +" + bStr);
                Console.WriteLine("Agility: +" + bAg);
                Console.WriteLine("Dexterity: +" + bDex);
            } 
            else if (statInput == 3)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("-----" + charName + "'s Overall Stats-----");
                Console.WriteLine("Vitality: " + oVit);
                Console.WriteLine("Strength: " + oStr);
                Console.WriteLine("Endurance: " + oEnd);
                Console.WriteLine("Agility: " + oAg);
                Console.WriteLine("Intelligence: " + oInt);
                Console.WriteLine("Dexterity: " + oDex);
            }
            else if (statInput == 4)
            {
                Console.WriteLine("-------Session Terminated-------");
                break;
            }
            else 
            {
                Console.WriteLine("Unrecognized Input, Try Again!");
            }
        }
        }
    }

}
