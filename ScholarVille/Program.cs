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

        //game objects
        static Snake snake = new Snake(5, 5);
        static RoF rof = new RoF();

        static void Main()
        {
            Start();
        }

        static void Start()
        {
            CreateFile("Users.txt");
            Users = File.ReadAllLines("Users.txt").ToList();

            string input = "";
            while (true)
            {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                     ScholarVille                ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine($"|                                 Login or Register:                                     |");
                Console.WriteLine($"|                                    [1] Login                                           |");
                Console.WriteLine($"|                                    [2] Register                                        |");
                Console.WriteLine($"|                                    [3] Exit                                            |");
                Console.WriteLine("=========================================================================================");
                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                      Login Selected");
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        Login();
                        break;
                    case "2":
                        Console.WriteLine("=========================================================================================");
                        Console.WriteLine("                                     Register Selected");
                        Console.WriteLine("=========================================================================================");
                        Console.ReadKey();
                        Console.Clear();
                        Register();
                        Users = File.ReadAllLines("Users.txt").ToList();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
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
                bool exists = false;

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
                    exists = false;
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
                int snakeScore = 0;
                int rofScore = 0;
                int jeepScore = 0;

                File.AppendAllText("Users.txt", $"{userID},{inputUser},{inputPass},{snakeScore},{rofScore},{jeepScore}{Environment.NewLine}");
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
                string input = "";
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                                     ScholarVille                ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine($"|                              Welcome to ScholarVille!                                  |");
                Console.WriteLine($"|                                    [1] Trash Collector!                                |");
                Console.WriteLine($"|                                    [2] Real or Fake!?                                  |");
                Console.WriteLine($"|                                    [3] n/a                                             |");
                Console.WriteLine($"|                                    [4] n/a                                             |");
                Console.WriteLine($"|                                    [5] n/a                                             |");
                Console.WriteLine($"|                                    [6] Logout                                          |");
                Console.WriteLine("=========================================================================================");
                input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        SnakeGame();
                        break;
                    case "2":
                        RealorFake();
                        break;
                    case "3":
                        Console.WriteLine("Management Sim");
                        break;
                    case "4":
                        Console.WriteLine("N/A");
                        break;
                    case "5":
                        Console.WriteLine("N/A");
                        break;
                    case "6":
                        Start();
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

        static void SnakeGame() 
        {
            snake.Start();
        }
        static void RealorFake() 
        {
            rof.Start();
        }
    }
}
