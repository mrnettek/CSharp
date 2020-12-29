// MrNetTek
// eddiejackson.net/blog
// 12/26/2020
// free for public use
// free to claim as your own
 
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
 
class ExtractEmailAddresses
{
 
    public static void Main()
    {
        // read data
        string input = File.ReadAllText(@"C:\csharp\return_email\input.txt");
        //Console.Write(input);
 
        // email address pattern
        const string Pattern =
           @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
         
        // set up regex instance with options
        Regex emailPattern = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        
        // perform match
        MatchCollection emailMatches = emailPattern.Matches(input);
 
        // set up our string builder
        StringBuilder sb = new StringBuilder();
 
        // build the list
        Console.WriteLine("---EXTRACTED EMAIL ADDRESSES---");
        foreach (Match emailMatch in emailMatches)
        {
            // add address to builder
            sb.AppendLine(emailMatch.Value);
 
            // display to console
            Console.WriteLine("\n {0}", emailMatch.Value);
 
        }
 
        // write to file
        File.WriteAllText(@"C:\csharp\return_email\output.txt", sb.ToString());
 
        // exit
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}