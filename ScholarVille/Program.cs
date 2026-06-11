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
            RealorFake();
        }

        static void SnakeGame() 
        {
            Snake snake = new Snake(5,5);
            snake.Start();
        }

        static void RealorFake() 
        {
            RoF rof = new RoF();
            rof.Start();
        }
    }
}
