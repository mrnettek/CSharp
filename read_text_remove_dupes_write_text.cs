// MrNetTek
// eddiejackson.net/blog
// 12/22/2019
// free for public use 
// free to claim as your own
 
using System;
using System.Collections.Generic;
using System.IO;
 
class RemoveDupes
{
    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }
 
        using TextReader txtReader = File.OpenText(@"C:\csharp\RemoveDupes\withDupes.txt");
        using TextWriter txtWriter = File.CreateText(@"C:\csharp\RemoveDupes\withoutDupes.txt");
         
        string currLine;
 
        HashSet<string> prevLines = new HashSet<string>();
 
        while ((currLine = txtReader.ReadLine()) != null)
        {
            if (prevLines.Add(currLine))
            {
                txtWriter.WriteLine(currLine);
            }
        }
 
        Console.WriteLine("\nDuplicates have been removed!\n");
 
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
 
    }
}
