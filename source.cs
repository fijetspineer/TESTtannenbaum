using System;

namespace Tanne
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 10;

            // Draw the tree
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Draw the trunk
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < height - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

            Console.ReadLine();
        }
    }
}
