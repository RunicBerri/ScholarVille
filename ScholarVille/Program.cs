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
        static void Main()
        {
            Start();
        }
        static void Start()
        {
            CreateFile("UserTrees.txt");
            CreateFile("UserFish.txt");
            CreateFile("Users.txt");
            Users = File.ReadAllLines("Users.txt").ToList();

            while (true) 
            {
                Console.CursorVisible = false;

                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.WriteLine("=========================================================================================");
                Console.WriteLine("░██████╗░█████╗░██╗░░██╗░█████╗░██╗░░░░░█████╗░██████╗░██╗░░░██╗██╗██╗░░░░██╗░░░░███████╗");
                Console.WriteLine("██╔════╝██╔══██╗██║░░██║██╔══██╗██║░░░░██╔══██╗██╔══██╗██║░░░██║██║██║░░░░██║░░░░██╔════╝");
                Console.WriteLine("╚█████╗░██║░░╚═╝███████║██║░░██║██║░░░░███████║██████╔╝██║░░░██║██║██║░░░░██║░░░░█████╗░░");
                Console.WriteLine("░╚═══██╗██║░░██╗██╔══██║██║░░██║██║░░░░██╔══██║██╔══██╗╚██╗░██╔╝██║██║░░░░██║░░░░██╔══╝░░");
                Console.WriteLine("██████╔╝╚█████╔╝██║░░██║╚█████╔╝██████╗██║░░██║██║░░██║░╚████╔╝░██║██████╗██████╗███████╗");
                Console.WriteLine("╚═════╝░░╚════╝░╚═╝░░╚═╝░╚════╝░╚═════╝╚═╝░░╚═╝╚═╝░░╚═╝░░╚═══╝░░╚═╝╚═════╝╚═════╝╚══════╝");
                Console.WriteLine("=========================================================================================");

                Console.ResetColor();
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("|                                 Login or Register:                                    |");
                Console.WriteLine("|                                    [1] Login                                          |");
                Console.WriteLine("|                                    [2] Register                                       |");
                Console.WriteLine("|                                    [3] Exit                                           |");
                Console.WriteLine("=========================================================================================");
                ConsoleKey input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                      Login Selected");
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        Login();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                     Register Selected");
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
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
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                  Invalid Input. Try Again");
                        Console.WriteLine("=========================================================================================");
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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                  Enter your Username: ");
                Console.WriteLine("                                 (Type \"return\" to Return)");
                Console.WriteLine("=========================================================================================");
                string inputUser = Console.ReadLine();
                if (inputUser == "")
                {
                    Console.WriteLine("=========================================================================================");
                    Console.WriteLine("                          Please Enter Username. Try again.                         ");
                    Console.WriteLine("=========================================================================================");
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
                    Console.WriteLine("                                  User Already Exists. ");
                    Console.WriteLine("=========================================================================================");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                  Enter your Password: ");
                Console.WriteLine("                                 (Type \"return\" to Return)");
                Console.WriteLine("=========================================================================================");
                string inputPass = Console.ReadLine();
                if (inputPass == "")
                {
                    Console.WriteLine("=========================================================================================");
                    Console.WriteLine("                           Please Enter Password. Try again.                         ");
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
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                   Confirm Password: ");
                Console.WriteLine("                                 (Type \"return\" to Return)");
                Console.WriteLine("=========================================================================================");
                string confirm = Console.ReadLine();
                Console.Clear();
                if (confirm != inputPass)
                {
                    Console.WriteLine("=========================================================================================");
                    Console.WriteLine("                         Passwords do not match! Try again.                                  ");
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
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                               Registration Succesfull!                                  ");
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
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                           LOGIN");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                  Enter your Username: ");
                Console.WriteLine("                                  (Press Enter to Return)");
                Console.WriteLine("=========================================================================================");
                inputUser = Console.ReadLine();

                if (inputUser == "" || inputUser == "return")
                {
                    Console.Clear();
                    Start();
                    return;
                }

                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                  Enter your Password: ");
                Console.WriteLine("                                  (Press Enter to Return)");
                Console.WriteLine("=========================================================================================");
                inputPass = Console.ReadLine();

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
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                  Invalid User or Password");
                Console.WriteLine("                                         Returning...");
                Console.WriteLine("=========================================================================================");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
        static void MainMenu(string userName) 
        {
            while (true)
            {
                Console.CursorVisible = false;

                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.WriteLine("=========================================================================================");
                Console.WriteLine("░██████╗░█████╗░██╗░░██╗░█████╗░██╗░░░░░█████╗░██████╗░██╗░░░██╗██╗██╗░░░░██╗░░░░███████╗");
                Console.WriteLine("██╔════╝██╔══██╗██║░░██║██╔══██╗██║░░░░██╔══██╗██╔══██╗██║░░░██║██║██║░░░░██║░░░░██╔════╝");
                Console.WriteLine("╚█████╗░██║░░╚═╝███████║██║░░██║██║░░░░███████║██████╔╝██║░░░██║██║██║░░░░██║░░░░█████╗░░");
                Console.WriteLine("░╚═══██╗██║░░██╗██╔══██║██║░░██║██║░░░░██╔══██║██╔══██╗╚██╗░██╔╝██║██║░░░░██║░░░░██╔══╝░░");
                Console.WriteLine("██████╔╝╚█████╔╝██║░░██║╚█████╔╝██████╗██║░░██║██║░░██║░╚████╔╝░██║██████╗██████╗███████╗");
                Console.WriteLine("╚═════╝░░╚════╝░╚═╝░░╚═╝░╚════╝░╚═════╝╚═╝░░╚═╝╚═╝░░╚═╝░░╚═══╝░░╚═╝╚═════╝╚═════╝╚══════╝");
                Console.WriteLine("=========================================================================================");

                Console.ResetColor();
                Console.WriteLine($"|                              Welcome to ScholarVille!                                 |");
                Console.WriteLine($"|                                    [1] Play Games                                     |");
                Console.WriteLine($"|                                    [2] My Scores                                      |");
                Console.WriteLine($"|                                    [3] Achievements                                   |");
                Console.WriteLine($"|                                    [4] What are SDGs?                                 |");
                Console.WriteLine($"|                                    [5] Logout                                         |");
                Console.WriteLine("=========================================================================================");
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
                        Console.WriteLine("Achievements");
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("SDG definitions");
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                       Logging Out...");
                        Console.WriteLine("=========================================================================================");
                        Thread.Sleep(1000);
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                       Invalid Input.");
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        static void GameMenu(string userName)
        {
            while (true)
            {
                string input = "";
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("░██████╗░█████╗░██╗░░██╗░█████╗░██╗░░░░░█████╗░██████╗░██╗░░░██╗██╗██╗░░░░██╗░░░░███████╗");
                Console.WriteLine("██╔════╝██╔══██╗██║░░██║██╔══██╗██║░░░░██╔══██╗██╔══██╗██║░░░██║██║██║░░░░██║░░░░██╔════╝");
                Console.WriteLine("╚█████╗░██║░░╚═╝███████║██║░░██║██║░░░░███████║██████╔╝██║░░░██║██║██║░░░░██║░░░░█████╗░░");
                Console.WriteLine("░╚═══██╗██║░░██╗██╔══██║██║░░██║██║░░░░██╔══██║██╔══██╗╚██╗░██╔╝██║██║░░░░██║░░░░██╔══╝░░");
                Console.WriteLine("██████╔╝╚█████╔╝██║░░██║╚█████╔╝██████╗██║░░██║██║░░██║░╚████╔╝░██║██████╗██████╗███████╗");
                Console.WriteLine("╚═════╝░░╚════╝░╚═╝░░╚═╝░╚════╝░╚═════╝╚═╝░░╚═╝╚═╝░░╚═╝░░╚═══╝░░╚═╝╚═════╝╚═════╝╚══════╝");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine($"|                              Come and play while learning!                            |");
                Console.WriteLine($"|                                    [1] Eco Snake                                      |");
                Console.WriteLine($"|                                    [2] News Detective                                 |");
                Console.WriteLine($"|                                    [3] Grow a Tree                                    |");
                Console.WriteLine($"|                                    [4] Sea Life Hero                                  |");
                Console.WriteLine($"|                                    [5] SDG Quiz                                       |");
                Console.WriteLine($"|                                    [6] Return                                         |");
                Console.WriteLine("=========================================================================================");
                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        SnakeGame(userName);
                        break;
                    case "2":
                        RealorFake(userName);
                        break;
                    case "3":
                        TreePlant(userName);
                        break;
                    case "4":
                        FishingGame(userName);
                        break;
                    case "5":
                        QuizGame(userName);
                        break;
                    case "6":
                        MainMenu(userName);
                        break;
                    default:
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                       Invalid Input.");
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        static void MyScores(string userName)
        {
            Users = File.ReadAllLines("Users.txt").ToList();
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("                                       My Scores");
            Console.WriteLine("=========================================================================================");
            
            for (int i = 0; i < Users.Count; i++)
            {
                string[] parts = Users[i].Split(',');

                if (parts[1] == userName)
                {
                    Console.WriteLine($"Name: {parts[1]}");
                    Console.WriteLine($"Total Trash Collected: {parts[3]}");
                    Console.WriteLine($"Real and Fakes News Identified: {parts[4]}");
                    Console.WriteLine($"Total Trees Planted: {parts[5]}");
                    Console.WriteLine($"Unique Trees Collected: {parts[6]}");
                    Console.WriteLine($"Total Fish Caught: {parts[7]}");
                    Console.WriteLine($"Unique Fish Caught: {parts[8]}");
                    Console.WriteLine($"Highest SDG Quiz Score: {parts[9]}");
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
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
