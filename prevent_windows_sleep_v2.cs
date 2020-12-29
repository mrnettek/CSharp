// MrNetTek
// eddiejackson.net/blog
// 3/2/2020
// free for public use
// free to claim as your own
 
using System;
using System.Threading;
using System.Runtime.InteropServices;
 
 
namespace SleepControl
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
 
        // Initialize array strings
        public static string array = "";
        public static string userInput = "";
        public static string userOption = "";
 
        static void Main(string[] args)
        {
            // Console Window management
            ControlConsole();
             
            // return basic usage message
            UseMessage();
 
            // load input
            foreach (string s in args)
            {
                for (int i = 0; i < args.Length; i++)
                    {
                    array = args[i].ToString();
                }
 
                userInput = userInput + s.ToString() + " ";
                               
            }
 
            // manage data entry
            string [] argInputs = userInput.Split(' ');
            userOption = argInputs[0].ToString(); // retrieve only first option
            userOption = userOption.ToLower();
 
            Console.WriteLine("Option: " + userOption);
 
            // perform action logic
            AppAction();
 
        }
 
 
 
        static void ControlConsole() {
 
            Console.Title = "Sleep Control v2";
            Console.Clear();
            ShowWindow(ThisConsole, MAXIMIZE);
 
        }
 
 
        static void UseMessage()
        {
            Console.WriteLine("\nSleepControl.exe { prevent | allow  }\n");
 
        }
 
        static void AppAction() {
 
 
            if (userOption == "prevent")
            {
 
                // disable monitor sleep and keep system awake and prevent idle to sleep
                SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
 
                Console.WriteLine("Preventing Sleep!");
 
            }
 
            else if (userOption == "allow")
            {
 
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
 
                Console.WriteLine("Allowing Sleep!");
 
            }
 
            else
            {
 
                Console.WriteLine("Option not detected!");
            }
 
            Thread.Sleep(3000);
 
        }
 
 
    }
}
 
 
 
// types of sleep
 
// disable monitor sleep
// SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS;
 
// disable monitor sleep and keep system awake
// SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
 
// disable monitor sleep and keep system awake and prevent idle to sleep
// SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_SYSTEM_REQUIRED);