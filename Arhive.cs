// Decompiled with JetBrains decompiler
// Type: agnks.Arhive
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace agnks
{
  public class Arhive
  {
    private OleDbConnection oleDbConnection1;
    private OleDbCommand oleDbComWriteArh;
    public OPCAdapter m_OPCAdapter;
    public TextBox UserName;

    [DllImport("user32.dll")]
    public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    [DllImport("user32.dll")]
    public static extern bool SetForegroundWindow(IntPtr win);

    public Arhive()
    {
      this.InitBase();
    }

    private void InitBase()
    {
      this.oleDbConnection1 = new OleDbConnection();
      this.oleDbComWriteArh = new OleDbCommand();
      this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=c:\\mdb\\AGNKS2.mdb;Mode=ReadWrite|Share Deny None;Extended Properties=\"\";Jet OLEDB:System database=\"\";Jet OLEDB:Registry Path=\"\";Jet OLEDB:Database Password=\"\";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password=\"\";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
      this.oleDbComWriteArh.CommandText = "INSERT INTO Arhive(Дата, [Код цены], [Номер машины], [Объём нм3], Оператор, [Плотность кг/м3], Пост, [Стоимость грн], [Цена грн]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
      this.oleDbComWriteArh.Connection = this.oleDbConnection1;
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Дата", OleDbType.Date, 0, "Дата"));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Код_цены", OleDbType.VarWChar, 50, "Код цены"));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Номер_машины", OleDbType.VarWChar, 50, "Номер машины"));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Объём_нм3", OleDbType.Double, 0, ParameterDirection.Input, false, (byte) 15, (byte) 0, "Объём нм3", DataRowVersion.Current, (object) null));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Оператор", OleDbType.VarWChar, 50, "Оператор"));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Плотность_кг/м3", OleDbType.Double, 0, ParameterDirection.Input, false, (byte) 15, (byte) 0, "Плотность кг/м3", DataRowVersion.Current, (object) null));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Пост", OleDbType.SmallInt, 0, ParameterDirection.Input, false, (byte) 5, (byte) 0, "Пост", DataRowVersion.Current, (object) null));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Стоимость_грн", OleDbType.Double, 0, ParameterDirection.Input, false, (byte) 15, (byte) 0, "Стоимость грн", DataRowVersion.Current, (object) null));
      this.oleDbComWriteArh.Parameters.Add(new OleDbParameter("Цена_грн", OleDbType.Double, 0, ParameterDirection.Input, false, (byte) 15, (byte) 0, "Цена грн", DataRowVersion.Current, (object) null));
    }

    public void InsertBase(int post, string CodPrice)
    {
      lock (this)
      {
        try
        {
          this.oleDbComWriteArh.Parameters["Код_цены"].Value = (object) CodPrice;
          this.oleDbComWriteArh.Parameters["Дата"].Value = (object) DateTime.Now;
          this.oleDbComWriteArh.Parameters["Объём_нм3"].Value = (object) Math.Round((double) this.m_OPCAdapter.m_Data1.Volume, 2);
          this.oleDbComWriteArh.Parameters["Плотность_кг/м3"].Value = (object) Math.Round((double) this.m_OPCAdapter.m_Data1.density / 100.0, 2);
          this.oleDbComWriteArh.Parameters["Пост"].Value = (object) post;
          this.oleDbComWriteArh.Parameters["Стоимость_грн"].Value = (object) Math.Round((double) this.m_OPCAdapter.m_Data1.Cost, 2);
          this.oleDbComWriteArh.Parameters["Цена_грн"].Value = (object) Math.Round((double) this.m_OPCAdapter.m_Data1.Price / 100.0, 2);
          this.oleDbComWriteArh.Parameters["Оператор"].Value = (object) this.UserName.Text;
          this.oleDbComWriteArh.Parameters["Номер_машины"].Value = (object) this.m_OPCAdapter.m_Data1.car;
          if (this.oleDbConnection1.State == ConnectionState.Closed)
            this.oleDbConnection1.Open();
          this.oleDbComWriteArh.ExecuteNonQuery();
          this.oleDbConnection1.Close();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex.Message);
        }
      }
    }

    public void Hide()
    {
    }

    public void Show()
    {
      IntPtr window = Arhive.FindWindow((string) null, "Архив");
      if (window.ToInt32() == 0)
      {
        try
        {
          Process.Start("Arhive.exe");
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex.ToString());
        }
      }
      else
      {
        Arhive.ShowWindow(window, 10);
        Arhive.SetForegroundWindow(window);
      }
    }

    public bool Enabled
    {
      set
      {
      }
    }
  }
}
