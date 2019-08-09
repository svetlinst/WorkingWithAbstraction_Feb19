using System;
using System.Linq;

namespace PointInRectangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rectangleCoord = ReadCoordinates(Console.ReadLine());
            Rectangle rectangle = new Rectangle(rectangleCoord[0], rectangleCoord[1], rectangleCoord[2], rectangleCoord[3]);

            var pointsToCheck = int.Parse(Console.ReadLine());
            for (int i = 0; i < pointsToCheck; i++)
            {
                int[] pointCoords = ReadCoordinates(Console.ReadLine());
                Point point = new Point(pointCoords[0], pointCoords[1]);
                Console.WriteLine(rectangle.Contains(point));
            }

        }

        private static int[] ReadCoordinates(string input)
        {
            int[] coords = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return coords;
        }
    }
}
