// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
 
class Program
{
    public static void Main()
    {        
        string userString;
 
        Console.WriteLine("Enter a word:\n");
        userString = Convert.ToString(Console.ReadLine());
        Console.WriteLine("\nWord is = {0}", userString);
 
        string revString = Reverse(userString);
        Console.WriteLine("Its reverse is = {0}", revString);       
 
        if (userString == revString)
            Console.WriteLine("\nWord is a palindrome.\n");
        else
            Console.WriteLine("\nWord is not a palindrome.\n");
 
        Console.ReadLine();
    }
 
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}