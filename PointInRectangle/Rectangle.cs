using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            TopLeft = new Point(topLeftX, topLeftY);
            BottomRight = new Point(bottomRightX, bottomRightY);
        }

        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            bool isInsideX = point.CoordX>=this.TopLeft.CoordX && point.CoordX<=BottomRight.CoordX;
            bool isInsideY = point.CoordY>=this.TopLeft.CoordY && point.CoordY<=this.BottomRight.CoordY;

            bool result = isInsideX && isInsideY;
            return result;
        }
    }
}
