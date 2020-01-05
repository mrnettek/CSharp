// MrNetTek
// eddiejackson.net/blog
// 12/20/2019
// free for public use 
// free to claim as your own
 
using System;
using System.IO;
 
class TextToArray
{
    public static void Main()
    {
        string path = @"C:\csharp\text\servers.txt";
 
        // See if file exists, if not exists, create file
        if (!File.Exists(path))
 
        {
            Console.WriteLine("No server list found!");
 
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Environment.Exit(1);
        }
 
 
        // Read each line
        string[] readList = File.ReadAllLines(path);
        foreach (string server in readList)
 
        {
            // Output to screen
            Console.WriteLine("{0}",server);
        }
 
        // Select a couple of array elements to output
        Console.WriteLine("\nElement 1 is: {0}", readList[0]);
        Console.WriteLine("Element 5 is: {0}", readList[4]);
 
        // Add your own code here        
         
 
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
        Environment.Exit(0);
    }
}
