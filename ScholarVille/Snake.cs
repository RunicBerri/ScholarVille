using ScholarVille;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class Snake
{
    //needs better ui
    //tweak to my liking

    int width = 89;
    int height = 20;

    int foodX, foodY;
    int snakeScore = 0;
    bool play = true;

    string direction = "RIGHT";

    static List<string> Users = new List<string>();

    List<(int x, int y)> snakeSpawn = new List<(int, int)>();
    static ASCII ascii = new ASCII();
    static Random rnd = new Random();
    public Snake(int startX, int startY)
    {
        snakeSpawn.Add((startX, startY));
        snakeSpawn.Add((startX - 1, startY));
        snakeSpawn.Add((startX - 2, startY)); ;
    }
    public void SpawnTrash()
    {
        foodX = rnd.Next(1, width - 1);
        foodY = rnd.Next(1, height - 1);
    }

    public void Start(string userName) 
    {
        Users = File.ReadAllLines("Users.txt").ToList();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        play = true;
        Console.WriteLine("_________________________________________________________________________________________");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                                          Eco Snake                                    |");
        Console.WriteLine("|_______________________________________________________________________________________|");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine("|                        SDG 12: Responsible Consumption and Production                 |");
        Console.WriteLine("|                  Grow your cleanup crew by collecting trash and help support!         |");
        Console.WriteLine("|                                                                                       |");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
        Console.ResetColor();
        Console.WriteLine("|                                   Press any key to start.                             |");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("|_______________________________________________________________________________________|");
        ConsoleKey input = Console.ReadKey(true).Key;
        Console.Clear();
        if (input == ConsoleKey.X)
        {
            ascii.Returning();
            Thread.Sleep(1000);
            Console.Clear();
            return;
        }

        Console.CursorVisible = false;

        SpawnTrash();

        while (play)
        {
            Input();
            Update(userName);
            Draw();

            Thread.Sleep(100);
        }
        Console.Clear();
        ascii.Returning();
        Thread.Sleep(1000);
        Console.Clear();
        return;
    }

    public void Input()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.W:
                    if (direction != "DOWN")
                        direction = "UP";
                    break;

                case ConsoleKey.S:
                    if (direction != "UP")
                        direction = "DOWN";
                    break;

                case ConsoleKey.A:
                    if (direction != "RIGHT")
                        direction = "LEFT";
                    break;

                case ConsoleKey.D:
                    if (direction != "LEFT")
                        direction = "RIGHT";
                    break;
                case ConsoleKey.X:
                    play = false;
                    break;
            }
        }
    }

    public void Update(string userName)
    {
        int headX = snakeSpawn[0].x;
        int headY = snakeSpawn[0].y;

        switch (direction)
        {
            case "UP":
                headY--;
                break;
            case "DOWN":
                headY++;
                break;
            case "LEFT":
                headX--;
                break;
            case "RIGHT":
                headX++;
                break;
        }

        if (headX <= 0 || headX >= width - 1 ||
            headY <= 0 || headY >= height - 1)
        {
            GameOver(userName);
        }

        foreach (var segment in snakeSpawn)
        {
            if (headX == segment.x && headY == segment.y)
            {
                GameOver(userName);
            }
        }

        snakeSpawn.Insert(0, (headX, headY));

        if (headX == foodX && headY == foodY)
        {
            snakeScore++;
            SpawnTrash();
        }
        else
        {
            snakeSpawn.RemoveAt(snakeSpawn.Count - 1);
        }
    }

    public void Draw()
    {
        Console.SetCursorPosition(0, 0);

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x == 0 || x == width - 1 ||
                    y == 0 || y == height - 1)
                {
                    Console.Write("#");
                }
                else if (x == foodX && y == foodY)
                {
                    Console.Write("*");
                }
                else
                {
                    bool snakePart = false;

                    for (int i = 0; i < snakeSpawn.Count; i++)
                    {
                        if (snakeSpawn[i].x == x && snakeSpawn[i].y == y)
                        {
                            if (i == 0)
                            {
                                switch (direction)
                                {
                                    case "UP":
                                        Console.Write("^");                 
                                        break;

                                    case "DOWN":
                                        Console.Write("v");
                                        break;

                                    case "LEFT":
                                        Console.Write("<");
                                        break;

                                    case "RIGHT":
                                        Console.Write(">");
                                        break;
                                }
                            }
                            else
                            {
                                Console.Write("O");
                            }

                            snakePart = true;
                            break;
                        }
                    }

                    if (!snakePart)
                        Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
        Console.WriteLine("_________________________________________________________________________________________");
        Console.WriteLine("|                                                                                       |");
        Console.WriteLine($"|                                         Score: {snakeScore}                                      |");
        Console.WriteLine("|                                     Controls: W A S D                                 |");
        Console.WriteLine("|                                Press \"X\" to leave the game.                           |");
        Console.WriteLine("|_______________________________________________________________________________________|");
    }

    public void GameOver(string userName)
    {
        play = false;
        

        while (true) 
        {
            Console.Clear();
            Console.WriteLine("_________________________________________________________________________________________");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                      GAME OVER!                                       |");
            Console.WriteLine("|_______________________________________________________________________________________|");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine($"|                                   Final Score: {snakeScore}                                      |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|       Good job! Your crew have reduce the waste and kept your surroundings clean!     |");
            Console.WriteLine("|                                                                                       |");
            Console.WriteLine("|                                    Play Again?  (Y/N)                                 |");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                Console.Clear();
                ResetGame();
                Console.ResetColor();
                UpdateInfo(userName, snakeScore);
                Start(userName);
                break;
            }
            else if(input == "n") 
            {
                Console.WriteLine("|                                Press any key to exit.                                 |");
                Console.WriteLine("|_______________________________________________________________________________________|");
                UpdateInfo(userName, snakeScore);
                Console.ReadKey();
                break;
            }
        }
    }

    private void ResetGame()
    {
        snakeSpawn.Clear();

        snakeSpawn.Add((45, 10));
        snakeSpawn.Add((44, 10));
        snakeSpawn.Add((43, 10));

        snakeScore = 0;
        direction = "RIGHT";

        SpawnTrash();
    }
    public void UpdateInfo(string userName, int snakeScore)
    {
        for (int i = 0; i < Users.Count; i++)
        {
            string[] parts = Users[i].Split(',');

            if (parts[1] == userName)
            {
                int newScore = Convert.ToInt32(parts[3]);
                newScore += snakeScore;

                parts[3] = newScore.ToString();
                Users[i] = string.Join(",", parts);

                break;
            }
        }
        File.WriteAllLines("Users.txt", Users);
    }
}
