// Decompiled with JetBrains decompiler
// Type: agnks.EventParam
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;

namespace agnks
{
  public class EventParam : EventArgs
  {
    public readonly bool Rule;
    public readonly bool ComAsEKKA;

    public EventParam(bool s2, bool s3)
    {
      this.Rule = s2;
      this.ComAsEKKA = s3;
    }
  }
}
