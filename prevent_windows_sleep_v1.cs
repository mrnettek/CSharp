// MrNetTek
// eddiejackson.net/blog
// 2/28/2020
// free for public use
// free to claim as your own
 
using System;
using System.Runtime.InteropServices;
 
namespace DisableSleepMode
{
    class Program
    {
        // Sleep Control
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
 
        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }
 
        // Console Window Handling
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
 
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
 
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
 
        static void Main(string[] args)
        {
            ShowWindow(ThisConsole, MINIMIZE);
 
            Console.WriteLine("Preventing Sleep!");
             
            // types of sleep
             
            // disable monitor sleep
            // SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS;
 
            // disable monitor sleep and keep system awake
            // SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
 
            // disable monitor sleep and keep system awake and prevent idle to sleep
            SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
 
            // wait for user
            Console.WriteLine("\npress any key to continue...\n");            
            Console.ReadKey();
             
            // allow sleep
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
 
        }
         
    }
}