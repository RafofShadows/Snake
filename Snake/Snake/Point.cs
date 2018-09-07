using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        internal char symbol;

        public Point()
        {
        }

        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
            this.symbol = other.symbol;
        }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        internal void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.DOWN:
                    y += offset;
                    break;
                case Direction.LEFT:
                    x -= offset;
                    break;
                case Direction.RIGHT:
                    x += offset;
                    break;
                case Direction.UP:
                    y -= offset;
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public bool Hits(Point target)
        {
            return x == target.x && y == target.y;
        }
    }
}
