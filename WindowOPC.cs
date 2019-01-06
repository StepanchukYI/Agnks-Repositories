// Decompiled with JetBrains decompiler
// Type: agnks.WindowOPC
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace agnks
{
  public class WindowOPC
  {
    private byte[] RecvBytes = new byte[256];
    private IntPtr hwndOPC;

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindow(IntPtr hWnd, int cmd);

    [DllImport("user32.dll")]
    public static extern int GetWindowText(IntPtr hWnd, byte[] mas, int count);

    public bool FindOPC()
    {
      Encoding ascii = Encoding.ASCII;
      IntPtr window = WindowOPC.GetWindow(WindowOPC.GetDesktopWindow(), 5);
      while (window.ToInt32() != 0)
      {
        window = WindowOPC.GetWindow(window, 2);
        int windowText = WindowOPC.GetWindowText(window, this.RecvBytes, 100);
        string str = ascii.GetString(this.RecvBytes, 0, windowText);
        if (str.Length > 0 && str.IndexOf("PLCNET") > -1)
        {
          this.hwndOPC = window;
          return true;
        }
      }
      return false;
    }

    public void OPCShow()
    {
      WindowOPC.ShowWindow(this.hwndOPC, 5);
    }

    public void OPCHide()
    {
      WindowOPC.ShowWindow(this.hwndOPC, 0);
    }
  }
}
