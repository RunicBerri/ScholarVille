using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

public class Snake
{
    static int width = 30;
    static int height = 20;

    static int foodX, foodY;
    public int snakeScore = 0;

    static string direction = "RIGHT";

    static List<(int x, int y)> snakeSpawn = new List<(int, int)>();
    static Random random = new Random();
    public Snake(int startX, int startY)
    {
        snakeSpawn.Add((startX, startY));
    }
    public void SpawnFood()
    {
        foodX = random.Next(1, width - 1);
        foodY = random.Next(1, height - 1);
    }

    public void Start(string username) 
    {
        Console.CursorVisible = false;

        SpawnFood();

        while (true)
        {
            Input();
            Update();
            Draw();

            Thread.Sleep(100);
        }
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
            }
        }
    }

    public void Update()
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
            GameOver();
        }

        foreach (var segment in snakeSpawn)
        {
            if (headX == segment.x && headY == segment.y)
            {
                GameOver();
            }
        }

        snakeSpawn.Insert(0, (headX, headY));

        if (headX == foodX && headY == foodY)
        {
            snakeScore++;
            SpawnFood();
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

                    foreach (var segment in snakeSpawn)
                    {
                        if (segment.x == x && segment.y == y)
                        {
                            Console.Write("O");
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

        Console.WriteLine($"Score: {snakeScore}");
        Console.WriteLine("Controls: W A S D");
    }

    public void GameOver()
    {
        Console.Clear();
        Console.WriteLine("GAME OVER!");
        Console.WriteLine($"Final Score: {snakeScore}");
        Environment.Exit(0);
    }
}
