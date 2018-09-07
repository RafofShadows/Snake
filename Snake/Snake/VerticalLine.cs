using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yTop, int yBottom, char symbol)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBottom; i++)
            {
                pList.Add(new Point(x, i, symbol));
            }
        }
    }
}
