using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Point
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Point(int coordX, int coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
        }

    }
}
