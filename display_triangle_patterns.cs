// MrNetTek
// eddiejackson.net/blog
// 11/29/2019
// free for public use 
// free to claim as your own

using System;
 
namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ROWS = 5;
            const int COLUMNS = 5;
 
            Console.WriteLine(" Left to Right");
            for (int i1 = 1, i2 = 1; i1 < COLUMNS * 2; i1++)
            {
                for (int j = 1; j <= i2; j++)
                {
                    Console.Write(" *");
                }
 
                if (i1 < 5)
                    i2++;
                else
                    i2--;
                Console.WriteLine();
            }
            Console.WriteLine();
 
            Console.WriteLine(" Right to Left");
            for (int i1 = 1, i2 = COLUMNS - 1, i3 = 1; i1 < COLUMNS * 2; i1++)
            {
                for (int j = 1; j <= i2; j++)
                    Console.Write(" ");
 
                for (int j = 1; j <= i3; j++)
                    Console.Write(" *");
 
                if (i1 < COLUMNS)
                {
                    i3++;
                    i2--;
                }
                else
                {
                    i3--;
                    i2++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
 
            Console.WriteLine(" Bottom to Top");
            for (int i1 = 1; i1 <= ROWS; i1++)
            {
                for (int j = i1; j < ROWS; j++)
                    Console.Write("  ");
 
                for (int j = 1; j <= (2 * i1 - 1); j++)
                    Console.Write(" *");
                Console.WriteLine();
            }
 
            Console.WriteLine("\n Top to Bottom");
            for (int i1 = 1; i1 <= ROWS; i1++)
            {
                for (int j = 1; j < i1; j++)
                    Console.Write("  ");
 
                for (int j = 1; j <= (ROWS * 2 - (2 * i1 - 1)); j++)
                    Console.Write(" *");
 
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
