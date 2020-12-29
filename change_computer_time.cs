// MrNetTek
// eddiejackson.net/blog
// 12/13/2020
// free for public use
// free to claim as your own
 
using System;
using System.Runtime.InteropServices;
 
namespace ChangeTime
{
    class Program
    {
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]
        public extern static void Win32GetSystemTime(ref ComputerTime sysTime);
 
        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
        public extern static bool Win32SetSystemTime(ref ComputerTime sysTime);
         
        public struct ComputerTime
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Millisecond;
        };
 
        static void Main(string[] args)
        {
            Console.WriteLine("Run as admin. Check the time.");
 
            ComputerTime updatedTime = new ComputerTime
            {
                Year = (ushort)2020,
                Month = (ushort)12,
                Day = (ushort)13,
                Hour = (ushort)7,
                Minute = (ushort)0,
                Second = (ushort)0
            };
            Win32SetSystemTime(ref updatedTime);
        }
    }
}