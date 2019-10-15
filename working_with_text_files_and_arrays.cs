// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.IO;
class Test
{
public static void Main()
{
string path = @"c:\CSharpLabs\computers.txt";
 
// See if file exists, if not exists, create file
if (!File.Exists(path))
 
{
// Create a file to write to.
string[] createText = { "computer1", "computer2", "computer3" };
File.WriteAllLines(path, createText);
}
 
// Append to last line
string appendText = "computer99" + Environment.NewLine;
File.AppendAllText(path, appendText);
 
// Read each line
string[] readText = File.ReadAllLines(path);
foreach (string s in readText)
 
{
//output to screen
Console.WriteLine(s);
}
 
//select a couple of array items to output
Console.WriteLine("Array 1 is: {0}", readText[0]);
Console.WriteLine("Array 2 is: {0}", readText[1]);
Console.ReadLine();
}
}