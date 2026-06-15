using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

public class TreePlanter
{
    //needs better ui

    int fertilizer = 0;
	int water = 0;
	int growth = 0;
    bool game = true;
    bool win = false;

	Random rnd = new Random();
    static List<string> Users = new List<string>();
    static List<string> UserTreeCollection = new List<string>();

    public void Start(string userName)
    {
        Console.Clear();
        UserTreeCollection = File.ReadAllLines("UserTrees.txt").ToList();
        Users = File.ReadAllLines("Users.txt").ToList();

        Console.WriteLine("=========================================================================================");
        Console.WriteLine("                                          Grow a Tree");
        Console.WriteLine("=========================================================================================");
        Console.WriteLine("game desc.");
        Console.WriteLine("\n                                 Press \"X\" to leave the game.");
        Console.WriteLine("                                    Press any key to start.");
        string input1 = Console.ReadLine().ToLower();
        Console.Clear();
        if (input1 == "x")
        {
            Console.Clear();
            Console.WriteLine("Returning to Game Selection.");
            Thread.Sleep(1000);
            Console.Clear();
            return;
        }

        while (game)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("                                                                                      (X)");
            Console.WriteLine($"                                    Tree Growth : {growth}%");
            Console.WriteLine($"                                    Feritlizer  : {fertilizer}");
            Console.WriteLine($"                                    Water       : {water}");
            Console.WriteLine("                                    Press \"X\" to leave the game.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("\nPress any key to explore...");
            string input2 = Console.ReadLine().ToLower();
            if (input2 == "x") 
            {
                Console.Clear();
                Console.WriteLine("Returning to Game Selection.");
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
            Console.Clear();   

            int item = rnd.Next(1, 9);

            switch (item)
            {
                case 1:
                    Console.WriteLine("\nYou found a sack of fertilizer!");
                    Console.WriteLine("<You gained 1 fertilizer>");
                    fertilizer++;
                    break;
                case 2:
                    Console.WriteLine("\nEW! You found a huge animal poop!");
                    Console.WriteLine("<You gained 1 fertilizer>");
                    fertilizer++;
                    break;
                case 3:
                    Console.WriteLine("\nYou found A lot of food waste!");
                    Console.WriteLine("<You gained 1 fertilizer>");
                    fertilizer++;
                    break;
                case 4:
                    Console.WriteLine("\nYou found a gallon of water!");
                    Console.WriteLine("<You gained 1 water>");
                    water++;
                    break;
                case 5:
                    Console.WriteLine("\nYou found a very clean pond!");
                    Console.WriteLine("<You gained 1 water>");
                    water++;
                    break;
                case 6:
                    Console.WriteLine("\nRain suddenly started!");
                    Console.WriteLine("<You gained 1 water>");
                    water++;
                    break;
                case 7:
                    Console.WriteLine("\nOof! A pest attacked your tree!");
                    growth -= 2;
                    break;
                case 8:
                    Console.WriteLine("\nOH NO! A swarm of pests attacked your tree!");
                    growth -= 10;
                    break;
            }
            if (fertilizer > 0 && water > 0)
            {
                fertilizer--;
                water--;
                growth += 10;

                Console.WriteLine("\nYour tree grew by 10%!");
            }
            if (growth < 0)
            {
                break;
            }
            else if (growth >= 100) 
            {
                win = true;
                break;
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
        }

        if (win == false)
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                                         GAME OVER!");
            Console.WriteLine("\n                                Your sapling failed to grow.");
            Console.WriteLine("=========================================================================================");

        }
        else if (win == true) 
        {

            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                                          YOU WIN!");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("\nCongratulations!");
            var treeType = GenerateTree(userName);
            Console.WriteLine($"Your tree grew into a {treeType}");

            UpdateInfo(userName);
        }
        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
        Console.Clear();
        return;
    }

    public void UpdateInfo(string userName) 
    {
        for (int i = 0; i < Users.Count; i++) 
        {
            string[] parts = Users[i].Split(',');
            int totalCollected = 0;

            if (parts[1] == userName)
            {

                int newScore = Convert.ToInt32(parts[5]);
                newScore++;

                parts[5] = newScore.ToString();
                Users[i] = string.Join(",", parts);


                for (int k = 0; k < UserTreeCollection.Count; k++) 
                {
                    string[] collParts = UserTreeCollection[k].Split(',');

                    int pine = Convert.ToInt32(collParts[2]);
                    int sakura = Convert.ToInt32(collParts[3]);
                    int nara = Convert.ToInt32(collParts[4]);
                    int birch = Convert.ToInt32(collParts[5]);
                    int oak = Convert.ToInt32(collParts[6]);

                    totalCollected = pine + sakura + nara + birch + oak;

                }
                int oldTotalCollected = Convert.ToInt32(parts[6]);

                if (totalCollected > oldTotalCollected) 
                {
                    parts[6] = totalCollected.ToString();
                }
                Users[i] = string.Join(",", parts);
                
                break;
            }
        }
        File.WriteAllLines("Users.txt", Users);
    }
    private string GenerateTree(string userName)
    {
        string treeType = "";
        int treeGen = rnd.Next(1, 6);
        switch (treeGen)
        {
            case 1:
                treeType = "Pine Tree";
                break;
            case 2:
                treeType = "Sakura Tree";
                break;
            case 3:
                treeType = "Nara Tree";
                break;
            case 4:
                treeType = "Birch Tree";
                break;
            case 5:
                treeType = "Oak Tree";
                break;
        }

        for (int i = 0; i < UserTreeCollection.Count; i++)
        {
            string[] parts = UserTreeCollection[i].Split(',');

            if (parts[1] == userName)
            {
                switch (treeType) 
                {
                    case "Pine Tree":
                        parts[2] = "1";
                        break;
                    case "Sakura Tree":
                        parts[3] = "1";
                        break;
                    case "Nara Tree":
                        parts[4] = "1";
                        break;
                    case "Birch Tree":
                        parts[5] = "1";
                        break;
                    case "Oak Tree":
                        parts[6] = "1";
                        break;
                }
                UserTreeCollection[i] = string.Join(",", parts);
            }
        }
        File.WriteAllLines("UserTrees.txt", UserTreeCollection);
        return treeType;
    }
}
