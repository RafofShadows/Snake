using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodGenerator
    {
        int mapWidth;
        int mapHeight;
        char symbol;

        Random rand = new Random();

        public FoodGenerator(int mapWidth, int mapHeight, char symbol)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.symbol = symbol;
        }

        public Point Generate(Figure figure)
        {
            Point p;
            do
            {
                int x = rand.Next(2, mapWidth - 2);
                int y = rand.Next(2, mapHeight - 2);
                p = new Point(x, y, symbol);
            }
            while (figure.Hits(p));
            return p;
        }
    }
}
