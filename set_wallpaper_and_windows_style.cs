// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.IO;
 
namespace ConsoleApp1
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(
        UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);
 
        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;
 
        static public void SetWallpaper(String path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", 0.ToString()); // 2 is stretched
            key.SetValue(@"TileWallpaper", 0.ToString());
 
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
 
        static void Main(string[] args)
        {
            string imgWallpaper = @"C:\Windows\Wallpaper.jpg";
 
           // verify    
           if (File.Exists(imgWallpaper))
              {                        
                  SetWallpaper(imgWallpaper);
              }         
  
        }
         
    }
}