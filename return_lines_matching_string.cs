// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
class ReturnLines
{
    static void Main(string[] args)
    {
        const string pattern = @"test", filename = @"c:\data.txt";
 
        List<string> lines = GetLinesWithMatch(File.ReadAllLines(filename), pattern);
 
        foreach (var item in lines)
        {
            Console.WriteLine(item);
             
        }
 
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
 
    public static List<string> GetLinesWithMatch(string[] lines, string pattern)
    {
        Regex rx = new Regex(pattern);
        List<string> matchedLines = new List<string>();
        foreach (var line in lines)
        {
            if (rx.IsMatch(line))
            {
                matchedLines.Add(line);
            }
        }
 
        return (matchedLines);
    }
}