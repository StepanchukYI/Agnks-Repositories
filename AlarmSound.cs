// Decompiled with JetBrains decompiler
// Type: agnks.AlarmSound
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace agnks
{
  public class AlarmSound
  {
    private bool fPost1 = false;
    private bool fPost2 = false;
    private bool fPost3 = false;
    private bool fPost4 = false;
    private ThreadStart pThreadStart;
    public Thread pThread;
    public bool threadfinish;
    public bool beginBeep1;
    public bool beginBeep2;
    public bool beginBeep3;
    public bool beginBeep4;
    public Post post1;
    public Post post2;
    public Post post3;
    public Post post4;

    public AlarmSound()
    {
      this.threadfinish = false;
      this.beginBeep1 = false;
      this.beginBeep2 = false;
      this.beginBeep3 = false;
      this.beginBeep4 = false;
    }

    public void StartThread()
    {
      this.pThreadStart = new ThreadStart(this.AlarmBeepThread);
      this.pThread = new Thread(this.pThreadStart);
      this.pThread.Start();
    }

    [DllImport("Kernel32.dll")]
    private static extern bool Beep(int dwFreq, int dwDuration);

    private void AlarmBeepThread()
    {
      while (!this.threadfinish)
      {
        bool flag1 = this.post1.PostBox.BackColor == Color.Red;
        bool flag2 = this.post2.PostBox.BackColor == Color.Red;
        bool flag3 = this.post3.PostBox.BackColor == Color.Red;
        bool flag4 = this.post4.PostBox.BackColor == Color.Red;
        if (flag1 != this.fPost1)
        {
          this.beginBeep1 = flag1;
          this.fPost1 = flag1;
        }
        if (flag2 != this.fPost2)
        {
          this.beginBeep2 = flag2;
          this.fPost2 = flag2;
        }
        if (flag3 != this.fPost3)
        {
          this.beginBeep3 = flag3;
          this.fPost3 = flag3;
        }
        if (flag4 != this.fPost4)
        {
          this.beginBeep4 = flag4;
          this.fPost4 = flag4;
        }
        if (this.beginBeep1 || this.beginBeep2 || (this.beginBeep3 || this.beginBeep4))
          AlarmSound.Beep(1000, 1000);
        Thread.Sleep(500);
      }
    }

    public void OffSound()
    {
      this.beginBeep1 = this.beginBeep2 = this.beginBeep3 = this.beginBeep4 = false;
    }
  }
}
