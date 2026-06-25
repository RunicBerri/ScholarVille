using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace ScholarVille
{
    internal class Program
    {
        static List<string> Users = new List<string>();
        static List<string> UserTreeCollection = new List<string>();
        static List<string> UserFishCollection = new List<string>();
        static ASCII ascii = new ASCII();
        static void Main()
        {
            Start();
        }
        static void Start()
        {
            Console.CursorVisible = false;
            CreateFile("Users.txt");
            CreateFile("UserTrees.txt");
            CreateFile("UserFish.txt");
            Users = File.ReadAllLines("Users.txt").ToList();
            UserTreeCollection = File.ReadAllLines("UserTrees.txt").ToList();
            UserFishCollection = File.ReadAllLines("UserFish.txt").ToList();

            while (true) 
            {
                Console.CursorVisible = false;
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Scholarville();
                Console.ResetColor();
                ascii.StartMenu();
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ResetColor();
                ConsoleKey input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();

                        ascii.LoginSelected();
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        Console.Clear();
                        Login();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        ascii.RegisterSelected();
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        Console.Clear();
                        Register();
                        Users = File.ReadAllLines("Users.txt").ToList();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        ascii.InvalidInput();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            
        }
        static void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                var fl = File.Create(fileName);
                fl.Close();
            }
        }
        static void Register()
        {
            Console.CursorVisible = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Register();
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                   Enter your Username:                                |");
                Console.WriteLine("|                                (Type \"return\" to Return)                              |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.ResetColor();
                
                string inputUser = Console.ReadLine();
                Console.Clear();
                if (inputUser == "")
                { 
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    ascii.InvalidInput();
                    Console.WriteLine("|                           Please Enter Username. Try again.                           |");
                    Console.ResetColor();
                    Console.WriteLine("=========================================================================================");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (inputUser == "return")
                {
                    Console.Clear();
                    Start();
                    return;
                }

                bool existing = Users.Any(u => u.Split(',')[1] == inputUser);

                if (existing == true)
                {
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    ascii.InvalidInput();               
                    Console.WriteLine("|                                  User Already Exists.                                 |");
                    Console.ResetColor();
                    Console.WriteLine("=========================================================================================");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Register();
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                   Enter your Password:                                |");
                Console.WriteLine("|                                (Type \"return\" to Return)                              |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.ResetColor();
                string inputPass = Console.ReadLine();
                Console.Clear();
                if (inputPass == "")
                {
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    ascii.InvalidInput();
                    Console.WriteLine("|                            Please Enter Password. Try again.                          |");
                    Console.ResetColor();
                    Console.WriteLine("=========================================================================================");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (inputPass == "return")
                {
                    Console.Clear();
                    Start();
                    return;
                }
                Console.Clear();
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Register();
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                  Confirm your Password:                               |");
                Console.WriteLine("|                                (Type \"return\" to Return)                              |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.ResetColor();
                string confirm = Console.ReadLine();
                Console.Clear();
                if (confirm != inputPass)
                {
                    
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    ascii.InvalidInput();
                    Console.WriteLine("|                         Passwords do not match! Try again.                            |");
                    Console.ResetColor();
                    Console.WriteLine("=========================================================================================");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                int nextNumber = Users.Count + 1;
                string userID = "U" + nextNumber.ToString("D3");

                //labels
                int trashCollected = 0;
                int rofScore = 0;
                int treesPlanted = 0;
                int treesCollected = 0;
                int fishCaught = 0;
                int fishCollected = 0;
                int quizHiScore = 0;

                File.AppendAllText("Users.txt", $"{userID},{inputUser},{inputPass}," +
                    $"{trashCollected}," +
                    $"{rofScore}," +
                    $"{treesPlanted}," +
                    $"{treesCollected}," +
                    $"{fishCaught}," +
                    $"{fishCollected}," +
                    $"{quizHiScore}" +
                    $"{Environment.NewLine}");

                File.AppendAllText("UserTrees.txt", $"{userID},{inputUser},0,0,0,0,0{Environment.NewLine}");
                File.AppendAllText("UserFish.txt", $"{userID},{inputUser},0,0,0,0,0{Environment.NewLine}");
                break;
            }
            Console.Clear();
            Console.WriteLine("=========================================================================================");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            ascii.RegisterSelected();
            Console.ResetColor();
            Console.WriteLine("=========================================================================================");
            Console.ReadKey();
            Console.Clear();
        }
        static void Login() 
        {
            string inputUser = "";
            string inputPass = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Login();
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                   Enter your Username:                                |");
                Console.WriteLine("|                                (Press \"Enter\" to Return)                              |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.ResetColor();
                inputUser = Console.ReadLine();
                Console.Clear();

                if (inputUser == "" || inputUser == "return")
                {
                    Console.Clear();
                    Start();
                    return;
                }

                Console.Clear();
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Login();
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                   Enter your Password:                                |");
                Console.WriteLine("|                                (Press \"Enter\" to Return)                              |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                                                                       |");
                Console.ResetColor();
                inputPass = Console.ReadLine();
                Console.Clear();

                if (inputPass == "" || inputPass == "return")
                {
                    Console.Clear();
                    Start();
                    return;
                }

                for (int i = 0; i < Users.Count; i++)
                {
                    string[] parts = Users[i].Split(',');

                    string userName = parts[1];
                    string userPass = parts[2];

                    if (inputUser == userName && inputPass == userPass)
                    {
                        Console.Clear();
                        MainMenu(userName);
                        return;
                    }
                }
                
                
                ascii.InvalidInput();
                Console.WriteLine("                         Invalid User or Password. Now Returning...");
                Console.ResetColor();
                
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
        static void MainMenu(string userName) 
        {
            while (true)
            {
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Scholarville();
                Console.ResetColor();
                ascii.MainMenu();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ResetColor();
                Console.WriteLine("|_______________________________________________________________________________________|");
                ConsoleKey input = Console.ReadKey(true).Key;
                Console.Clear();

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        GameMenu(userName);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        MyScores(userName);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Achievements(userName);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        UserCollection(userName);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        SDGs(userName);
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Logout(userName);
                        return;
                    default:  
                        Console.ForegroundColor = ConsoleColor.Red;
                        ascii.InvalidInput();
                        Console.ResetColor();  
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        static void Logout(string userName)
        {
            while (true)
            {
                Console.WriteLine("_________________________________________________________________________________________");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                   Confirm Logout?                                     |");
                Console.WriteLine("|                                                                                       |");
                Console.WriteLine("|                                     Enter (Y/N)                                       |");
                Console.WriteLine("|_______________________________________________________________________________________|");

                string input = Console.ReadLine().ToLower();
                Console.Clear();

                if (input == "y")
                {
                    ascii.LogOut();
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ResetColor();
                    Start();
                }
                else if (input == "n")
                {
                    ascii.ReturningMenu();
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ResetColor(); 
                    MainMenu(userName);
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
        static void GameMenu(string userName)
        {
            while (true)
            {
                
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Scholarville();
                Console.ResetColor();
                ascii.GameMenu();
                Console.ResetColor();
                Console.WriteLine("|_______________________________________________________________________________________|");
                ConsoleKey input = Console.ReadKey(true).Key;
                Console.Clear();

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        SnakeGame(userName);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        RealorFake(userName);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        TreePlant(userName);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        FishingGame(userName);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        QuizGame(userName);
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        MainMenu(userName);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        ascii.InvalidInput();
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        static void MyScores(string userName)
        {
            Users = File.ReadAllLines("Users.txt").ToList();
            ascii.myScore();
            Console.ResetColor();

            for (int i = 0; i < Users.Count; i++)
            {
                string[] parts = Users[i].Split(',');

                if (parts[1] == userName)
                {
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine($"|     Name: {parts[1]}                                                                           |");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine($"|     Total Trash Collected: {parts[3]}                                                         |");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine($"|     Real and Fakes News Recognized: {parts[4]}                                                 |");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine($"|     Total Trees Planted: {parts[5]}                                                            |");
                    Console.WriteLine($"|     Unique Trees Collected: {parts[6]}                                                         |");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine($"|     Total Fish Caught: {parts[7]}                                                              |");
                    Console.WriteLine($"|     Unique Fish Caught: {parts[8]}                                                             |");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine($"|     Highest SDG Quiz Score: {parts[9]}                                                         |");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                          Press any key to return to menu...                           |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }  
        }
        static void Achievements(string userName) 
        {
            Users = File.ReadAllLines("Users.txt").ToList();
            for (int i= 0; i < Users.Count; i++) 
            {
                string[] parts = Users[i].Split(',');
                if (parts[1] == userName) 
                {
                    int trashCollected = Convert.ToInt32(parts[3]);
                    int rofScore = Convert.ToInt32(parts[4]);
                    int treesPlanted = Convert.ToInt32(parts[5]);
                    int treesCollected = Convert.ToInt32(parts[6]);
                    int fishCaught = Convert.ToInt32(parts[7]);
                    int fishCollected = Convert.ToInt32(parts[8]);
                    int quizHiScore = Convert.ToInt32(parts[9]);

                    ascii.Achievement();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("|                                       Eco Snake                                       |");
                    Console.ResetColor();
                    Achievments1(trashCollected);
                    ConsoleKey input = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Achievement();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("|                                    News Detective                                     |");
                    Console.ResetColor();
                    Achievments2(rofScore);
                    ConsoleKey input2 = Console.ReadKey(true).Key;
                    Console.Clear();

                    if (input2 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Achievement();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("|                                      Grow A Tree                                      |");
                    Console.ResetColor();
                    Achievments3(treesPlanted,treesCollected);
                    ConsoleKey input3 = Console.ReadKey(true).Key;
                    Console.Clear();

                    if (input3 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }
                    ascii.Achievement();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|                                    Catch & Conserve                                   |");
                    Console.ResetColor();
                    Achievments4(fishCaught,fishCollected);
                    ConsoleKey input4 = Console.ReadKey(true).Key;
                    Console.Clear();

                    if (input4 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Achievement();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("|                                        SDG Quiz                                       |");
                    Console.ResetColor();
                    Achievments5(quizHiScore);
                    ConsoleKey input5 = Console.ReadKey(true).Key;
                    Console.Clear();

                    if (input5 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Achievments1(int trashCollected) 
        {
            //achivement 1
            if (trashCollected >= 20)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.trash1();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.trash1();
            }

            //achivement 2
            if (trashCollected >= 70)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.trash2();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.trash2();
            }

            //achivement 3
            if (trashCollected >= 150)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.trash3();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.trash3();
            }
        }
        static void Achievments2(int rofScore)
        {
            //achivement 1
            if (rofScore >= 15)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.rof1();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.rof1();
            }

            //achivement 2
            if (rofScore >= 60)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.rof2();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.rof2();
            }

            //achivement 3
            if (rofScore >= 120)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.rof3();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.rof3();
            }
        }
        static void Achievments3(int treesPlanted, int treesCollected)
        {
            //tree plant
            if (treesPlanted >= 3)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.treeP1();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.treeP1();
            }

            if (treesPlanted >= 15)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.treeP2();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.treeP2();
            }

            if (treesPlanted >= 30)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.treeP3();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.treeP3();
            }

            //tree collect
            if (treesCollected >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.treeC1();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.treeC1();
            }

            if (treesCollected >= 3)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.treeC2();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.treeC2();
            }

            if (treesCollected >= 5)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.treeC3();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.treeC3();
            }
        }
        static void Achievments4(int fishCaught, int fishCollected)
        {
            //achivement 1
            if (fishCaught >= 15)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.Fishcaught1();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.Fishcaught1();
            }

            //achivement 2
            if (fishCaught >= 60)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.Fishcaught2();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.Fishcaught2();
            }

            //achivement 3
            if (fishCaught >= 120)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.Fishcaught3();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.Fishcaught3();
            }

            //achivement 1
            if (fishCollected >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.FishCollect1();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.FishCollect1();
            }

            //achivement 2
            if (fishCollected >= 3)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.FishCollect2();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.FishCollect2();
            }

            //achivement 3
            if (fishCollected >= 5)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.FishCollect3();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.FishCollect3();
            }
        }
        static void Achievments5(int quizHiScore)
        {
            //achivement 1
            if (quizHiScore >= 10)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.sdgScore1();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.sdgScore1();
            }

            //achivement 2
            if (quizHiScore >= 14)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.sdgScore2();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.sdgScore2();
            }

            //achivement 3
            if (quizHiScore >= 17)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                ascii.sdgScore3();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.WriteLine("|                                                                                       |");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.sdgScore3();
            }
        }
        static void UserCollection(string userName)
        {
            UserTreeCollection = File.ReadAllLines("UserTrees.txt").ToList();
            UserFishCollection = File.ReadAllLines("UserFish.txt").ToList();

            for (int i = 0; i < UserTreeCollection.Count; i++)
            {
                string[] parts = UserTreeCollection[i].Split(',');
                if (parts[1] == userName)
                {
                    int pine = Convert.ToInt32(parts[2]);
                    int oak = Convert.ToInt32(parts[3]);
                    int narra = Convert.ToInt32(parts[4]);
                    int birch = Convert.ToInt32(parts[5]);
                    int sakura = Convert.ToInt32(parts[6]);

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                       Pine Tree                                       |");
                    tree1(pine);
                    Console.ResetColor();

                    ConsoleKey input = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                       Oak Tree                                        |");
                    tree2(oak);
                    Console.ResetColor();

                    ConsoleKey input2 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input2 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                       Nara Tree                                       |");
                    tree3(narra);
                    Console.ResetColor();

                    ConsoleKey input3 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input3 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                       Birch Tree                                      |");
                    tree4(birch);
                    Console.ResetColor();

                    ConsoleKey input4 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input4 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                      Sakura Tree                                      |");
                    tree5(sakura);
                    Console.ResetColor();

                    ConsoleKey input5 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input5 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }
                }
            }
            for (int i = 0; i < UserFishCollection.Count; i++)
            {
                string[] parts = UserFishCollection[i].Split(',');
                if (parts[1] == userName)
                {
                    int tilapia = Convert.ToInt32(parts[2]);
                    int milkfish = Convert.ToInt32(parts[3]);
                    int catfish = Convert.ToInt32(parts[4]);
                    int tuna = Convert.ToInt32(parts[5]);
                    int goldFish = Convert.ToInt32(parts[6]);


                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                         Tilapia                                       |");
                    fish1(tilapia);
                    Console.ResetColor();
                    ConsoleKey input = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                         Milkfish                                      |");
                    fish2(milkfish);
                    Console.ResetColor();
                    ConsoleKey input2 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input2 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                          Catfish                                      |");
                    fish3(catfish);
                    Console.ResetColor();
                    ConsoleKey input3 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input3 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                           Tuna                                        |");
                    fish4(tuna);
                    Console.ResetColor();
                    ConsoleKey input4 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input4 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }

                    ascii.Collection();
                    Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
                    Console.WriteLine("|_______________________________________________________________________________________|");
                    Console.WriteLine("|                                                                                       |");
                    Console.WriteLine("|                                        Golden Fish                                    |");
                    fish5(goldFish);
                    Console.ResetColor();
                    ConsoleKey input6 = Console.ReadKey(true).Key;
                    Console.Clear();


                    if (input6 == ConsoleKey.X)
                    {
                        Console.Clear();
                        ascii.ReturningMenu();
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(userName);
                    }
                }
            }
        }
        static void tree1(int pine)
        {
            if (pine >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.PineArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.PineArt();
            }
        }
        static void tree2(int oak)
        {
            if (oak >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.OakArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.OakArt();
            }
        }
        static void tree3(int narra)
        {
            if (narra >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.NarraArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.NarraArt();
            }
        }
        static void tree4(int birch)
        {
            if (birch >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.BirchArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.BirchArt();
            }
        }
        static void tree5(int sakura)
        {
            if (sakura >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                ascii.SakuraArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.SakuraArt();
            }
        }
        static void fish1(int tilapia) 
        {
            if (tilapia >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.TilapiaArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.TilapiaArt();
            }
        }
        static void fish2(int milkfish)
        {
            if (milkfish >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.MilkfishArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.MilkfishArt();
            }
        }
        static void fish3(int catfish)
        {
            if (catfish >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.CatfishArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.CatfishArt();
            }
        }
        static void fish4(int tuna)
        {
            if (tuna >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.TunaArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.TunaArt();
            }
        }
        static void fish5(int goldFish)
        {
            if (goldFish >= 1)
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Blue;
                ascii.GoldfishArt();
            }
            else
            {
                Console.WriteLine("|_______________________________________________________________________________________|");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                ascii.GoldfishArt();
            }
        }
        static void SDGs(string userName) 
        {
            ascii.SdgList();
            Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                     SDG 1 - No Poverty                                |");
            Console.WriteLine("|          Help everyone have enough money and resources to live a good life.           |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                     SDG 2 - Zero Hunger                               |");
            Console.WriteLine("|                   Make sure everyone has healthy food to eat every day.               |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               SDG 3 - Good Health and Well-Being                      |");
            Console.WriteLine("|                           Help people stay healthy, safe, and strong.                 |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                   SDG 4 - Quality Education                           |");
            Console.WriteLine("|                     Give every child the chance to learn and go to school.            |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            

            ConsoleKey input = Console.ReadKey(true).Key;
            Console.Clear();


            if (input == ConsoleKey.X)
            {
                Console.Clear();
                ascii.ReturningMenu();
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu(userName);
            }

            ascii.SdgList();
            Console.WriteLine("|                               Press \"X\" to return to menu.                            |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                    SDG 5 - Gender Equality                            |");
            Console.WriteLine("|            Treat boys and girls fairly and give them the same opportunities.          |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                SDG 6 - Clean Water and Sanitation                     |");
            Console.WriteLine("|                    Make sure everyone has clean water and proper toilets.             |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             SDG 7 - Affordable and Clean Energy                       |");
            Console.WriteLine("|                      Provide safe and clean energy that everyone can use.             |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                          SDG 8 - Decent Work and Economic Growth                      |");
            Console.WriteLine("|                         Help people find good jobs and earn a living.                 |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            ConsoleKey input2 = Console.ReadKey(true).Key;
            Console.Clear();


            if (input2 == ConsoleKey.X)
            {
                Console.Clear();
                ascii.ReturningMenu();
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu(userName);
            }

            ascii.SdgList();
            Console.WriteLine("|                             Press any key to return to menu...                        |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                     SDG 9 - Industry, Innovation and Infrastructure                   |");
            Console.WriteLine("|          Build useful roads, technology, and inventions that improve lives.           |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               SDG 10 - Reduced Inequalities                           |");
            Console.WriteLine("|      Give everyone a fair chance no matter who they are or where they come from.      |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                         SDG 11 - Sustainable Cities and Communities                   |");
            Console.WriteLine("|                Create clean, safe, and friendly places for people to live.            |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                       SDG 12 - Responsible Consumption and Production                 |");
            Console.WriteLine("|                     Use resources wisely and avoid wasting things.                    |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            ConsoleKey input3 = Console.ReadKey(true).Key;
            Console.Clear();


            if (input3 == ConsoleKey.X)
            {
                Console.Clear();
                ascii.ReturningMenu();
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu(userName);
            }


            ascii.SdgList();
            Console.WriteLine("|                             Press any key to return to menu...                        |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                               SDG 13 - Climate Action                                 |");
            Console.WriteLine("|                     Protect the Earth by helping stop climate change.                 |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                             SDG 14 - Life Below Water                                 |");
            Console.WriteLine("|               Keep oceans, rivers, and marine animals clean and healthy.              |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                  SDG 15 - Life on Land                                |");
            Console.WriteLine("|                 Protect forests, plants, and animals that live on land.               |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                     SDG 16 - Peace, Justice and Strong Institutions                   |");
            Console.WriteLine("|                   Promote kindness, fairness, and peaceful communities.               |");
            Console.WriteLine("|_______________________________________________________________________________________|");

            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                        SDG 17 - Partnerships for the Goals                            |");
            Console.WriteLine("|             Work together to make the world a better place for everyone.              |");
            Console.WriteLine("|_______________________________________________________________________________________|");


            ConsoleKey input4 = Console.ReadKey(true).Key;
            Console.Clear();
            ascii.ReturningMenu();
            Thread.Sleep(1000);
            Console.Clear();
            MainMenu(userName);
        }
        static void SnakeGame(string userName)
        {
            Snake snake = new Snake(5, 5);
            snake.Start(userName);
        }
        static void RealorFake(string userName)
        {
            RoF rof = new RoF();
            rof.Start(userName);
        }
        static void TreePlant(string userName)
        {
            TreePlanter treePlanter = new TreePlanter();
            treePlanter.Start(userName);
        }
        static void FishingGame(string userName)
        {
            Fishing fishing = new Fishing();
            fishing.Start(userName);
        }
        static void QuizGame(string userName)
        {
            SDGquiz sdgQuiz = new SDGquiz();
            sdgQuiz.Start(userName);
        } 
    }
}
