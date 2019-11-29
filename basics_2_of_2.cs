// MrNetTek
// eddiejackson.net/blog
// 11/29/2019
// free for public use 
// free to claim as your own

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Decisions
{
class Program
{
static void Main(string[] args)
{
Console.Title = "Behind the Door!";
string Success = "1";
string message = "";
string UserValue = "";
Console.WriteLine("");
 
do
{
Console.WriteLine("Eddie's TV Show");
Console.WriteLine("Choose a door: 1, 2, 3: ");
UserValue = Console.ReadLine();
 
if (UserValue == "1")
{
message = "You have won a vacation to Hawaii!";
Success = "0";
}
else if (UserValue == "2")
{
message = "You have won a jetski!";
Success = "0";
}
else if (UserValue == "3")
{
message = "You have won a cruise!";
Success = "0";
}
else
{
Console.WriteLine("");
Console.WriteLine("I did not recognize your answer!");
System.Threading.Thread.Sleep(3000);
Console.Clear();
 
}
Console.WriteLine(message);
 
} while (Success == "1");
 
Console.WriteLine("");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();
 
}
}
}
