﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
                default:
                    return;
            }
        }

        public bool Eat(Point target)
        {
            Point head = GetNextPoint();
            if (head.Hits(target))
            {
                target.symbol = head.symbol;
                pList.Add(target);
                target.Draw();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Suicide()
        {
            Point head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (pList[i].Hits(head))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
