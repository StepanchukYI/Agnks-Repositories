// Decompiled with JetBrains decompiler
// Type: agnks.Form1
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using ConfigAGNKS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace agnks
{
  public class Form1 : Form
  {
    private bool bSecurity = true;
    private string PathConfigFile = "ConfigAGNKS.xml";
    protected bool bBeginLightDay = true;
    protected bool bBeginLightNight = true;
    private MainMenu mainMenu1;
    private MenuItem menuItem1;
    private MenuItem menuItem12;
    private MenuItem menuItem13;
    private MenuItem menuItem14;
    private MenuItem menuItem15;
    private MenuItem menuItem16;
    private MenuItem menuItem17;
    private Panel panel1;
    private Label label1;
    private TextBox UserNameBox;
    private Post post1;
    private Post post2;
    private Post post3;
    private Post post4;
    private DataOfCol m_DataCol1;
    private DataOfCol m_DataCol2;
    private DataOfCol m_DataCol3;
    private DataOfCol m_DataCol4;
    private ChangeDensity m_ChangeDensity;
    private ChangeParamPosts m_ChangeParamPosts;
    private ChangeUserForm m_ChangeUser;
    private ChangePricesForm ChangePrices;
    private MenuItem menuItem18;
    private MenuItem menuItem19;
    private MenuItem menuItem20;
    private IContainer components;
    private MenuItem menuItem21;
    private MenuItem menuItem22;
    private MenuItem menuItem23;
    private ListParams m_ListParams;
    private MenuItem menuItem24;
    private MenuItem menuItem2;
    private MenuItem menuItem3;
    private MenuItem menuItem4;
    private MenuItem menuItem5;
    private MenuItem menuItem6;
    private MenuItem menuItem7;
    private MenuItem menuItem8;
    private MenuItem menuItem9;
    private MenuItem menuItem10;
    private MenuItem menuItem11;
    public AlarmSound m_AlarmSound;
    private MenuItem menuItem25;
    private MenuItem menuItem26;
    private MenuItem menuItem27;
    private MenuItem menuItem28;
    private Timer timerLight;
    private MenuItem menuItem29;
    private MenuItem menuItem30;
    private MenuItem menuItem31;
    private MenuItem menuItem32;
    private MenuItem menuItem33;
    private MenuItem menuItem34;
    private MenuItem menuItem35;
    public AlarmsArhive m_AlarmsArhive;
    public OPCAdapter m_OPCAdapter;
    public OPCAdapter m_OPCAdapter2;
    public OPCAdapter m_OPCAdapter3;
    public OPCAdapter m_OPCAdapter4;
    private Arhive arh;
    private WindowOPC opc;
    private ContractInput WindowCI;
    private bool find;
    private string NetPathColonka1;
    private string NetPathColonka2;
    private string NetPathColonka3;
    private string NetPathColonka4;
    private int BeginLightDay;
    private int BeginLightNight;

    public Form1()
    {
      this.InitializeComponent();
      this.LoadConfigFile();
      this.m_AlarmsArhive = new AlarmsArhive();
      this.m_AlarmsArhive.UserName = this.UserNameBox;
      this.m_DataCol1 = new DataOfCol();
      this.m_DataCol2 = new DataOfCol();
      this.m_DataCol3 = new DataOfCol();
      this.m_DataCol4 = new DataOfCol();
      this.post1.nPost = 1;
      this.post2.nPost = 2;
      this.post3.nPost = 3;
      this.post4.nPost = 4;
      this.m_OPCAdapter = new OPCAdapter();
      this.m_OPCAdapter.m_Data1 = this.m_DataCol1;
      this.m_OPCAdapter.NameGroup = "Post1";
      this.m_OPCAdapter.NameItems = this.NetPathColonka1;
      this.m_OPCAdapter2 = new OPCAdapter();
      this.m_OPCAdapter2.m_Data1 = this.m_DataCol2;
      this.m_OPCAdapter2.NameGroup = "Post2";
      this.m_OPCAdapter2.NameItems = this.NetPathColonka2;
      this.m_OPCAdapter3 = new OPCAdapter();
      this.m_OPCAdapter3.m_Data1 = this.m_DataCol3;
      this.m_OPCAdapter3.NameGroup = "Post3";
      this.m_OPCAdapter3.NameItems = this.NetPathColonka3;
      this.m_OPCAdapter4 = new OPCAdapter();
      this.m_OPCAdapter4.m_Data1 = this.m_DataCol4;
      this.m_OPCAdapter4.NameGroup = "Post4";
      this.m_OPCAdapter4.NameItems = this.NetPathColonka4;
      this.post1.pOPCAdapter = this.m_OPCAdapter;
      this.post1.data = this.m_DataCol1;
      this.post2.pOPCAdapter = this.m_OPCAdapter2;
      this.post2.data = this.m_DataCol2;
      this.post3.pOPCAdapter = this.m_OPCAdapter3;
      this.post3.data = this.m_DataCol3;
      this.post4.pOPCAdapter = this.m_OPCAdapter4;
      this.post4.data = this.m_DataCol4;
      this.m_ChangeParamPosts = new ChangeParamPosts();
      this.m_ChangeParamPosts.m_OPCAdapter = this.m_OPCAdapter;
      this.m_ChangeParamPosts.m_OPCAdapter2 = this.m_OPCAdapter2;
      this.m_ChangeParamPosts.m_OPCAdapter3 = this.m_OPCAdapter3;
      this.m_ChangeParamPosts.m_OPCAdapter4 = this.m_OPCAdapter4;
      this.m_ChangeParamPosts.BeginDayLight.Value = (Decimal) this.BeginLightDay;
      this.m_ChangeParamPosts.BeginNightLight.Value = (Decimal) this.BeginLightNight;
      this.post1.ParamPosts = this.m_ChangeParamPosts;
      this.post2.ParamPosts = this.m_ChangeParamPosts;
      this.post3.ParamPosts = this.m_ChangeParamPosts;
      this.post4.ParamPosts = this.m_ChangeParamPosts;
      this.arh = new Arhive();
      this.arh.UserName = this.UserNameBox;
      this.post1.pArh = this.arh;
      this.post2.pArh = this.arh;
      this.post3.pArh = this.arh;
      this.post4.pArh = this.arh;
      this.post1.m_AlarmsArhive = this.m_AlarmsArhive;
      this.post2.m_AlarmsArhive = this.m_AlarmsArhive;
      this.post3.m_AlarmsArhive = this.m_AlarmsArhive;
      this.post4.m_AlarmsArhive = this.m_AlarmsArhive;
      this.m_ChangeUser = new ChangeUserForm();
      this.m_ChangeUser.f = this;
      this.m_ChangeUser.LoadListUser();
      this.m_ChangeDensity = new ChangeDensity();
      this.m_ChangeDensity.m_OPCAdapter = this.m_OPCAdapter;
      this.m_ChangeDensity.m_OPCAdapter2 = this.m_OPCAdapter2;
      this.m_ChangeDensity.m_OPCAdapter3 = this.m_OPCAdapter3;
      this.m_ChangeDensity.m_OPCAdapter4 = this.m_OPCAdapter4;
      this.ChangePrices = new ChangePricesForm();
      this.ChangePrices.OnChangePriceList += new ChangePriceList(this.post1.ChangePricelist);
      this.ChangePrices.OnChangePriceList += new ChangePriceList(this.post2.ChangePricelist);
      this.ChangePrices.OnChangePriceList += new ChangePriceList(this.post3.ChangePricelist);
      this.ChangePrices.OnChangePriceList += new ChangePriceList(this.post4.ChangePricelist);
      this.ChangePrices.FullPricesList();
      this.UserNameBox.Text = this.m_ChangeUser.NewUser();
      this.m_ListParams = new ListParams();
      this.m_ListParams.m_DataCol1 = this.m_DataCol1;
      this.m_ListParams.m_DataCol2 = this.m_DataCol2;
      this.m_ListParams.m_DataCol3 = this.m_DataCol3;
      this.m_ListParams.m_DataCol4 = this.m_DataCol4;
      this.m_AlarmSound = new AlarmSound();
      this.m_AlarmSound.post1 = this.post1;
      this.m_AlarmSound.post2 = this.post2;
      this.m_AlarmSound.post3 = this.post3;
      this.m_AlarmSound.post4 = this.post4;
      this.m_AlarmsArhive.pDataCol1 = this.m_DataCol1;
      this.m_AlarmsArhive.pDataCol2 = this.m_DataCol2;
      this.m_AlarmsArhive.pDataCol3 = this.m_DataCol3;
      this.m_AlarmsArhive.pDataCol4 = this.m_DataCol4;
      this.m_AlarmsArhive.ControlBox = false;
      this.m_ChangeParamPosts.ControlBox = false;
      this.ChangePrices.ControlBox = false;
      this.m_ChangeUser.ControlBox = false;
      this.m_ListParams.ControlBox = false;
      this.m_OPCAdapter.CreateConnect();
      this.m_OPCAdapter.WriteHandlers();
      this.m_OPCAdapter2.CreateConnect();
      this.m_OPCAdapter2.WriteHandlers();
      this.m_OPCAdapter3.CreateConnect();
      this.m_OPCAdapter3.WriteHandlers();
      this.m_OPCAdapter4.CreateConnect();
      this.m_OPCAdapter4.WriteHandlers();
      this.m_OPCAdapter.StartThreadOPC();
      this.m_OPCAdapter2.StartThreadOPC();
      this.m_OPCAdapter3.StartThreadOPC();
      this.m_OPCAdapter4.StartThreadOPC();
      this.m_AlarmSound.StartThread();
      this.opc = new WindowOPC();
      this.WindowCI = new ContractInput();
      this.find = false;
      this.find = this.opc.FindOPC();
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
      ResourceManager resourceManager = new ResourceManager(typeof (Form1));
      this.mainMenu1 = new MainMenu();
      this.menuItem1 = new MenuItem();
      this.menuItem6 = new MenuItem();
      this.menuItem7 = new MenuItem();
      this.menuItem8 = new MenuItem();
      this.menuItem9 = new MenuItem();
      this.menuItem10 = new MenuItem();
      this.menuItem12 = new MenuItem();
      this.menuItem20 = new MenuItem();
      this.menuItem24 = new MenuItem();
      this.menuItem2 = new MenuItem();
      this.menuItem3 = new MenuItem();
      this.menuItem31 = new MenuItem();
      this.menuItem13 = new MenuItem();
      this.menuItem14 = new MenuItem();
      this.menuItem15 = new MenuItem();
      this.menuItem29 = new MenuItem();
      this.menuItem16 = new MenuItem();
      this.menuItem17 = new MenuItem();
      this.menuItem11 = new MenuItem();
      this.menuItem30 = new MenuItem();
      this.menuItem18 = new MenuItem();
      this.menuItem19 = new MenuItem();
      this.menuItem32 = new MenuItem();
      this.menuItem33 = new MenuItem();
      this.menuItem34 = new MenuItem();
      this.menuItem21 = new MenuItem();
      this.menuItem22 = new MenuItem();
      this.menuItem23 = new MenuItem();
      this.menuItem4 = new MenuItem();
      this.menuItem5 = new MenuItem();
      this.menuItem27 = new MenuItem();
      this.menuItem28 = new MenuItem();
      this.menuItem25 = new MenuItem();
      this.menuItem26 = new MenuItem();
      this.panel1 = new Panel();
      this.UserNameBox = new TextBox();
      this.label1 = new Label();
      this.post1 = new Post();
      this.post2 = new Post();
      this.post3 = new Post();
      this.post4 = new Post();
      this.timerLight = new Timer(this.components);
      this.menuItem35 = new MenuItem();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.mainMenu1.MenuItems.AddRange(new MenuItem[9]
      {
        this.menuItem1,
        this.menuItem13,
        this.menuItem16,
        this.menuItem18,
        this.menuItem32,
        this.menuItem21,
        this.menuItem4,
        this.menuItem27,
        this.menuItem25
      });
      this.menuItem1.Index = 0;
      this.menuItem1.MenuItems.AddRange(new MenuItem[5]
      {
        this.menuItem6,
        this.menuItem12,
        this.menuItem20,
        this.menuItem24,
        this.menuItem31
      });
      this.menuItem1.Text = "Управление постами";
      this.menuItem6.Index = 0;
      this.menuItem6.MenuItems.AddRange(new MenuItem[4]
      {
        this.menuItem7,
        this.menuItem8,
        this.menuItem9,
        this.menuItem10
      });
      this.menuItem6.Text = "Показать пост";
      this.menuItem7.Index = 0;
      this.menuItem7.Text = "Пост1";
      this.menuItem7.Click += new EventHandler(this.menuItem7_Click);
      this.menuItem8.Index = 1;
      this.menuItem8.Text = "Пост2";
      this.menuItem8.Click += new EventHandler(this.menuItem8_Click);
      this.menuItem9.Index = 2;
      this.menuItem9.Text = "Пост3";
      this.menuItem9.Click += new EventHandler(this.menuItem9_Click);
      this.menuItem10.Index = 3;
      this.menuItem10.Text = "Пост4";
      this.menuItem10.Click += new EventHandler(this.menuItem10_Click);
      this.menuItem12.Index = 1;
      this.menuItem12.Text = "Настройка постов";
      this.menuItem12.Click += new EventHandler(this.menuItem12_Click);
      this.menuItem20.Index = 2;
      this.menuItem20.Text = "Параметры постов";
      this.menuItem20.Click += new EventHandler(this.menuItem20_Click);
      this.menuItem24.Index = 3;
      this.menuItem24.MenuItems.AddRange(new MenuItem[2]
      {
        this.menuItem2,
        this.menuItem3
      });
      this.menuItem24.Text = "Яркость индикации";
      this.menuItem24.Select += new EventHandler(this.menuItem24_Select);
      this.menuItem2.Index = 0;
      this.menuItem2.Text = "Дневная";
      this.menuItem2.Click += new EventHandler(this.menuItem2_Click);
      this.menuItem3.Index = 1;
      this.menuItem3.Text = "Ночная";
      this.menuItem3.Click += new EventHandler(this.menuItem3_Click_1);
      this.menuItem31.Index = 4;
      this.menuItem31.Text = "Плотность газа";
      this.menuItem31.Click += new EventHandler(this.menuItem31_Click);
      this.menuItem13.Index = 1;
      this.menuItem13.MenuItems.AddRange(new MenuItem[3]
      {
        this.menuItem14,
        this.menuItem15,
        this.menuItem29
      });
      this.menuItem13.Text = "Оператор";
      this.menuItem14.Index = 0;
      this.menuItem14.Text = "Выбор оператора";
      this.menuItem14.Click += new EventHandler(this.menuItem14_Click);
      this.menuItem15.Index = 1;
      this.menuItem15.Text = "Изменить список операторов";
      this.menuItem15.Click += new EventHandler(this.menuItem15_Click);
      this.menuItem29.Index = 2;
      this.menuItem29.Text = "Изменить пароль";
      this.menuItem29.Click += new EventHandler(this.menuItem29_Click);
      this.menuItem16.Index = 2;
      this.menuItem16.MenuItems.AddRange(new MenuItem[3]
      {
        this.menuItem17,
        this.menuItem11,
        this.menuItem30
      });
      this.menuItem16.Text = "Базы данных";
      this.menuItem17.Index = 0;
      this.menuItem17.Text = "Архив заправок";
      this.menuItem17.Click += new EventHandler(this.menuItem17_Click);
      this.menuItem11.Index = 1;
      this.menuItem11.Text = "Архив аварий";
      this.menuItem11.Click += new EventHandler(this.menuItem11_Click);
      this.menuItem30.Index = 2;
      this.menuItem30.Text = "Генератор отчётов";
      this.menuItem30.Click += new EventHandler(this.menuItem30_Click);
      this.menuItem18.Index = 3;
      this.menuItem18.MenuItems.AddRange(new MenuItem[1]
      {
        this.menuItem19
      });
      this.menuItem18.Text = "Цены";
      this.menuItem19.Index = 0;
      this.menuItem19.Text = "Изменить цены";
      this.menuItem19.Click += new EventHandler(this.menuItem19_Click);
      this.menuItem32.Index = 4;
      this.menuItem32.MenuItems.AddRange(new MenuItem[3]
      {
        this.menuItem33,
        this.menuItem34,
        this.menuItem35
      });
      this.menuItem32.Text = "Договора";
      this.menuItem33.Index = 0;
      this.menuItem33.Text = "Записать договор в ЭККА";
      this.menuItem33.Click += new EventHandler(this.menuItem33_Click);
      this.menuItem34.Index = 1;
      this.menuItem34.Text = "Отчет по договорам";
      this.menuItem34.Click += new EventHandler(this.menuItem34_Click);
      this.menuItem21.Index = 5;
      this.menuItem21.MenuItems.AddRange(new MenuItem[2]
      {
        this.menuItem22,
        this.menuItem23
      });
      this.menuItem21.Text = "OPC";
      this.menuItem22.Index = 0;
      this.menuItem22.Text = "Показать ОРС сревер";
      this.menuItem22.Click += new EventHandler(this.menuItem22_Click);
      this.menuItem23.Index = 1;
      this.menuItem23.Text = "Скрыть ОРС сервер";
      this.menuItem23.Click += new EventHandler(this.menuItem23_Click);
      this.menuItem4.Index = 6;
      this.menuItem4.MenuItems.AddRange(new MenuItem[1]
      {
        this.menuItem5
      });
      this.menuItem4.Text = "Звуковой Сигнал";
      this.menuItem5.Index = 0;
      this.menuItem5.Text = "Отключить";
      this.menuItem5.Click += new EventHandler(this.menuItem5_Click);
      this.menuItem27.Index = 7;
      this.menuItem27.MenuItems.AddRange(new MenuItem[1]
      {
        this.menuItem28
      });
      this.menuItem27.Text = "Калькулятор";
      this.menuItem28.Index = 0;
      this.menuItem28.Text = "Открыть калькулятор";
      this.menuItem28.Click += new EventHandler(this.menuItem28_Click);
      this.menuItem25.Index = 8;
      this.menuItem25.MenuItems.AddRange(new MenuItem[1]
      {
        this.menuItem26
      });
      this.menuItem25.Text = "Справка";
      this.menuItem26.Index = 0;
      this.menuItem26.Text = "Содержание";
      this.menuItem26.Click += new EventHandler(this.menuItem26_Click);
      this.panel1.BackColor = SystemColors.ActiveBorder;
      this.panel1.BorderStyle = BorderStyle.FixedSingle;
      this.panel1.Controls.Add((Control) this.UserNameBox);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(792, 32);
      this.panel1.TabIndex = 0;
      this.UserNameBox.BackColor = SystemColors.Info;
      this.UserNameBox.Font = new Font("Microsoft Sans Serif", 12.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.UserNameBox.Location = new Point(136, 0);
      this.UserNameBox.Name = "UserNameBox";
      this.UserNameBox.ReadOnly = true;
      this.UserNameBox.Size = new Size(263, 26);
      this.UserNameBox.TabIndex = 1;
      this.UserNameBox.Text = "";
      this.label1.Font = new Font("Microsoft Sans Serif", 12.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label1.Location = new Point(28, 2);
      this.label1.Name = "label1";
      this.label1.Size = new Size(95, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Оператор";
      this.post1.BackColor = Color.Red;
      this.post1.Location = new Point(8, 40);
      this.post1.Name = "post1";
      this.post1.PostName = "Пост[1]";
      this.post1.Size = new Size(184, 472);
      this.post1.TabIndex = 1;
      this.post1.Visible = false;
      this.post2.BackColor = Color.Red;
      this.post2.Location = new Point(208, 40);
      this.post2.Name = "post2";
      this.post2.PostName = "Пост[2]";
      this.post2.Size = new Size(184, 472);
      this.post2.TabIndex = 2;
      this.post2.Visible = false;
      this.post3.BackColor = Color.Red;
      this.post3.Location = new Point(408, 40);
      this.post3.Name = "post3";
      this.post3.PostName = "Пост[3]";
      this.post3.Size = new Size(184, 472);
      this.post3.TabIndex = 3;
      this.post3.Visible = false;
      this.post4.BackColor = Color.Red;
      this.post4.Location = new Point(608, 40);
      this.post4.Name = "post4";
      this.post4.PostName = "Пост[4]";
      this.post4.Size = new Size(184, 472);
      this.post4.TabIndex = 4;
      this.post4.Visible = false;
      this.timerLight.Enabled = true;
      this.timerLight.Interval = 30000;
      this.timerLight.Tick += new EventHandler(this.timerLight_Tick);
      this.menuItem35.Index = 2;
      this.menuItem35.Text = "Опросить ЭККА";
      this.menuItem35.Click += new EventHandler(this.menuItem35_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.BackColor = SystemColors.ControlDark;
      this.ClientSize = new Size(792, 537);
      this.Controls.Add((Control) this.post4);
      this.Controls.Add((Control) this.post3);
      this.Controls.Add((Control) this.post2);
      this.Controls.Add((Control) this.post1);
      this.Controls.Add((Control) this.panel1);
      this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      this.Menu = this.mainMenu1;
      this.Name = nameof (Form1);
      this.Text = "АГНКС";
      this.WindowState = FormWindowState.Maximized;
      this.Closing += new CancelEventHandler(this.Form1_Closing);
      this.SizeChanged += new EventHandler(this.Form1_SizeChanged);
      this.Move += new EventHandler(this.Form1_Move);
      this.Closed += new EventHandler(this.Form1_Closed);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [STAThread]
    private static void Main()
    {
      Process[] processes = Process.GetProcesses();
      int num = 0;
      foreach (Process process in processes)
      {
        if (process.ProcessName == "agnks")
          ++num;
        if (num > 1)
          return;
      }
      Application.Run((Form) new Form1());
    }

    private void menuItem12_Click(object sender, EventArgs e)
    {
      if (this.bSecurity)
        return;
      this.m_ChangeParamPosts.Show();
    }

    private void Form1_Closed(object sender, EventArgs e)
    {
    }

    private void menuItem17_Click(object sender, EventArgs e)
    {
      this.arh.Show();
    }

    private void Form1_Closing(object sender, CancelEventArgs e)
    {
      this.m_OPCAdapter.FreeOPCAdapter();
      this.m_OPCAdapter2.FreeOPCAdapter();
      this.m_OPCAdapter3.FreeOPCAdapter();
      this.m_OPCAdapter4.FreeOPCAdapter();
      this.m_AlarmSound.threadfinish = true;
      this.SaveCongigFile();
    }

    private void menuItem14_Click(object sender, EventArgs e)
    {
      this.UserNameBox.Text = this.m_ChangeUser.NewUser();
    }

    private void menuItem15_Click(object sender, EventArgs e)
    {
      if (this.bSecurity)
        return;
      this.m_ChangeUser.Show();
    }

    public void security(string right)
    {
      if (right == "АДМИНИСТРАТОР")
      {
        this.menuItem31.Enabled = true;
        this.m_ChangeDensity.bSave.Enabled = true;
        this.DesktopBounds = new Rectangle(0, 0, 800, 600);
        this.ControlBox = true;
        this.bSecurity = false;
        this.menuItem21.Enabled = this.arh.Enabled = this.m_ChangeUser.Enabled = this.ChangePrices.Enabled = this.m_ChangeParamPosts.tabControl1.Enabled = this.post1.Enabled = this.post2.Enabled = this.post3.Enabled = this.post4.Enabled = this.menuItem1.Enabled = this.menuItem15.Enabled = this.menuItem16.Enabled = this.menuItem18.Enabled = this.menuItem29.Enabled = true;
        this.ChangePrices.Security(true);
      }
      else if (right == "МАСТЕР")
      {
        this.menuItem31.Enabled = true;
        this.m_ChangeDensity.bSave.Enabled = true;
        this.ControlBox = false;
        this.DesktopBounds = new Rectangle(0, 0, 800, 600);
        this.bSecurity = true;
        this.ChangePrices.Security(true);
        this.m_ChangeParamPosts.Hide();
        this.m_ChangeUser.Hide();
        this.arh.Hide();
        this.m_ChangeParamPosts.tabControl1.Enabled = this.m_ChangeUser.Enabled = false;
        this.menuItem21.Enabled = false;
        this.ChangePrices.Enabled = this.arh.Enabled = this.post1.Enabled = this.post2.Enabled = this.post3.Enabled = this.post4.Enabled = this.menuItem1.Enabled = this.menuItem15.Enabled = this.menuItem16.Enabled = this.menuItem18.Enabled = this.menuItem29.Enabled = true;
      }
      else if (right == "ОПЕРАТОР")
      {
        this.menuItem31.Enabled = false;
        this.m_ChangeDensity.bSave.Enabled = false;
        this.ControlBox = false;
        this.DesktopBounds = new Rectangle(0, 0, 800, 600);
        this.bSecurity = true;
        this.ChangePrices.Security(true);
        this.m_ChangeParamPosts.Hide();
        this.m_ChangeUser.Hide();
        this.arh.Hide();
        this.m_ChangeParamPosts.tabControl1.Enabled = this.m_ChangeUser.Enabled = false;
        this.menuItem21.Enabled = false;
        this.ChangePrices.Enabled = this.arh.Enabled = this.post1.Enabled = this.post2.Enabled = this.post3.Enabled = this.post4.Enabled = this.menuItem1.Enabled = this.menuItem15.Enabled = this.menuItem16.Enabled = this.menuItem18.Enabled = this.menuItem29.Enabled = true;
      }
      else
      {
        this.bSecurity = true;
        this.ControlBox = false;
        this.ChangePrices.Security(false);
        this.ChangePrices.Hide();
        this.m_ChangeParamPosts.Hide();
        this.m_ChangeUser.Hide();
        this.arh.Hide();
        this.menuItem21.Enabled = this.arh.Enabled = this.m_ChangeUser.Enabled = this.ChangePrices.Enabled = this.m_ChangeParamPosts.tabControl1.Enabled = this.post1.Enabled = this.post2.Enabled = this.post3.Enabled = this.post4.Enabled = this.menuItem1.Enabled = this.menuItem15.Enabled = this.menuItem16.Enabled = this.menuItem18.Enabled = this.menuItem29.Enabled = false;
      }
    }

    private void menuItem19_Click(object sender, EventArgs e)
    {
      this.ChangePrices.Show();
    }

    private void menuItem20_Click(object sender, EventArgs e)
    {
      this.m_ListParams.Show();
    }

    private void menuItem22_Click(object sender, EventArgs e)
    {
      if (!this.find)
        return;
      this.opc.OPCShow();
    }

    private void menuItem23_Click(object sender, EventArgs e)
    {
      if (!this.find)
        return;
      this.opc.OPCHide();
    }

    private void menuItem7_Click(object sender, EventArgs e)
    {
      if (!this.menuItem7.Checked)
      {
        this.post1.Visible = true;
        this.menuItem7.Checked = true;
      }
      else
      {
        this.post1.Visible = false;
        this.menuItem7.Checked = false;
      }
    }

    private void menuItem8_Click(object sender, EventArgs e)
    {
      if (!this.menuItem8.Checked)
      {
        this.post2.Visible = true;
        this.menuItem8.Checked = true;
      }
      else
      {
        this.post2.Visible = false;
        this.menuItem8.Checked = false;
      }
    }

    private void menuItem9_Click(object sender, EventArgs e)
    {
      if (!this.menuItem9.Checked)
      {
        this.post3.Visible = true;
        this.menuItem9.Checked = true;
      }
      else
      {
        this.post3.Visible = false;
        this.menuItem9.Checked = false;
      }
    }

    private void menuItem10_Click(object sender, EventArgs e)
    {
      if (!this.menuItem10.Checked)
      {
        this.post4.Visible = true;
        this.menuItem10.Checked = true;
      }
      else
      {
        this.post4.Visible = false;
        this.menuItem10.Checked = false;
      }
    }

    private void menuItem2_Click(object sender, EventArgs e)
    {
      this.ChangeLight(0);
      if (this.menuItem2.Checked)
        return;
      this.menuItem2.Checked = true;
      this.menuItem3.Checked = false;
    }

    private void menuItem3_Click_1(object sender, EventArgs e)
    {
      this.ChangeLight(1);
      if (this.menuItem3.Checked)
        return;
      this.menuItem3.Checked = true;
      this.menuItem2.Checked = false;
    }

    private void ChangeLight(int value)
    {
      int[] _handlesSrv1 = new int[1];
      int[] _handlesSrv2 = new int[1];
      int[] _handlesSrv3 = new int[1];
      int[] _handlesSrv4 = new int[1];
      _handlesSrv1[0] = this.m_DataCol1.handlesLIGHTDOWN;
      _handlesSrv2[0] = this.m_DataCol2.handlesLIGHTDOWN;
      _handlesSrv3[0] = this.m_DataCol3.handlesLIGHTDOWN;
      _handlesSrv4[0] = this.m_DataCol4.handlesLIGHTDOWN;
      object[] itemValues = new object[1]{ (object) value };
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
      this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
      this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
      this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
    }

    private void menuItem24_Select(object sender, EventArgs e)
    {
      if (this.m_DataCol1.LIGHTDOWN <= 0 && this.m_DataCol2.LIGHTDOWN <= 0 && this.m_DataCol3.LIGHTDOWN <= 0 && this.m_DataCol4.LIGHTDOWN <= 0)
      {
        this.menuItem2.Checked = true;
        this.menuItem3.Checked = false;
      }
      else
      {
        this.menuItem3.Checked = true;
        this.menuItem2.Checked = false;
      }
    }

    private void menuItem5_Click(object sender, EventArgs e)
    {
      this.m_AlarmSound.OffSound();
    }

    private void LoadConfigFile()
    {
      AGNKSconfig agnkSconfig1 = new AGNKSconfig();
      if (File.Exists(this.PathConfigFile))
      {
        Stream serializationStream = (Stream) File.OpenRead(this.PathConfigFile);
        AGNKSconfig agnkSconfig2 = (AGNKSconfig) new SoapFormatter().Deserialize(serializationStream);
        serializationStream.Close();
        this.NetPathColonka1 = agnkSconfig2.NetPath1;
        this.NetPathColonka2 = agnkSconfig2.NetPath2;
        this.NetPathColonka3 = agnkSconfig2.NetPath3;
        this.NetPathColonka4 = agnkSconfig2.NetPath4;
        this.menuItem7.Checked = this.post1.Visible = agnkSconfig2.VisibleColonka1;
        this.menuItem8.Checked = this.post2.Visible = agnkSconfig2.VisibleColonka2;
        this.menuItem9.Checked = this.post3.Visible = agnkSconfig2.VisibleColonka3;
        this.menuItem10.Checked = this.post4.Visible = agnkSconfig2.VisibleColonka4;
        this.BeginLightDay = agnkSconfig2.DayLight;
        this.BeginLightNight = agnkSconfig2.NightLight;
        ChangePricesForm.MainCodPrice = agnkSconfig2.MainCodPrice;
      }
      else
      {
        this.NetPathColonka1 = "UltraNet_1.01.";
        this.NetPathColonka2 = "UltraNet_1.02.";
        this.NetPathColonka3 = "UltraNet_1.03.";
        this.NetPathColonka4 = "UltraNet_1.04.";
        this.BeginLightDay = 6;
        this.BeginLightNight = 20;
      }
    }

    private void SaveCongigFile()
    {
      AGNKSconfig agnkSconfig = new AGNKSconfig();
      agnkSconfig.NetPath1 = this.NetPathColonka1;
      agnkSconfig.NetPath2 = this.NetPathColonka2;
      agnkSconfig.NetPath3 = this.NetPathColonka3;
      agnkSconfig.NetPath4 = this.NetPathColonka4;
      agnkSconfig.VisibleColonka1 = this.post1.Visible;
      agnkSconfig.VisibleColonka2 = this.post2.Visible;
      agnkSconfig.VisibleColonka3 = this.post3.Visible;
      agnkSconfig.VisibleColonka4 = this.post4.Visible;
      agnkSconfig.DayLight = this.BeginLightDay;
      agnkSconfig.NightLight = this.BeginLightNight;
      agnkSconfig.MainCodPrice = ChangePricesForm.MainCodPrice;
      if (File.Exists(this.PathConfigFile))
        File.Delete(this.PathConfigFile);
      Stream serializationStream = (Stream) File.OpenWrite(this.PathConfigFile);
      new SoapFormatter().Serialize(serializationStream, (object) agnkSconfig);
      serializationStream.Close();
    }

    private void menuItem11_Click(object sender, EventArgs e)
    {
      this.m_AlarmsArhive.Show();
    }

    private void Form1_Move(object sender, EventArgs e)
    {
      this.DesktopBounds = new Rectangle(0, 0, 800, 600);
    }

    private void Form1_SizeChanged(object sender, EventArgs e)
    {
      this.DesktopBounds = new Rectangle(0, 0, 800, 600);
    }

    private void menuItem26_Click(object sender, EventArgs e)
    {
      Help.ShowHelp((Control) this, "AGNKS.chm");
    }

    private void menuItem28_Click(object sender, EventArgs e)
    {
      Process.Start("calc.exe", "");
    }

    private void timerLight_Tick(object sender, EventArgs e)
    {
      this.BeginLightDay = (int) this.m_ChangeParamPosts.BeginDayLight.Value;
      this.BeginLightNight = (int) this.m_ChangeParamPosts.BeginNightLight.Value;
      DateTime now = DateTime.Now;
      if (now.Hour == this.BeginLightDay && this.bBeginLightDay)
      {
        this.bBeginLightDay = false;
        this.bBeginLightNight = true;
        this.ChangeLight(0);
        this.menuItem2.Checked = true;
        this.menuItem3.Checked = false;
      }
      if (now.Hour != this.BeginLightNight || !this.bBeginLightNight)
        return;
      this.bBeginLightDay = true;
      this.bBeginLightNight = false;
      this.ChangeLight(1);
      this.menuItem2.Checked = false;
      this.menuItem3.Checked = true;
    }

    private void menuItem29_Click(object sender, EventArgs e)
    {
      this.m_ChangeUser.ChangePassword(this.UserNameBox.Text);
    }

    private void menuItem30_Click(object sender, EventArgs e)
    {
      IntPtr window = Arhive.FindWindow((string) null, "Отчёты");
      if (window.ToInt32() == 0)
      {
        try
        {
          Process.Start("Report.exe");
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

    private void menuItem31_Click(object sender, EventArgs e)
    {
      this.m_ChangeDensity.Show();
    }

    private void menuItem33_Click(object sender, EventArgs e)
    {
      if (this.WindowCI.FindCIbttn())
        return;
      int num = (int) MessageBox.Show("Сервер договоров не запущен!");
    }

    private void menuItem34_Click(object sender, EventArgs e)
    {
      this.WindowCI.ShowContractsViewer();
    }

    private void menuItem35_Click(object sender, EventArgs e)
    {
      if (this.WindowCI.ClickOpros())
        return;
      int num = (int) MessageBox.Show("Сервер договоров не запущен!");
    }
  }
}
