// MrNetTek
// eddiejackson.net/blog
// 12/13/2020
// free for public use
// free to claim as your own
 
using System;
 
public class PrimeNumbers
{
    public static void Main()
    {
        int start, end;
         
        Console.Write("---PRIME NUMBERS---\n\n");
 
        Console.Write("Starting Number: ");
        start = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");
 
        Console.Write("Ending Number: ");
        end = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");
 
        Console.Write("\nThe prime numbers from {0} to {1}: \n\n", start, end);
 
        for (int prime = start; prime <= end; prime++)
        {
            int counter = 0;
 
            for (int i = 2; i <= prime/ 2; i++)
            {
                if (prime % i == 0)
                {
                    counter++;
                    break;
                }
            }
 
            if (counter == 0 && prime != 1)
                Console.Write("| {0} ", prime);
        }
        Console.Write("\n\nPress any key to continue...");
         
        Console.ReadKey();
    }
}