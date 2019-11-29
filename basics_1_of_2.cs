// MrNetTek
// eddiejackson.net/blog
// 11/29/2019
// free for public use 
// free to claim as your own

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //used by Thread.Sleep
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics; //used by Process
using System.Windows.Forms; //used by MessageBox
using Microsoft.Win32; //used by Registry
 
namespace PlayingAround
{
class ReadAll
{
public static void Main(string[] args)
{
Console.Out.WriteLine("DISPLAY CONTENTS OF A TEXT FILE");
 
//creates {contents} variabe
string contents = File.ReadAllText(@"C:\test.txt"); 
 
//outputs {contents} to screen
Console.Out.WriteLine("contents = " + contents); 
Thread.Sleep(5000); //wait 5 seconds
 
//will wait for {ENTER} key
//Console.In.ReadLine(); 
 
Console.Out.WriteLine("DISPLAY TIMESTAMP");
 
//creates {DateTime} variable
DateTime dt = DateTime.Now; 
 
//outputs {DataTime} to screen
Console.WriteLine("Current Time is {0} ", dt.ToString()); 
Console.Out.WriteLine("");
Console.Out.WriteLine("");
Thread.Sleep(5000); //wait 5 seconds
 
Console.Out.WriteLine("LAUNCH and KILL PROCESS");
//launch cnn website using IE
Process process1 = Process.Start("iexplore.exe", "www.cnn.com"); 
Thread.Sleep(7000); //wait 7 seconds
 
foreach (System.Diagnostics.Process IEProc in System.Diagnostics.Process.GetProcesses())
{
if (IEProc.ProcessName == "iexplore")
{
//if IE is found, kill it
IEProc.Kill(); //kill IExplore.exe
}
}
 
//launch notepad.exe - will stay open
Process process2 = Process.Start("notepad.exe"); 
//wait for process to close before continuing
process2.WaitForExit();                                          
Thread.Sleep(2000); //wait 2 seconds
 
//show simple popup message - 
//make sure you Add Reference to System.Windows.Forms---under Projects
MessageBox.Show("Program has completed!"); 
 
//begin event log creation
 
string sSource;
string sLog;
string sEvent;
 
sSource = "My Program";
sLog = "Application";
sEvent = "This is the description";
 
if (!EventLog.SourceExists(sSource)) EventLog.CreateEventSource(sSource, sLog);
 
EventLog.WriteEntry(sSource, sEvent);
//EventLog.WriteEntry(sSource, sEvent, EventLogEntryType.Warning, 234);
//end event log
 
//write to text log
string text = "Text1 " + "Text2";
System.IO.File.WriteAllText(@"C:\log.txt", text);
 
//set registry key
const string userRoot = "HKEY_CURRENT_USER";
const string subkey = "RegistrySetValueExample";
const string keyName = userRoot + "\\" + subkey;
Registry.SetValue(keyName, "MyKeyName", "A_String_Value_Goes_Here", RegistryValueKind.String);
 
//get registry key
string regValue = (string)Registry.GetValue(keyName, "MyKeyName","");
 
//show popup message 
MessageBox.Show(regValue);                       
 
             
//delete registry key
string regDelete = @"RegistrySetValueExample";
using (RegistryKey key = Registry.CurrentUser.OpenSubKey(regDelete, true))
{
 if (key == null)
    {
    //does not exist 
    }
 else
    {
     //does exist
      key.DeleteValue("MyKeyName");
     }
   }
 
        }
    }
}
