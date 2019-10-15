// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.Runtime.InteropServices; // DllImport
 
namespace ConsoleWindow
{
    class Program
    {
 
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
 
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
 
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
 
 
        static void Main()
        {            
            ShowWindow(ThisConsole, MAXIMIZE);
 
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Good day, ");
            Console.Write(name);
            Console.WriteLine("!");
            Console.ReadKey();
 
        }        
         
    }
}