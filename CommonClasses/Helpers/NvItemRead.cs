﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.LsuPro.Helpers.NvItemRead
// Assembly: CommonClasses, Version=16.5.3001.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C5F53C6-7909-4C9A-87E3-489AF522B35E
// Assembly location: C:\ProgramData\Microsoft\Lumia Software Updater Pro\Bin\CommonClasses.dll

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.LsuPro.Helpers
{
  public class NvItemRead
  {
    public NvItemRead(int itemId) => this.ID = itemId;

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "reviewed")]
    public int MessageVersion => 0;

    public int ID { get; set; }
  }
}