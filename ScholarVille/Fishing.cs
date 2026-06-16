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

        static List<string> Users = new List<string>();
        static List<string> UserFishCollection = new List<string>();

        public void Start(string userName)
        {
            Console.Clear();

            Users = File.ReadAllLines("Users.txt").ToList();
            UserFishCollection = File.ReadAllLines("UserFish.txt").ToList();

            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                                  Sustainable Fishing");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Catch only 5 fish.");
            Console.WriteLine("Stop fishing afterwards to help prevent overfishing.");
            Console.WriteLine();
            Console.WriteLine("Trash can also be removed from the water.");
            Console.WriteLine();
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();

            Console.Clear();

            while (game)
            {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine($"Fish Caught : {fishCaught}/5");
                Console.WriteLine($"Trash Removed : {trashCollected}");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine();
                Console.WriteLine("Press any key to cast your line...");
                Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine("Waiting for a bite...");

                // Random wait between 2 and 5 seconds
                int waitTime = rnd.Next(2000, 5000);

                DateTime waitStart = DateTime.Now;

                // Clear spammed inputs while waiting
                while ((DateTime.Now - waitStart).TotalMilliseconds < waitTime)
                {
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("A fish bit the hook!");
                Console.WriteLine("PRESS SPACE QUICKLY!");

                // Clear any remaining buffered inputs
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                bool caught = false;

                DateTime biteStart = DateTime.Now;

                // 1 second reaction window
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

                        Console.WriteLine($"You caught a {fish}!");
                    }
                    else
                    {
                        trashCollected++;

                        Console.WriteLine("You removed trash from the water!");
                        Console.WriteLine("The river is cleaner.");
                    }
                }
                else
                {
                    Console.WriteLine("Too slow!");
                    Console.WriteLine("The fish escaped.");
                }

                if (fishCaught >= 5)
                {
                    win = true;
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();

            if (win)
            {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                     YOU WIN!");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine();
                Console.WriteLine("You caught 5 fish and stopped.");
                Console.WriteLine("By avoiding overfishing, you helped protect aquatic ecosystems.");

                UpdateInfo(userName);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
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

                    totalCaught += fishCaught;

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

        private string GenerateFish(string userName)
        {
            string fishType = "";

            int roll = rnd.Next(1, 101);

            if (roll <= 40)
                fishType = "Tilapia";
            else if (roll <= 70)
                fishType = "Milkfish";
            else if (roll <= 90)
                fishType = "Catfish";
            else if (roll <= 99)
                fishType = "Tuna";
            else
                fishType = "Golden Fish";

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
