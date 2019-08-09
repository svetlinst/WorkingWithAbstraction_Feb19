using System;

namespace RhombusOfStarts
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                PrintRow(i, size);
            }
            for (int i = size-1; i > 0 ; i--)
            {
                PrintRow(i, size);
            }
        }

        private static void PrintRow(int starCount, int size)
        {
            int blanks = size - starCount;
            Console.Write(new string(' ', blanks));
            for (int i = 0; i < starCount; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
