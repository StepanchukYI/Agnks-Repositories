// Decompiled with JetBrains decompiler
// Type: agnks.EventInfo
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;

namespace agnks
{
  public class EventInfo : EventArgs
  {
    public readonly string msg;
    public readonly object val;

    public EventInfo(string s, object v)
    {
      this.msg = s;
      this.val = v;
    }

    public EventInfo(string s)
    {
      this.msg = s;
      this.val = (object) null;
    }
  }
}
