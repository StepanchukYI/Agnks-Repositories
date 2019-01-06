// Decompiled with JetBrains decompiler
// Type: agnks.AlarmsArhive
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace agnks
{
  public class AlarmsArhive : Form
  {
    private Container components = (Container) null;
    private Button ExitBut;
    private DataOfCol m_DataCol1;
    private DataOfCol m_DataCol2;
    private DataOfCol m_DataCol3;
    private DataOfCol m_DataCol4;
    private DataGrid AlarmsdataGrid;
    public TextBox UserName;
    private DataGridTableStyle dataGridTableStyle1;
    private DataGridTextBoxColumn AlarmColumn;
    private DataGridTextBoxColumn DateColumn;
    private DataGridTextBoxColumn UserColumn;
    private DataGridTextBoxColumn PostColumn;
    private OleDbDataAdapter oleDbDataAdapter1;
    private OleDbCommand oleDbSelectCommand1;
    private OleDbCommand oleDbInsertCommand1;
    private OleDbConnection oleDbConnection1;
    private AlarmsDataSet alarmsDataSet1;
    private OleDbCommand AlarmWriteCmd;
    private Button UpDatebutton;
    private Label label1;
    private GroupBox groupBox1;
    private Label label2;
    private DataGridTextBoxColumn CheckColumn;
    private ListView UpDateAlarmslist;
    private ColumnHeader PostHeader;
    private ColumnHeader AlarmHeader;
    private ColumnHeader DateHeader;

    public AlarmsArhive()
    {
      this.InitializeComponent();
      this.alarmsDataSet1.Clear();
      this.oleDbDataAdapter1.Fill((DataSet) this.alarmsDataSet1);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.ExitBut = new Button();
      this.AlarmsdataGrid = new DataGrid();
      this.alarmsDataSet1 = new AlarmsDataSet();
      this.dataGridTableStyle1 = new DataGridTableStyle();
      this.DateColumn = new DataGridTextBoxColumn();
      this.PostColumn = new DataGridTextBoxColumn();
      this.AlarmColumn = new DataGridTextBoxColumn();
      this.UserColumn = new DataGridTextBoxColumn();
      this.CheckColumn = new DataGridTextBoxColumn();
      this.oleDbDataAdapter1 = new OleDbDataAdapter();
      this.oleDbInsertCommand1 = new OleDbCommand();
      this.oleDbConnection1 = new OleDbConnection();
      this.oleDbSelectCommand1 = new OleDbCommand();
      this.AlarmWriteCmd = new OleDbCommand();
      this.UpDatebutton = new Button();
      this.UpDateAlarmslist = new ListView();
      this.DateHeader = new ColumnHeader();
      this.PostHeader = new ColumnHeader();
      this.AlarmHeader = new ColumnHeader();
      this.label1 = new Label();
      this.groupBox1 = new GroupBox();
      this.label2 = new Label();
      this.AlarmsdataGrid.BeginInit();
      this.alarmsDataSet1.BeginInit();
      this.SuspendLayout();
      this.ExitBut.Location = new Point(648, 240);
      this.ExitBut.Name = "ExitBut";
      this.ExitBut.TabIndex = 1;
      this.ExitBut.Text = "Выход";
      this.ExitBut.Click += new EventHandler(this.ExitBut_Click);
      this.AlarmsdataGrid.CaptionText = "Архив аварий";
      this.AlarmsdataGrid.CaptionVisible = false;
      this.AlarmsdataGrid.DataMember = "Alarms";
      this.AlarmsdataGrid.DataSource = (object) this.alarmsDataSet1;
      this.AlarmsdataGrid.HeaderForeColor = SystemColors.ControlText;
      this.AlarmsdataGrid.Location = new Point(8, 208);
      this.AlarmsdataGrid.Name = "AlarmsdataGrid";
      this.AlarmsdataGrid.ReadOnly = true;
      this.AlarmsdataGrid.Size = new Size(632, 256);
      this.AlarmsdataGrid.TabIndex = 3;
      this.AlarmsdataGrid.TableStyles.AddRange(new DataGridTableStyle[1]
      {
        this.dataGridTableStyle1
      });
      this.alarmsDataSet1.DataSetName = "AlarmsDataSet";
      this.alarmsDataSet1.Locale = new CultureInfo("ru-RU");
      this.alarmsDataSet1.Namespace = "http://www.tempuri.org/AlarmsDataSet.xsd";
      this.dataGridTableStyle1.DataGrid = this.AlarmsdataGrid;
      this.dataGridTableStyle1.GridColumnStyles.AddRange(new DataGridColumnStyle[5]
      {
        (DataGridColumnStyle) this.DateColumn,
        (DataGridColumnStyle) this.PostColumn,
        (DataGridColumnStyle) this.AlarmColumn,
        (DataGridColumnStyle) this.UserColumn,
        (DataGridColumnStyle) this.CheckColumn
      });
      this.dataGridTableStyle1.HeaderForeColor = SystemColors.ControlText;
      this.dataGridTableStyle1.MappingName = "Alarms";
      this.DateColumn.Format = "g";
      this.DateColumn.FormatInfo = (IFormatProvider) null;
      this.DateColumn.HeaderText = "Дата";
      this.DateColumn.MappingName = "Дата";
      this.DateColumn.Width = 120;
      this.PostColumn.Format = "";
      this.PostColumn.FormatInfo = (IFormatProvider) null;
      this.PostColumn.HeaderText = "Пост";
      this.PostColumn.MappingName = "Пост";
      this.PostColumn.Width = 50;
      this.AlarmColumn.Alignment = HorizontalAlignment.Center;
      this.AlarmColumn.Format = "";
      this.AlarmColumn.FormatInfo = (IFormatProvider) null;
      this.AlarmColumn.HeaderText = "Авария";
      this.AlarmColumn.MappingName = "Авария";
      this.AlarmColumn.Width = 230;
      this.UserColumn.Format = "";
      this.UserColumn.FormatInfo = (IFormatProvider) null;
      this.UserColumn.HeaderText = "Оператор";
      this.UserColumn.MappingName = "Оператор";
      this.UserColumn.Width = 70;
      this.CheckColumn.Format = "";
      this.CheckColumn.FormatInfo = (IFormatProvider) null;
      this.CheckColumn.HeaderText = "Подтверждение";
      this.CheckColumn.MappingName = "Подтверждение";
      this.CheckColumn.Width = 105;
      this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
      this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
      this.oleDbDataAdapter1.TableMappings.AddRange(new DataTableMapping[1]
      {
        new DataTableMapping("Table", "Alarms", new DataColumnMapping[5]
        {
          new DataColumnMapping("Дата", "Дата"),
          new DataColumnMapping("Авария", "Авария"),
          new DataColumnMapping("Оператор", "Оператор"),
          new DataColumnMapping("Подтверждение", "Подтверждение"),
          new DataColumnMapping("Пост", "Пост")
        })
      });
      this.oleDbInsertCommand1.CommandText = "INSERT INTO Alarms(Авария, Дата, Оператор, Подтверждение, Пост) VALUES (?, ?, ?, ?, ?)";
      this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
      this.oleDbInsertCommand1.Parameters.Add(new OleDbParameter("Авария", OleDbType.VarWChar, 200, "Авария"));
      this.oleDbInsertCommand1.Parameters.Add(new OleDbParameter("Дата", OleDbType.Date, 0, "Дата"));
      this.oleDbInsertCommand1.Parameters.Add(new OleDbParameter("Оператор", OleDbType.VarWChar, 50, "Оператор"));
      this.oleDbInsertCommand1.Parameters.Add(new OleDbParameter("Подтверждение", OleDbType.VarWChar, 50, "Подтверждение"));
      this.oleDbInsertCommand1.Parameters.Add(new OleDbParameter("Пост", OleDbType.VarWChar, 50, "Пост"));
      this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=C:\\mdb\\AGNKS2.mdb;Mode=ReadWrite|Share Deny None;Extended Properties=\"\";Jet OLEDB:System database=\"\";Jet OLEDB:Registry Path=\"\";Jet OLEDB:Database Password=\"\";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password=\"\";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
      this.oleDbSelectCommand1.CommandText = "SELECT Авария, Дата, Оператор, Подтверждение, Пост FROM Alarms";
      this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
      this.AlarmWriteCmd.CommandText = "INSERT INTO Alarms(Авария, Дата, Оператор, Подтверждение, Пост) VALUES (?, ?, ?, ?, ?)";
      this.AlarmWriteCmd.Connection = this.oleDbConnection1;
      this.AlarmWriteCmd.Parameters.Add(new OleDbParameter("Авария", OleDbType.VarWChar, 200, "Авария"));
      this.AlarmWriteCmd.Parameters.Add(new OleDbParameter("Дата", OleDbType.Date, 0, "Дата"));
      this.AlarmWriteCmd.Parameters.Add(new OleDbParameter("Оператор", OleDbType.VarWChar, 50, "Оператор"));
      this.AlarmWriteCmd.Parameters.Add(new OleDbParameter("Подтверждение", OleDbType.VarWChar, 50, "Подтверждение"));
      this.AlarmWriteCmd.Parameters.Add(new OleDbParameter("Пост", OleDbType.VarWChar, 50, "Пост"));
      this.UpDatebutton.Location = new Point(648, 208);
      this.UpDatebutton.Name = "UpDatebutton";
      this.UpDatebutton.TabIndex = 4;
      this.UpDatebutton.Text = "Обновить";
      this.UpDatebutton.Click += new EventHandler(this.UpDatebutton_Click);
      this.UpDateAlarmslist.Columns.AddRange(new ColumnHeader[3]
      {
        this.DateHeader,
        this.PostHeader,
        this.AlarmHeader
      });
      this.UpDateAlarmslist.FullRowSelect = true;
      this.UpDateAlarmslist.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.UpDateAlarmslist.Location = new Point(8, 32);
      this.UpDateAlarmslist.MultiSelect = false;
      this.UpDateAlarmslist.Name = "UpDateAlarmslist";
      this.UpDateAlarmslist.Size = new Size(712, 128);
      this.UpDateAlarmslist.TabIndex = 5;
      this.UpDateAlarmslist.View = View.Details;
      this.UpDateAlarmslist.Click += new EventHandler(this.UpDateAlarmslist_Click);
      this.DateHeader.Text = "Дата";
      this.DateHeader.Width = 120;
      this.PostHeader.Text = "Пост";
      this.AlarmHeader.Text = "Авария";
      this.AlarmHeader.Width = 340;
      this.label1.Location = new Point(8, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(712, 23);
      this.label1.TabIndex = 6;
      this.label1.Text = "Подтверждение аварии";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.groupBox1.Location = new Point(8, 168);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(712, 8);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.label2.Location = new Point(8, 184);
      this.label2.Name = "label2";
      this.label2.Size = new Size(712, 23);
      this.label2.TabIndex = 8;
      this.label2.Text = "Архив аварий";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(728, 469);
      this.Controls.AddRange(new Control[7]
      {
        (Control) this.label2,
        (Control) this.groupBox1,
        (Control) this.label1,
        (Control) this.UpDateAlarmslist,
        (Control) this.AlarmsdataGrid,
        (Control) this.UpDatebutton,
        (Control) this.ExitBut
      });
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AlarmsArhive);
      this.Text = nameof (AlarmsArhive);
      this.TopMost = true;
      this.Closing += new CancelEventHandler(this.AlarmsArhive_Closing);
      this.VisibleChanged += new EventHandler(this.AlarmsArhive_VisibleChanged);
      this.AlarmsdataGrid.EndInit();
      this.alarmsDataSet1.EndInit();
      this.ResumeLayout(false);
    }

    private void ExitBut_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    public void ShowAlarmsArhive()
    {
      this.alarmsDataSet1.Clear();
      this.oleDbDataAdapter1.Fill((DataSet) this.alarmsDataSet1);
    }

    private void AlarmsArhive_Closing(object sender, CancelEventArgs e)
    {
      this.Hide();
    }

    public DataOfCol pDataCol1
    {
      set
      {
        this.m_DataCol1 = value;
        this.m_DataCol1.OnChangeValue += new ChangeValue(this.PostChangedTags1);
      }
    }

    public DataOfCol pDataCol2
    {
      set
      {
        this.m_DataCol2 = value;
        this.m_DataCol2.OnChangeValue += new ChangeValue(this.PostChangedTags2);
      }
    }

    public DataOfCol pDataCol3
    {
      set
      {
        this.m_DataCol3 = value;
        this.m_DataCol3.OnChangeValue += new ChangeValue(this.PostChangedTags3);
      }
    }

    public DataOfCol pDataCol4
    {
      set
      {
        this.m_DataCol4 = value;
        this.m_DataCol4.OnChangeValue += new ChangeValue(this.PostChangedTags4);
      }
    }

    private void PostChangedTags1(object sender, EventInfo ei)
    {
      if (this.m_DataCol1.ini)
        return;
      if (ei.msg == "AlarmFlow")
        this.WriteAlarm("Расход сверхнормы", "Пост1", (bool) ei.val);
      if (ei.msg == "NoGasAlarm")
        this.WriteAlarm("Отсутствует расход газа после открытия клапана", "Пост1", (bool) ei.val);
      if (ei.msg == "AlarmLeakage")
        this.WriteAlarm("Утечка газа", "Пост1", (bool) ei.val);
      if (!(ei.msg == "CountAlarm"))
        return;
      this.WriteAlarm("Счётчик газа", "Пост1", (bool) ei.val);
    }

    private void PostChangedTags2(object sender, EventInfo ei)
    {
      if (this.m_DataCol2.ini)
        return;
      if (ei.msg == "AlarmFlow")
        this.WriteAlarm("Расход сверхнормы", "Пост2", (bool) ei.val);
      if (ei.msg == "NoGasAlarm")
        this.WriteAlarm("Отсутствует расход газа после открытия клапана", "Пост2", (bool) ei.val);
      if (ei.msg == "AlarmLeakage")
        this.WriteAlarm("Утечка газа", "Пост2", (bool) ei.val);
      if (!(ei.msg == "CountAlarm"))
        return;
      this.WriteAlarm("Счётчик газа", "Пост2", (bool) ei.val);
    }

    private void PostChangedTags3(object sender, EventInfo ei)
    {
      if (this.m_DataCol3.ini)
        return;
      if (ei.msg == "AlarmFlow")
        this.WriteAlarm("Расход сверхнормы", "Пост3", (bool) ei.val);
      if (ei.msg == "NoGasAlarm")
        this.WriteAlarm("Отсутствует расход газа после открытия клапана", "Пост3", (bool) ei.val);
      if (ei.msg == "AlarmLeakage")
        this.WriteAlarm("Утечка газа", "Пост3", (bool) ei.val);
      if (!(ei.msg == "CountAlarm"))
        return;
      this.WriteAlarm("Счётчик газа", "Пост3", (bool) ei.val);
    }

    private void PostChangedTags4(object sender, EventInfo ei)
    {
      if (this.m_DataCol4.ini)
        return;
      if (ei.msg == "AlarmFlow")
        this.WriteAlarm("Расход сверхнормы", "Пост4", (bool) ei.val);
      if (ei.msg == "NoGasAlarm")
        this.WriteAlarm("Отсутствует расход газа после открытия клапана", "Пост4", (bool) ei.val);
      if (ei.msg == "AlarmLeakage")
        this.WriteAlarm("Утечка газа", "Пост4", (bool) ei.val);
      if (!(ei.msg == "CountAlarm"))
        return;
      this.WriteAlarm("Счётчик газа", "Пост4", (bool) ei.val);
    }

    public void WriteAlarm(string alarm, string post, bool val)
    {
      if (!val)
        return;
      if (alarm == "Счётчик газа")
        return;
      try
      {
        this.AlarmWriteCmd.CommandText = "INSERT INTO Alarms(Авария, Дата, Оператор, Подтверждение, Пост) VALUES (?, ?, ?, ?, ?)";
        this.AlarmWriteCmd.Parameters["Дата"].Value = (object) DateTime.Now;
        this.AlarmWriteCmd.Parameters["Оператор"].Value = (object) this.UserName.Text;
        this.AlarmWriteCmd.Parameters["Пост"].Value = (object) post;
        this.AlarmWriteCmd.Parameters["Авария"].Value = (object) alarm;
        this.AlarmWriteCmd.Parameters["Подтверждение"].Value = (object) "нет";
        if (this.oleDbConnection1.State == ConnectionState.Closed)
          this.oleDbConnection1.Open();
        this.AlarmWriteCmd.ExecuteNonQuery();
        this.oleDbConnection1.Close();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      ListViewItem listViewItem = new ListViewItem()
      {
        SubItems = {
          [0] = {
            Text = DateTime.Now.ToString()
          }
        }
      };
      listViewItem.SubItems.Add(post);
      listViewItem.SubItems.Add(alarm);
      this.UpDateAlarmslist.Items.Add(listViewItem);
    }

    private void UpDatebutton_Click(object sender, EventArgs e)
    {
      this.ShowAlarmsArhive();
    }

    private void AlarmsArhive_VisibleChanged(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;
      this.ShowAlarmsArhive();
    }

    private void UpDateAlarmslist_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem listViewItem in this.UpDateAlarmslist.Items)
      {
        if (listViewItem.Selected)
        {
          DateTime dateTime1 = new DateTime();
          DateTime dateTime2 = new DateTime();
          DateTime dateTime3;
          DateTime dateTime4 = dateTime3 = DateTime.Parse(listViewItem.Text);
          TimeSpan timeSpan = new TimeSpan(0, 0, 0, 1);
          DateTime dateTime5 = dateTime4 - timeSpan;
          DateTime dateTime6 = dateTime3 + timeSpan;
          try
          {
            string str1 = " Дата >= #" + dateTime5.Month.ToString() + "/" + dateTime5.Day.ToString() + "/" + dateTime5.Year.ToString() + " " + (object) dateTime5.Hour + ":" + (object) dateTime5.Minute + ":" + (object) dateTime5.Second + "#";
            string str2 = " Дата <= #" + dateTime6.Month.ToString() + "/" + dateTime6.Day.ToString() + "/" + dateTime6.Year.ToString() + " " + (object) dateTime6.Hour + ":" + (object) dateTime6.Minute + ":" + (object) dateTime6.Second + "#";
            this.AlarmWriteCmd.CommandText = "UPDATE Alarms SET  Подтверждение = 'Да' WHERE Пост = '" + listViewItem.SubItems[1].Text + "' AND Авария = '" + listViewItem.SubItems[2].Text + "' AND" + str1 + " AND" + str2;
            if (this.oleDbConnection1.State == ConnectionState.Closed)
              this.oleDbConnection1.Open();
            this.AlarmWriteCmd.ExecuteNonQuery();
            this.UpDateAlarmslist.Items.RemoveAt(listViewItem.Index);
            this.oleDbConnection1.Close();
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show(ex.Message);
          }
        }
      }
    }
  }
}
