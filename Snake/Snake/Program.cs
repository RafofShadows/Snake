using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            topLine.Draw();
            HorizontalLine botLine = new HorizontalLine(0, 78, 24, '+');
            botLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            rightLine.Draw();

            Point tail = new Point(3, 3, '*');
            Snake snake = new Snake(tail, 5, Direction.RIGHT);
            snake.Draw();

            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
