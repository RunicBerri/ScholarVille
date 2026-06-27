using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace ScholarVille
{
    public class Fishing
    {
        int fishCaught = 0;
        int trashCollected = 0;

        bool game = true;
        bool win = false;

        Random rnd = new Random();
        static ASCII ascii = new ASCII();

        static List<string> Users = new List<string>();
        static List<string> UserFishCollection = new List<string>();

        public void Start(string userName)
        {
            Console.Clear();

            Users = File.ReadAllLines("Users.txt").ToList();
            UserFishCollection = File.ReadAllLines("UserFish.txt").ToList();
            
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                    Catch & Conserve                                   |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                SDG 14 - Life Below Water                              |");
            Console.WriteLine("|                           Balance your catch, protect sea life,                       |");
            Console.WriteLine("|                            and become a guardian of the ocean.                        |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               Press \"Spacebar\" reel the fish.                         |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
            Console.ResetColor();
            Console.WriteLine("|                                   Press any key to start.                             |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|_______________________________________________________________________________________|");
            ConsoleKey input = Console.ReadKey(true).Key;
            Console.Clear();

            if (input == ConsoleKey.X)
            {
                Console.Clear();
                ascii.Returning();
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }

            while (game)
            {
                if (input == ConsoleKey.X)
                {
                    Console.Clear();
                    ascii.Returning();
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine($"|                                     Fish Caught : {fishCaught}/5                                 |");
                Console.WriteLine($"|                                     Trash Removed : {trashCollected}                                 |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Press any key to cast your line...                       |");
                Console.ReadKey();

                Console.WriteLine("\n|                                                                                       |");
                Console.WriteLine("|                                    Waiting for a bite...                              |");


                int waitTime = rnd.Next(2000, 5000);

                DateTime waitStart = DateTime.Now;

                while ((DateTime.Now - waitStart).TotalMilliseconds < waitTime)
                {
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                }

                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                   A fish bit the hook!                                |");
                Console.WriteLine("|                                   PRESS SPACE QUICKLY!                                |");

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                bool caught = false;

                DateTime biteStart = DateTime.Now;

                while ((DateTime.Now - biteStart).TotalMilliseconds < 1000)
                {
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            caught = true;
                            break;
                        }
                        
                    }
                }

                Console.WriteLine();

                if (caught)
                {
                    int catchRoll = rnd.Next(1, 11);

                    if (catchRoll <= 7)
                    {
                        string fish = GenerateFish(userName);

                        fishCaught++;

                        Console.WriteLine("|                                                                                       |");
                        Console.WriteLine($"|                               You caught a {fish}                                      ");
                    }
                    else
                    {
                        trashCollected++;

                        Console.WriteLine("|                                                                                       |");
                        Console.WriteLine("|                              You removed trash from the water!                        |");
                        Console.WriteLine("|                                   The river is cleaner.                               |");
                    }
                }
                else
                {
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                        Too slow!                                      |");
                    Console.WriteLine("|                                     The fish escaped.                                 |");
                }

                

                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                ConsoleKey input2 = Console.ReadKey(true).Key;
                Console.Clear();

                if (input2 == ConsoleKey.X)
                {
                    Console.Clear();
                    ascii.Returning();
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                else if (input2 == ConsoleKey.S)
                {
                    if (fishCaught == 5)
                    {
                        win = true;
                        break;
                    }
                    else 
                    {
                        win = false;
                        break;
                    }
                }
            }

            if (win)
            {
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                       YOU WON!                                        |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                            You caught 5 fish and stopped.                             |");
                Console.WriteLine("|            By avoiding overfishing, you helped protect aquatic ecosystems.            |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();

                UpdateInfo(userName);
                Restart(userName);
            }
            else if (win == false && fishCaught > 5) 
            {
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                       YOU LOST!                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                        You caught more than 5 fish and stopped.                       |");
                Console.WriteLine("|                Overfishing can be harmful for the aquatic ecosystems.                 |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();

                Restart(userName);
            }
            else if (win == false && fishCaught < 5)
            {
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                       YOU LOST!                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                          You caught less 5 fish and stopped.                          |");
                Console.WriteLine("|                    You failed to catch the required amount of fish.                   |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                              Press any key to continue.                               |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();

                Restart(userName);
            }

            Console.WriteLine("|                              Press any key to continue.                               |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }
        public void UpdateInfo(string userName)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                string[] parts = Users[i].Split(',');
                int totalCollected = 0;

                if (parts[1] == userName)
                {
                    int totalCaught = Convert.ToInt32(parts[7]);
                    int totalTrash = Convert.ToInt32(parts[3]);

                    totalTrash += trashCollected;
                    totalCaught += fishCaught;

                    parts[3] = totalTrash.ToString();
                    parts[7] = totalCaught.ToString();
                    Users[i] = string.Join(",", parts);


                    for (int k = 0; k < UserFishCollection.Count; k++)
                    {
                        string[] collParts = UserFishCollection[k].Split(',');

                        int tilapia = Convert.ToInt32(collParts[2]);
                        int milkfish = Convert.ToInt32(collParts[3]);
                        int catfish = Convert.ToInt32(collParts[4]);
                        int tuna = Convert.ToInt32(collParts[5]);
                        int goldFish = Convert.ToInt32(collParts[6]);

                        totalCollected = tilapia + milkfish + catfish + tuna + goldFish;

                    }
                    int oldTotalCollected = Convert.ToInt32(parts[8]);

                    if (totalCollected > oldTotalCollected)
                    {
                        parts[8] = totalCollected.ToString();
                    }
                    Users[i] = string.Join(",", parts);

                    break;
                }
            }

            File.WriteAllLines("Users.txt", Users);
        }
        private void Restart(string userName)
        {
            while (true)
            {
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                     Play Again?                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                     Enter (Y/N)                                       |");
                Console.WriteLine("|_______________________________________________________________________________________|");

                string input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    fishCaught = 0;
                    trashCollected = 0;
                    Start(userName);
                }
                else if (input == "n")
                {
                    Console.Clear();
                    ascii.Returning();
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                              Please enter valid option.                               |");
                    Console.WriteLine("|                              Press any key to continue.                               |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }

        private string GenerateFish(string userName)
        {
            string fishType = "";

            int roll = rnd.Next(1, 101);

            if (roll <= 40)
            {
                fishType = "Tilapia";
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.TilapiaArt();
                Console.ResetColor();
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("|_______________________________________________________________________________________|");
            }
            else if (roll <= 70)
            {
                fishType = "Milkfish";
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.MilkfishArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("|_______________________________________________________________________________________|");
            }
            else if (roll <= 90)
            {
                fishType = "Catfish";
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.CatfishArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("|_______________________________________________________________________________________|");
            }
            else if (roll <= 99)
            {
                fishType = "Tuna";
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.TunaArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("|_______________________________________________________________________________________|");
            }
            else
            {
                fishType = "Golden Fish";
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.GoldfishArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("|_______________________________________________________________________________________|");
            }

            for (int i = 0; i < UserFishCollection.Count; i++)
            {
                string[] parts = UserFishCollection[i].Split(',');

                if (parts[1] == userName)
                {
                    switch (fishType)
                    {
                        case "Tilapia":
                            parts[2] = "1";
                            break;

                        case "Milkfish":
                            parts[3] = "1";
                            break;

                        case "Catfish":
                            parts[4] = "1";
                            break;

                        case "Tuna":
                            parts[5] = "1";
                            break;

                        case "Golden Fish":
                            parts[6] = "1";
                            break;
                    }

                    UserFishCollection[i] = string.Join(",", parts);
                    break;
                }
            }

            File.WriteAllLines("UserFish.txt", UserFishCollection);

            return fishType;
        }
    }  
}
