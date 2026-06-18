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
        static ASCII ascii = new ASCII();
        static void Main()
        {
            Start();
        }
        static void Start()
        {
            Console.CursorVisible = false;
            CreateFile("UserTrees.txt");
            CreateFile("UserFish.txt");
            CreateFile("Users.txt");
            Users = File.ReadAllLines("Users.txt").ToList();

            while (true) 
            {
                Console.CursorVisible = false;
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Scholarville();
                Console.ResetColor();
                ascii.StartMenu();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ResetColor();
                ConsoleKey input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();

                        Console.WriteLine("=========================================================================================");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        ascii.Login();
                        ascii.Selected();
                        Console.ResetColor();
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        Login();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("=========================================================================================");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        ascii.Register();
                        ascii.Selected();
                        Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        ascii.InvalidInput();
                        Console.WriteLine("                                 Please try again.");
                        Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                ascii.Register();
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                Console.WriteLine("                               Enter your Username: ");
                Console.WriteLine("                             (Type \"return\" to Return)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                string inputUser = Console.ReadLine();
                Console.Clear();
                if (inputUser == "")
                { 
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    ascii.InvalidInput();
                    Console.WriteLine("                          Please Enter Username. Try again.                         ");
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
                    Console.WriteLine("                                  User Already Exists. ");
                    Console.ResetColor();
                    Console.WriteLine("=========================================================================================");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                ascii.Register();
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                Console.WriteLine("                               Enter your Password: ");
                Console.WriteLine("                             (Type \"return\" to Return)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                string inputPass = Console.ReadLine();
                Console.Clear();
                if (inputPass == "")
                {
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    ascii.InvalidInput();
                    Console.WriteLine("                          Please Enter Password. Try again.                         ");
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
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                ascii.Register();
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                Console.WriteLine("                                 Confirm Password: ");
                Console.WriteLine("                             (Type \"return\" to Return)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                string confirm = Console.ReadLine();
                Console.Clear();
                if (confirm != inputPass)
                {
                    
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    ascii.InvalidInput();
                    Console.WriteLine("                         Passwords do not match! Try again.");
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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=========================================================================================");
            ascii.Register();
            Console.WriteLine("=========================================================================================");
            Console.ResetColor();
            Console.WriteLine("                              Registration Succesfull!                                  ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=========================================================================================");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        static void Login()
        {
            string inputUser = "";
            string inputPass = "";

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                ascii.Login();
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                Console.WriteLine("                                Enter your Username: ");
                Console.WriteLine("                               (Press Enter to Return)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                inputUser = Console.ReadLine();
                Console.Clear();

                if (inputUser == "" || inputUser == "return")
                {
                    Console.Clear();
                    Start();
                    return;
                }

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
                ascii.Login();
                Console.WriteLine("=========================================================================================");
                Console.ResetColor();
                Console.WriteLine("                                Enter your Password: ");
                Console.WriteLine("                               (Press Enter to Return)");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("=========================================================================================");
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
                
                Console.WriteLine("=========================================================================================");
                Console.ForegroundColor = ConsoleColor.Red;
                ascii.InvalidInput();
                Console.WriteLine("                              Invalid User or Password");
                Console.WriteLine("                                     Returning...");
                Console.ResetColor();
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
                
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Scholarville();
                Console.ResetColor();
                ascii.MainMenu();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.ResetColor();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
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
                        Achievements(userName);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        UserCollection(userName);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        SDGs();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.WriteLine("=========================================================================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        ascii.LogOut();
                        Console.ResetColor();
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("=========================================================================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        ascii.InvalidInput();
                        Console.ResetColor();
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
                
                Console.WriteLine("_________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                ascii.Scholarville();
                Console.ResetColor();
                ascii.GameMenu();
                Console.ResetColor();
                Console.WriteLine("-----------------------------------------------------------------------------------------");
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
                        Console.WriteLine("=========================================================================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        ascii.InvalidInput();
                        Console.ResetColor();
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
        static void Achievements(string userName) { }
        static void UserCollection(string userName) { }
        static void SDGs() { }
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
