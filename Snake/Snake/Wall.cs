using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figure> wList;

        public Wall(int mapWidth, int mapHeight)
        {
            wList = new List<Figure>();

            HorizontalLine topLine = new HorizontalLine(0, mapWidth-1, 0, '+');
            HorizontalLine botLine = new HorizontalLine(0, mapWidth - 1, mapHeight-1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth - 1, 0, mapHeight - 1, '+');

            wList.Add(topLine);
            wList.Add(botLine);
            wList.Add(leftLine);
            wList.Add(rightLine);
        }

        public bool Hits(Figure figure)
        {
            foreach (Figure f in wList)
            {
                if (f.Hits(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (Figure f in wList)
            {
                f.Draw();
            }
        }
    }
}
