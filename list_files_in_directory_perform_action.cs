// MrNetTek
// eddiejackson.net/blog
// 5/5/2020
// free for public use
// free to claim as your own
 
using System;
using System.IO; // Directory
using System.Diagnostics; // Process
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            // set path
            string dirPath = @"C:\test\";
 
            Console.WriteLine("Path: {0}\n", dirPath);
 
            // verify path exists
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("Path Exist: True");
            }
            else
            {
                Console.WriteLine("Path Exist: False");
 
                Console.WriteLine("\nCannot continue. Press any key to exit...");
                Console.ReadKey();
                Environment.Exit(0);                
 
            }
 
 
            // List Files - Perform Action
            // this should become a method
            string[] Path = Directory.GetFiles(dirPath);
             
            Console.WriteLine("Files: \n");
 
            foreach (string file in Path)
            {
                Console.WriteLine(file);
                // add other code here
                // File.Delete(file);
                // Process.Start("notepad.exe",file);
            }
 
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}