// MrNetTek
// eddiejackson.net/blog
// 10/14/2019
// free for public use 
// free to claim as your own

using System.Runtime.InteropServices; 
 
public int WM_SYSCOMMAND = 0x0112;
public int SC_MONITORPOWER = 0xF170; 
 
[DllImport("user32.dll")]
private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
 
private void button1_Click(object sender, System.EventArgs e)
{
 
SendMessage( this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2 );
}