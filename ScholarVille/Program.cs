using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScholarVille
{
    internal class Program
    {
        static void Main()
        {

        }

        static void SnakeGame() 
        {
            Snake snake = new Snake(5,5);
            Console.CursorVisible = false;

            snake.SpawnFood();

            while (true)
            {
                snake.Input();
                snake.Update();
                snake.Draw();
                 

                Thread.Sleep(100);
            }
        }

        static void RealorFake() 
        {
            RoF rof = new RoF();
        }
    }
}
