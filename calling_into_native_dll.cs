// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System;
using System.Runtime.InteropServices;
 
class MessageBoxDLL
{
// call to which dll you would like to import
// our unmanaged dll
[DllImport("user32.dll")]
 
// our function
static extern int MessageBox(IntPtr hWnd, string text, string caption, int type);
// a static method with the same name as the function, i.e. MessageBox
public static void Main()
{
// calls function with relative parameters
// the marshaler does the translation for us
MessageBox(IntPtr.Zero,"This is a test!", "Yo", 0);
}
}