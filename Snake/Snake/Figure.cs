using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool Hits(Figure figure)
        {
            foreach (Point p in figure.pList)
            {
                if (Hits(p))
                {
                    return true;
                }
            }
            return false;
        }

        internal bool Hits(Point point)
        {
            foreach (Point p in pList)
            {
                if (p.Hits(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
