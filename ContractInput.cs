// Decompiled with JetBrains decompiler
// Type: agnks.ContractInput
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace agnks
{
  public class ContractInput
  {
    private byte[] RecvBytes = new byte[256];
    private char[] ch = new char[256];
    private IntPtr hwndCIbttn;

    [DllImport("user32.dll")]
    public static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindow(IntPtr hWnd, int cmd);

    [DllImport("user32.dll")]
    public static extern int GetWindowText(IntPtr hWnd, byte[] mas, int count);

    [DllImport("user32.dll")]
    public static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr win);

    public IntPtr Find(IntPtr hwnd, string WindowCaption)
    {
      for (hwnd = ContractInput.GetWindow(hwnd, 5); hwnd.ToInt32() != 0; hwnd = ContractInput.GetWindow(hwnd, 2))
      {
        string message = Encoding.Default.GetString(this.RecvBytes, 0, ContractInput.GetWindowText(hwnd, this.RecvBytes, 100));
        if (message.Length > 0)
        {
          Debug.WriteLine(message);
          if (message.IndexOf(WindowCaption) > -1)
            return hwnd;
        }
      }
      return hwnd;
    }

    public bool FindCIbttn()
    {
      IntPtr num = this.Find(ContractInput.GetDesktopWindow(), "Сервер договоров");
      if (num.ToInt32() != 0)
      {
        num = this.Find(num, "Новый договор");
        this.hwndCIbttn = num;
      }
      if (num.ToInt32() == 0)
        return false;
      ContractInput.PostMessage(num, 256U, 32U, 0U);
      Thread.Sleep(100);
      ContractInput.PostMessage(num, 257U, 32U, 0U);
      return true;
    }

    public bool ClickOpros()
    {
      IntPtr num = this.Find(ContractInput.GetDesktopWindow(), "Сервер договоров");
      if (num.ToInt32() != 0)
      {
        num = this.Find(num, "Опрос ЭККА");
        this.hwndCIbttn = num;
      }
      if (num.ToInt32() == 0)
        return false;
      ContractInput.PostMessage(num, 256U, 32U, 0U);
      Thread.Sleep(100);
      ContractInput.PostMessage(num, 257U, 32U, 0U);
      return true;
    }

    public void ShowContractsViewer()
    {
      IntPtr window = ContractInput.FindWindow((string) null, "АГНКС Договора");
      if (window.ToInt32() == 0)
      {
        try
        {
          Process.Start("AGNKSContracts.exe");
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex.ToString());
        }
      }
      else
      {
        ContractInput.ShowWindow(window, 10);
        ContractInput.SetForegroundWindow(window);
      }
    }
  }
}
