// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.IO;
 
namespace return_timestamp
{
class Touch
{
static void Main(string[] args)
{
string fileName = "c:\\setup\\setup.exe";
 
FileInfo fileinfo = new FileInfo(fileName);
touchFile(fileinfo);
Console.ReadKey();
 
}
 
static void touchFile(FileSystemInfo filename)
{
Console.WriteLine("File name: {0}", filename.FullName);
try
{
filename.CreationTime = filename.LastWriteTime;
Console.Write("\nTimestamp: ");
Console.Write(filename.CreationTime);
 
}
catch (Exception x)
{
Console.WriteLine("Error: {0}", x.Message);
}
}
}
}