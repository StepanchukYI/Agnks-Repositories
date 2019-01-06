// Decompiled with JetBrains decompiler
// Type: agnks.ListParams
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class ListParams : Form
  {
    private ListView List;
    private ColumnHeader Post1;
    private ColumnHeader Post2;
    private ColumnHeader Post3;
    private ColumnHeader Post4;
    private ColumnHeader ParamPost;
    private ColumnHeader Mesure;
    private DataOfCol m_Data1;
    private DataOfCol m_Data2;
    private DataOfCol m_Data3;
    private DataOfCol m_Data4;
    private Timer timer1;
    private Button bOut;
    private IContainer components;

    public ListParams()
    {
      this.InitializeComponent();
      string[] items = new string[4];
      items[0] = items[1] = items[2] = items[3] = " ";
      this.List.Items[0].SubItems.AddRange(items);
      this.List.Items[1].SubItems.AddRange(items);
      this.List.Items[2].SubItems.AddRange(items);
      this.List.Items[3].SubItems.AddRange(items);
      this.List.Items[4].SubItems.AddRange(items);
      this.List.Items[5].SubItems.AddRange(items);
      this.List.Items[6].SubItems.AddRange(items);
      this.List.Items[7].SubItems.AddRange(items);
      this.List.Items[8].SubItems.AddRange(items);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ListViewItem listViewItem1 = new ListViewItem(new string[2]
      {
        "Плотность газа, нм3/кг",
        "нм3/кг"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem2 = new ListViewItem(new string[2]
      {
        "Дискретность измерения счётчика газа",
        "кг/импульс"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem3 = new ListViewItem(new string[2]
      {
        "Дискретность измерения ЭККА",
        "нм3/импульс"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem4 = new ListViewItem(new string[2]
      {
        "Макс. расход газа",
        "нм3/мин"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem5 = new ListViewItem(new string[2]
      {
        "Мин. расход газа",
        "нм3/мин"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem6 = new ListViewItem(new string[2]
      {
        "Расход включения ЕКМ",
        "нм3/мин"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem7 = new ListViewItem(new string[2]
      {
        "Частота индикации при заправке",
        "Гц"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem8 = new ListViewItem(new string[2]
      {
        "Частота индикации слова \"Повер\"",
        "Гц"
      }, -1, SystemColors.WindowText, SystemColors.Window, new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      ListViewItem listViewItem9 = new ListViewItem(new string[2]
      {
        "Количество заправленного газа",
        "нм3"
      }, -1);
      this.List = new ListView();
      this.ParamPost = new ColumnHeader();
      this.Mesure = new ColumnHeader();
      this.Post1 = new ColumnHeader();
      this.Post2 = new ColumnHeader();
      this.Post3 = new ColumnHeader();
      this.Post4 = new ColumnHeader();
      this.timer1 = new Timer(this.components);
      this.bOut = new Button();
      this.SuspendLayout();
      this.List.Columns.AddRange(new ColumnHeader[6]
      {
        this.ParamPost,
        this.Mesure,
        this.Post1,
        this.Post2,
        this.Post3,
        this.Post4
      });
      this.List.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.List.Items.AddRange(new ListViewItem[9]
      {
        listViewItem1,
        listViewItem2,
        listViewItem3,
        listViewItem4,
        listViewItem5,
        listViewItem6,
        listViewItem7,
        listViewItem8,
        listViewItem9
      });
      this.List.Location = new Point(0, 0);
      this.List.MultiSelect = false;
      this.List.Name = "List";
      this.List.Size = new Size(592, 273);
      this.List.TabIndex = 0;
      this.List.View = View.Details;
      this.ParamPost.Text = "Параметр";
      this.ParamPost.Width = 250;
      this.Mesure.Text = "Ед. изм.";
      this.Mesure.Width = 100;
      this.Post1.Text = "Пост1";
      this.Post2.Text = "Пост2";
      this.Post3.Text = "Пост3";
      this.Post4.Text = "Пост4";
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.bOut.Location = new Point(600, 16);
      this.bOut.Name = "bOut";
      this.bOut.TabIndex = 1;
      this.bOut.Text = "Выход";
      this.bOut.Click += new EventHandler(this.bOut_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(680, 253);
      this.Controls.Add((Control) this.bOut);
      this.Controls.Add((Control) this.List);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ListParams);
      this.Text = "Параметры";
      this.TopMost = true;
      this.Closing += new CancelEventHandler(this.ListParams_Closing);
      this.ResumeLayout(false);
    }

    private void ListParams_Closing(object sender, CancelEventArgs e)
    {
      this.Hide();
    }

    public DataOfCol m_DataCol1
    {
      set
      {
        this.m_Data1 = value;
        this.m_Data1.OnChangeValue += new ChangeValue(this.PostChangedTags1);
      }
    }

    public DataOfCol m_DataCol2
    {
      set
      {
        this.m_Data2 = value;
        this.m_Data2.OnChangeValue += new ChangeValue(this.PostChangedTags2);
      }
    }

    public DataOfCol m_DataCol3
    {
      set
      {
        this.m_Data3 = value;
        this.m_Data3.OnChangeValue += new ChangeValue(this.PostChangedTags3);
      }
    }

    public DataOfCol m_DataCol4
    {
      set
      {
        this.m_Data4 = value;
        this.m_Data4.OnChangeValue += new ChangeValue(this.PostChangedTags4);
      }
    }

    private void PostChangedTags1(object sender, EventInfo ei)
    {
      this.FillDataSubItems(2, ei, this.m_Data1);
    }

    private void PostChangedTags2(object sender, EventInfo ei)
    {
      this.FillDataSubItems(3, ei, this.m_Data2);
    }

    private void PostChangedTags3(object sender, EventInfo ei)
    {
      this.FillDataSubItems(4, ei, this.m_Data3);
    }

    private void PostChangedTags4(object sender, EventInfo ei)
    {
      this.FillDataSubItems(5, ei, this.m_Data4);
    }

    private void FillDataSubItems(int i, EventInfo ei, DataOfCol m_Data)
    {
      if (ei.msg == "density")
        this.List.Items[0].SubItems[i].Text = "" + (object) (float) ((double) m_Data.density / 100.0);
      if (ei.msg == "amount")
        this.List.Items[1].SubItems[i].Text = m_Data.amount.ToString();
      if (ei.msg == "Vo")
        this.List.Items[2].SubItems[i].Text = m_Data.Vo.ToString();
      if (ei.msg == "LimitFlowMax")
        this.List.Items[3].SubItems[i].Text = m_Data.LimitFlowMax.ToString();
      if (ei.msg == "LimitFlowMin")
        this.List.Items[4].SubItems[i].Text = m_Data.LimitFlowMin.ToString();
      if (ei.msg == "FlowOnEKM")
        this.List.Items[5].SubItems[i].Text = m_Data.FlowOnEKM.ToString();
      if (ei.msg == "sleep")
        this.List.Items[6].SubItems[i].Text = m_Data.sleep == 0 ? "100" : "" + (object) (100 / m_Data.sleep);
      if (ei.msg == "TESTFRQ")
        this.List.Items[7].SubItems[i].Text = m_Data.TESTFRQ == 0 ? "100" : "" + (object) (100 / m_Data.TESTFRQ);
      if (!(ei.msg == "TOTALGAS"))
        return;
      this.List.Items[8].SubItems[i].Text = Math.Round(m_Data.TOTALGAS, 2).ToString();
    }

    private void NoConnectPost(int i)
    {
      this.List.Items[0].SubItems[i].Text = "-";
      this.List.Items[1].SubItems[i].Text = "-";
      this.List.Items[2].SubItems[i].Text = "-";
      this.List.Items[3].SubItems[i].Text = "-";
      this.List.Items[4].SubItems[i].Text = "-";
      this.List.Items[5].SubItems[i].Text = "-";
      this.List.Items[6].SubItems[i].Text = "-";
      this.List.Items[7].SubItems[i].Text = "-";
      this.List.Items[8].SubItems[i].Text = "-";
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (this.m_Data1.NoConnect)
        this.NoConnectPost(2);
      if (this.m_Data2.NoConnect)
        this.NoConnectPost(3);
      if (this.m_Data3.NoConnect)
        this.NoConnectPost(4);
      if (!this.m_Data4.NoConnect)
        return;
      this.NoConnectPost(5);
    }

    private void bOut_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
