using ScholarVille;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class TreePlanter
{
    //needs better ui

    int fertilizer = 0;
	int water = 0;
	int growth = 0;
    bool game = true;
    bool win = false;

	Random rnd = new Random();
    static ASCII ascii = new ASCII();
    static List<string> Users = new List<string>();
    static List<string> UserTreeCollection = new List<string>();

    public void Start(string userName)
    {
        Console.Clear();
        UserTreeCollection = File.ReadAllLines("UserTrees.txt").ToList();
        Users = File.ReadAllLines("Users.txt").ToList();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("_________________________________________________________________________________________");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                      Grow A Tree                                      |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                 SDG 15 - Life on Land                                 |");
        Console.WriteLine("|                 Care for your tree by giving it what it needs to grow                 |");
        Console.WriteLine("|                                and help create a greener world.                       |");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                                                                       |");       
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
        Console.ResetColor();
        Console.WriteLine("|                                   Press any key to start.                             |");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine($"|                                    Tree Growth : {growth}");
            Console.WriteLine($"|                                    Feritilizer  : {fertilizer}");
            Console.WriteLine($"|                                    Water       : {water}");
            Console.WriteLine("|                                                                                       |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
            Console.ResetColor();
            Console.WriteLine("|                               Press \"A\",\"W\",\"D\" to explore.                           |");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.ResetColor();
            string input2 = Console.ReadLine().ToLower();
            switch (input2) 
            {

                case "a":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                 You went left and...                                  |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    break;
                case "w":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                               You went forward and...                                 |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    break;
                case "d":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                You went right and...                                  |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    break;
                case "x":
                    Console.Clear();
                    ascii.Returning();
                    Thread.Sleep(1000);
                    Console.Clear();
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                      Invalid Input                                    |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                    continue;
            }

            int item = rnd.Next(1, 9);

            switch (item)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                           You found a sack of fertilizer!                             |");
                    Console.WriteLine("|                              <You gained 1 fertilizer>                                |");
                    
                    fertilizer++;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                          EW! You found a huge animal poop!                            |");
                    Console.WriteLine("|                              <You gained 1 fertilizer>                                |");
                    
                    fertilizer++;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                           You found A lot of food waste!                              |");
                    Console.WriteLine("|                              <You gained 1 fertilizer>                                |");
                    
                    fertilizer++;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                             You found a gallon of water!                              |");
                    Console.WriteLine("|                                 <You gained 1 water>                                  |");
                    
                    water++;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                           WOW! You found a very clean pond!                           |");
                    Console.WriteLine("|                                 <You gained 1 water>                                  |");
                    
                    water++;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                Rain suddenly started!                                 |");
                    Console.WriteLine("|                                 <You gained 1 water>                                  |");
                    
                    water++;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                            Oof! A pest attacked your tree!                            |");
                    Console.WriteLine("|                             <Your Tree lost 2% of growth>                             |");
                    
                    growth -= 2;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_________________________________________________________________________________________");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                      OH NO! A swarm of pests attacked your tree!                      |");
                    Console.WriteLine("|                            <Your Tree lost 10% of growth>                             |");
                    
                    growth -= 10;
                    break;
            }
            if (fertilizer > 0 && water > 0)
            {
                fertilizer--;
                water--;
                growth += 10;

                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                           <Your Tree gained 10% of growth>                            |");
                Console.WriteLine("|                                                                                       |");
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

            Console.WriteLine("|                              Press any key to continue.                               |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        if (win == false)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                      GAME OVER!                                       |");
            Console.WriteLine("|                               Your sapling failed to grow.                            |");

        }
        else if (win == true) 
        {
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                       YOU WON!                                        |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|      By planting trees you are able to help reduce the effects of climate change!     |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                  Congratulations!                                     |");
            Console.WriteLine("|                                Your tree grew into a:                                 |");
            var treeType = GenerateTree(userName);
            Console.WriteLine($"|                                     {treeType}");
            
            

            UpdateInfo(userName);
        }
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                              Press any key to continue.                               |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.ReadKey();
        Console.Clear();
        Console.ResetColor();
        Restart(userName);
        return;
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
                growth = 0;
                fertilizer = 0;
                water = 0;
                Start(userName);
            }
            else if (input == "n")
            {
                Console.Clear();
                ascii.Returning();
                Thread.Sleep(1000);
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
                    int oak= Convert.ToInt32(collParts[3]);
                    int narra = Convert.ToInt32(collParts[4]);
                    int birch = Convert.ToInt32(collParts[5]);
                    int sakura = Convert.ToInt32(collParts[6]);

                    totalCollected = pine + oak + narra + birch + sakura;

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
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.PineArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case 2:
                treeType = "Oak Tree";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.PineArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case 3:
                treeType = "Narra Tree";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.NarraArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case 4:
                treeType = "Birch Tree";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.BirchArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            case 5:
                treeType = "Sakura Tree";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.SakuraArt();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                    case "Oak Tree":
                        parts[3] = "1";
                        break;
                    case "Narra Tree":
                        parts[4] = "1";
                        break;
                    case "Birch Tree":
                        parts[5] = "1";
                        break;
                    case "Sakura Tree":
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
