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
            Wall wall = new Wall(80, 25);
            wall.Draw();

            FoodGenerator gen = new FoodGenerator(80, 25, '$');
            

            Point tail = new Point(3, 3, '*');
            Snake snake = new Snake(tail, 5, Direction.RIGHT);
            snake.Draw();

            Point food = gen.Generate(snake);
            food.Draw();
            Console.SetCursorPosition(0, 0);
            while (true)
            {
                if (wall.Hits(snake)||snake.Suicide())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = gen.Generate(snake);
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
