// MrNetTek
// eddiejackson.net/blog
// 11/29/2019
// free for public use 
// free to claim as your own

Microsoft.Win32.RegistryKey key;
key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Names");
//Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Names");
key.SetValue("Name", "Eddie");
key.Close();
