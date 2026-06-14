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

    private int fertilizer = 0;
	private int water = 0;
	private int growth = 0;
    private bool game = true;
    private bool win = false;

	private Random rnd = new Random();
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
        Console.WriteLine("                                      Press any key to start.");
        string input1 = Console.ReadLine().ToLower();
        if (input1 == "x")
        {
            Console.WriteLine("Returning to Game Selection.");
            Console.WriteLine("Press any key to continue.");
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
                Console.WriteLine("Returning to Game Selection.");
                Console.WriteLine("Press any key to continue.");
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

            if (parts[1] == userName)
            {
                int newScore = Convert.ToInt32(parts[5]);
                newScore++;

                parts[5]= newScore.ToString();
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
                        parts[2] = "true";
                        break;
                    case "Sakura Tree":
                        parts[3] = "true";
                        break;
                    case "Nara Tree":
                        parts[4] = "true";
                        break;
                    case "Birch Tree":
                        parts[5] = "true";
                        break;
                    case "Oak Tree":
                        parts[6] = "true";
                        break;
                }
                UserTreeCollection[i] = string.Join(",", parts);
            }
        }
        File.WriteAllLines("UserTrees.txt", UserTreeCollection);
        return treeType;
    }
}
