using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class StartUp
    {
        static void Main()
        {
            int[] dimestions = ParseToIntArray(Console.ReadLine());
            int x = dimestions[0];
            int y = dimestions[1];

            int[,] matrix = new int[x, y];

            int value = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoS = ParseToIntArray(command);
                int[] evil = ParseToIntArray(Console.ReadLine());
                
                MoveEvil(evil, matrix);
                sum = sum + MoveIvo(ivoS, matrix);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static long MoveIvo(int[] ivoS, int[,] matrix)
        {
            int xI = ivoS[0];
            int yI = ivoS[1];
            long sum = 0;

            while (xI >= 0 && yI < matrix.GetLength(1))
            {
                if (xI >= 0 && xI < matrix.GetLength(0) && yI >= 0 && yI < matrix.GetLength(1))
                {
                    sum += matrix[xI, yI];
                }

                yI++;
                xI--;
            }
            return sum;
        }

        private static void MoveEvil(int[] evil, int[,] matrix)
        {
            int xE = evil[0];
            int yE = evil[1];

            while (xE >= 0 && yE >= 0)
            {
                if (xE >= 0 && xE < matrix.GetLength(0) && yE >= 0 && yE < matrix.GetLength(1))
                {
                    matrix[xE, yE] = 0;
                }
                xE--;
                yE--;
            }
        }

        public static int[] ParseToIntArray(string input)
        {
            int[] result = input
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).
                    ToArray();

            return result;
        }
    }
}
