// Decompiled with JetBrains decompiler
// Type: agnks.ChangeParamPosts
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class ChangeParamPosts : Form
  {
    private GroupBox groupBox1;
    public CheckBox TestPost4;
    public CheckBox TestPost2;
    public CheckBox TestPost3;
    public CheckBox TestPost1;
    private Button PostZero1;
    private Button PostZero2;
    private Button PostZero3;
    private Button PostZero4;
    private GroupBox groupBox2;
    private Button ExitFromForm;
    public OPCAdapter m_OPCAdapter;
    public OPCAdapter m_OPCAdapter2;
    public OPCAdapter m_OPCAdapter3;
    public OPCAdapter m_OPCAdapter4;
    public TextBox MainFormPriceBox;
    public TextBox MainFormDencityBox;
    private Label label10;
    private Label label7;
    private Label label9;
    private Label label8;
    private Label label5;
    private Label label4;
    private Label label1;
    private Label label6;
    private Label label3;
    public TabControl tabControl1;
    private TextBox VoBox;
    private TextBox MoBox;
    private TextBox DensityBox;
    private TextBox MinFlowBox;
    private TextBox MaxFlowBox;
    private Button WriteAllPosts;
    private TabPage tabPageGas;
    private TabPage tabPagePover;
    private TabPage tabPageRulePosts;
    private TabPage tabPageLight;
    private TextBox FBoxLine;
    private TextBox FBoxWordPover;
    private TabPage tabPageAlarms;
    private Label label2;
    private Label label11;
    private CheckBox LightCheck;
    private GroupBox groupBox3;
    private Button WriteAlarm;
    private Button ResetAlarmsPost4;
    private Button ResetAlarmsPost2;
    private Button ResetAlarmsPost3;
    private Button ResetAlarmsPost1;
    private Button ResetAlarmsAllPosts;
    private Button WriteLight;
    private RadioButton OnlyPost;
    private RadioButton OnlyPC;
    private RadioButton PcAndPost;
    private Label label13;
    private Label label12;
    private TextBox FlowOnEKM;
    private Label label15;
    private Label label16;
    private Label label17;
    public NumericUpDown BeginDayLight;
    public NumericUpDown BeginNightLight;
    private Label label18;
    private Label label19;
    private GroupBox groupBox4;
    private CheckBox EKKAPost4;
    private CheckBox EKKAPost3;
    private CheckBox EKKAPost2;
    private CheckBox EKKAPost1;
    private GroupBox groupBox5;
    private Label label20;
    private TextBox tOutstrip1;
    private TextBox tOutstrip2;
    private TextBox tOutstrip3;
    private TextBox tOutstrip4;
    private Label label21;
    private Label label22;
    private Label label23;
    private GroupBox groupBox6;
    private CheckBox ShowOver4;
    private CheckBox ShowOver3;
    private CheckBox ShowOver2;
    private CheckBox ShowOver1;
    private Timer timer1;
    private Timer timer2;
    private Timer timer3;
    private Timer timer4;
    private IContainer components;
    private Button WriteK;
    private TabPage tabPageKor;
    private TextBox tMassKor1;
    private TextBox tMassKor2;
    private TextBox tMassKor3;
    private TextBox tMassKor4;
    private Button bMassKor1;
    private Button bMassKor2;
    private Button bMassKor3;
    private Button bMassKor4;
    private TabPage tabPageTotalGas;
    private TextBox TotalGas1;
    private TextBox TotalGas2;
    private TextBox TotalGas3;
    private TextBox TotalGas4;
    private Button bTotalGas1;
    private Label label24;
    private Label label25;
    private Label label26;
    private Label label27;
    private Button bTotalGas2;
    private Button bTotalGas3;
    private Button bTotalGas4;
    private Label label14;

    public event ChangeParam OnChangeParamPost1;

    public event ChangeParam OnChangeParamPost2;

    public event ChangeParam OnChangeParamPost3;

    public event ChangeParam OnChangeParamPost4;

    public ChangeParamPosts()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (!disposing)
        ;
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.groupBox1 = new GroupBox();
      this.TestPost4 = new CheckBox();
      this.TestPost2 = new CheckBox();
      this.TestPost1 = new CheckBox();
      this.TestPost3 = new CheckBox();
      this.ExitFromForm = new Button();
      this.PostZero1 = new Button();
      this.PostZero2 = new Button();
      this.PostZero3 = new Button();
      this.PostZero4 = new Button();
      this.groupBox2 = new GroupBox();
      this.tabPageGas = new TabPage();
      this.label14 = new Label();
      this.label13 = new Label();
      this.VoBox = new TextBox();
      this.label10 = new Label();
      this.MoBox = new TextBox();
      this.label7 = new Label();
      this.label9 = new Label();
      this.DensityBox = new TextBox();
      this.label8 = new Label();
      this.label5 = new Label();
      this.WriteAllPosts = new Button();
      this.label4 = new Label();
      this.MinFlowBox = new TextBox();
      this.label1 = new Label();
      this.MaxFlowBox = new TextBox();
      this.label6 = new Label();
      this.label3 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPageKor = new TabPage();
      this.bMassKor4 = new Button();
      this.bMassKor3 = new Button();
      this.bMassKor2 = new Button();
      this.bMassKor1 = new Button();
      this.tMassKor4 = new TextBox();
      this.tMassKor3 = new TextBox();
      this.tMassKor2 = new TextBox();
      this.tMassKor1 = new TextBox();
      this.tabPagePover = new TabPage();
      this.groupBox4 = new GroupBox();
      this.EKKAPost4 = new CheckBox();
      this.EKKAPost2 = new CheckBox();
      this.EKKAPost1 = new CheckBox();
      this.EKKAPost3 = new CheckBox();
      this.tabPageLight = new TabPage();
      this.label19 = new Label();
      this.label18 = new Label();
      this.BeginNightLight = new NumericUpDown();
      this.BeginDayLight = new NumericUpDown();
      this.label17 = new Label();
      this.label16 = new Label();
      this.WriteLight = new Button();
      this.label11 = new Label();
      this.label2 = new Label();
      this.FBoxWordPover = new TextBox();
      this.FBoxLine = new TextBox();
      this.LightCheck = new CheckBox();
      this.tabPageRulePosts = new TabPage();
      this.groupBox6 = new GroupBox();
      this.ShowOver4 = new CheckBox();
      this.ShowOver3 = new CheckBox();
      this.ShowOver2 = new CheckBox();
      this.ShowOver1 = new CheckBox();
      this.groupBox5 = new GroupBox();
      this.WriteK = new Button();
      this.label23 = new Label();
      this.label22 = new Label();
      this.label21 = new Label();
      this.label20 = new Label();
      this.tOutstrip4 = new TextBox();
      this.tOutstrip3 = new TextBox();
      this.tOutstrip2 = new TextBox();
      this.tOutstrip1 = new TextBox();
      this.OnlyPost = new RadioButton();
      this.OnlyPC = new RadioButton();
      this.PcAndPost = new RadioButton();
      this.tabPageAlarms = new TabPage();
      this.label15 = new Label();
      this.FlowOnEKM = new TextBox();
      this.label12 = new Label();
      this.WriteAlarm = new Button();
      this.groupBox3 = new GroupBox();
      this.ResetAlarmsPost4 = new Button();
      this.ResetAlarmsPost2 = new Button();
      this.ResetAlarmsPost3 = new Button();
      this.ResetAlarmsPost1 = new Button();
      this.ResetAlarmsAllPosts = new Button();
      this.timer1 = new Timer(this.components);
      this.timer2 = new Timer(this.components);
      this.timer3 = new Timer(this.components);
      this.timer4 = new Timer(this.components);
      this.tabPageTotalGas = new TabPage();
      this.TotalGas1 = new TextBox();
      this.TotalGas2 = new TextBox();
      this.TotalGas3 = new TextBox();
      this.TotalGas4 = new TextBox();
      this.bTotalGas1 = new Button();
      this.label24 = new Label();
      this.label25 = new Label();
      this.label26 = new Label();
      this.label27 = new Label();
      this.bTotalGas2 = new Button();
      this.bTotalGas3 = new Button();
      this.bTotalGas4 = new Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tabPageGas.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageKor.SuspendLayout();
      this.tabPagePover.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.tabPageLight.SuspendLayout();
      this.BeginNightLight.BeginInit();
      this.BeginDayLight.BeginInit();
      this.tabPageRulePosts.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.tabPageAlarms.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.tabPageTotalGas.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.TestPost4);
      this.groupBox1.Controls.Add((Control) this.TestPost2);
      this.groupBox1.Controls.Add((Control) this.TestPost1);
      this.groupBox1.Controls.Add((Control) this.TestPost3);
      this.groupBox1.Location = new Point(8, 16);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(80, 120);
      this.groupBox1.TabIndex = 33;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Поверка";
      this.TestPost4.Location = new Point(8, 96);
      this.TestPost4.Name = "TestPost4";
      this.TestPost4.Size = new Size(64, 16);
      this.TestPost4.TabIndex = 21;
      this.TestPost4.Text = " Пост4";
      this.TestPost4.CheckedChanged += new EventHandler(this.TestPost1_CheckedChanged);
      this.TestPost2.Location = new Point(8, 48);
      this.TestPost2.Name = "TestPost2";
      this.TestPost2.Size = new Size(64, 16);
      this.TestPost2.TabIndex = 20;
      this.TestPost2.Text = " Пост2";
      this.TestPost2.CheckedChanged += new EventHandler(this.TestPost1_CheckedChanged);
      this.TestPost1.Location = new Point(8, 24);
      this.TestPost1.Name = "TestPost1";
      this.TestPost1.Size = new Size(64, 16);
      this.TestPost1.TabIndex = 18;
      this.TestPost1.Text = " Пост1";
      this.TestPost1.CheckedChanged += new EventHandler(this.TestPost1_CheckedChanged);
      this.TestPost3.Location = new Point(8, 72);
      this.TestPost3.Name = "TestPost3";
      this.TestPost3.Size = new Size(64, 16);
      this.TestPost3.TabIndex = 19;
      this.TestPost3.Text = " Пост3";
      this.TestPost3.CheckedChanged += new EventHandler(this.TestPost1_CheckedChanged);
      this.ExitFromForm.DialogResult = DialogResult.OK;
      this.ExitFromForm.Font = new Font("Microsoft Sans Serif", 10.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.ExitFromForm.Location = new Point(368, 24);
      this.ExitFromForm.Name = "ExitFromForm";
      this.ExitFromForm.Size = new Size(64, 32);
      this.ExitFromForm.TabIndex = 35;
      this.ExitFromForm.Text = "Выход";
      this.ExitFromForm.Click += new EventHandler(this.ExitFromForm_Click);
      this.PostZero1.Location = new Point(8, 16);
      this.PostZero1.Name = "PostZero1";
      this.PostZero1.Size = new Size(72, 24);
      this.PostZero1.TabIndex = 36;
      this.PostZero1.Text = "Пост1";
      this.PostZero1.Click += new EventHandler(this.PostZero1_Click);
      this.PostZero2.Location = new Point(8, 40);
      this.PostZero2.Name = "PostZero2";
      this.PostZero2.Size = new Size(72, 23);
      this.PostZero2.TabIndex = 37;
      this.PostZero2.Text = "Пост2";
      this.PostZero2.Click += new EventHandler(this.PostZero1_Click);
      this.PostZero3.Location = new Point(8, 64);
      this.PostZero3.Name = "PostZero3";
      this.PostZero3.Size = new Size(72, 23);
      this.PostZero3.TabIndex = 38;
      this.PostZero3.Text = "Пост3";
      this.PostZero3.Click += new EventHandler(this.PostZero1_Click);
      this.PostZero4.Location = new Point(8, 88);
      this.PostZero4.Name = "PostZero4";
      this.PostZero4.Size = new Size(72, 23);
      this.PostZero4.TabIndex = 39;
      this.PostZero4.Text = "Пост4";
      this.PostZero4.Click += new EventHandler(this.PostZero1_Click);
      this.groupBox2.Controls.Add((Control) this.PostZero3);
      this.groupBox2.Controls.Add((Control) this.PostZero4);
      this.groupBox2.Controls.Add((Control) this.PostZero1);
      this.groupBox2.Controls.Add((Control) this.PostZero2);
      this.groupBox2.Location = new Point(96, 16);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(112, 120);
      this.groupBox2.TabIndex = 40;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Калибровка нуля";
      this.tabPageGas.Controls.Add((Control) this.label14);
      this.tabPageGas.Controls.Add((Control) this.label13);
      this.tabPageGas.Controls.Add((Control) this.VoBox);
      this.tabPageGas.Controls.Add((Control) this.label10);
      this.tabPageGas.Controls.Add((Control) this.MoBox);
      this.tabPageGas.Controls.Add((Control) this.label7);
      this.tabPageGas.Controls.Add((Control) this.label9);
      this.tabPageGas.Controls.Add((Control) this.DensityBox);
      this.tabPageGas.Controls.Add((Control) this.label8);
      this.tabPageGas.Controls.Add((Control) this.label5);
      this.tabPageGas.Controls.Add((Control) this.WriteAllPosts);
      ((Control) this.tabPageGas).Location = new Point(4, 22);
      this.tabPageGas.Name = "tabPageGas";
      this.tabPageGas.Size = new Size(344, 158);
      this.tabPageGas.TabIndex = 0;
      this.tabPageGas.Text = "Параметры газа";
      this.label14.Location = new Point(40, 96);
      this.label14.Name = "label14";
      this.label14.Size = new Size(56, 16);
      this.label14.TabIndex = 37;
      this.label14.Text = "ЭККА";
      this.label13.Location = new Point(40, 64);
      this.label13.Name = "label13";
      this.label13.Size = new Size(88, 32);
      this.label13.TabIndex = 36;
      this.label13.Text = "Счётчика газа";
      this.label13.TextAlign = ContentAlignment.MiddleLeft;
      this.VoBox.Location = new Point(128, 96);
      this.VoBox.Name = "VoBox";
      this.VoBox.Size = new Size(48, 20);
      this.VoBox.TabIndex = 26;
      this.VoBox.Text = "0";
      this.VoBox.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.label10.Location = new Point(176, 96);
      this.label10.Name = "label10";
      this.label10.Size = new Size(112, 16);
      this.label10.TabIndex = 30;
      this.label10.Text = "нм3/импульс";
      this.MoBox.Location = new Point(128, 72);
      this.MoBox.Name = "MoBox";
      this.MoBox.Size = new Size(48, 20);
      this.MoBox.TabIndex = 25;
      this.MoBox.Text = "0";
      this.MoBox.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.label7.Location = new Point(176, 72);
      this.label7.Name = "label7";
      this.label7.Size = new Size(112, 16);
      this.label7.TabIndex = 31;
      this.label7.Text = "кг/импульс";
      this.label9.Location = new Point(8, 48);
      this.label9.Name = "label9";
      this.label9.Size = new Size(152, 24);
      this.label9.TabIndex = 20;
      this.label9.Text = "Дискретност измерения";
      this.DensityBox.Location = new Point(128, 16);
      this.DensityBox.Name = "DensityBox";
      this.DensityBox.Size = new Size(48, 20);
      this.DensityBox.TabIndex = 24;
      this.DensityBox.Text = "0";
      this.DensityBox.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.label8.Location = new Point(176, 16);
      this.label8.Name = "label8";
      this.label8.Size = new Size(56, 16);
      this.label8.TabIndex = 29;
      this.label8.Text = "кг/нм3";
      this.label5.Location = new Point(8, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(96, 16);
      this.label5.TabIndex = 19;
      this.label5.Text = "Плотность газа";
      this.WriteAllPosts.Location = new Point(272, 8);
      this.WriteAllPosts.Name = "WriteAllPosts";
      this.WriteAllPosts.Size = new Size(64, 32);
      this.WriteAllPosts.TabIndex = 35;
      this.WriteAllPosts.Text = "Записать";
      this.WriteAllPosts.Click += new EventHandler(this.WriteParam_Click);
      this.label4.Location = new Point(8, 40);
      this.label4.Name = "label4";
      this.label4.Size = new Size(120, 16);
      this.label4.TabIndex = 18;
      this.label4.Text = "Минимальный расход";
      this.MinFlowBox.Location = new Point(144, 40);
      this.MinFlowBox.Name = "MinFlowBox";
      this.MinFlowBox.Size = new Size(56, 20);
      this.MinFlowBox.TabIndex = 23;
      this.MinFlowBox.Text = "0";
      this.MinFlowBox.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.label1.Location = new Point(208, 40);
      this.label1.Name = "label1";
      this.label1.Size = new Size(56, 16);
      this.label1.TabIndex = 28;
      this.label1.Text = "нм3/мин";
      this.MaxFlowBox.Location = new Point(144, 16);
      this.MaxFlowBox.Name = "MaxFlowBox";
      this.MaxFlowBox.Size = new Size(56, 20);
      this.MaxFlowBox.TabIndex = 22;
      this.MaxFlowBox.Text = "0";
      this.MaxFlowBox.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.label6.Location = new Point(208, 16);
      this.label6.Name = "label6";
      this.label6.Size = new Size(56, 16);
      this.label6.TabIndex = 27;
      this.label6.Text = "нм3/мин";
      this.label3.Location = new Point(8, 16);
      this.label3.Name = "label3";
      this.label3.Size = new Size(128, 16);
      this.label3.TabIndex = 17;
      this.label3.Text = "Максимальный расход";
      this.tabControl1.Controls.Add((Control) this.tabPageGas);
      this.tabControl1.Controls.Add((Control) this.tabPagePover);
      this.tabControl1.Controls.Add((Control) this.tabPageRulePosts);
      this.tabControl1.Controls.Add((Control) this.tabPageTotalGas);
      this.tabControl1.Controls.Add((Control) this.tabPageLight);
      this.tabControl1.Controls.Add((Control) this.tabPageKor);
      this.tabControl1.Controls.Add((Control) this.tabPageAlarms);
      this.tabControl1.ItemSize = new Size(43, 18);
      this.tabControl1.Location = new Point(8, 24);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(352, 184);
      this.tabControl1.TabIndex = 42;
      this.tabPageKor.Controls.Add((Control) this.bMassKor4);
      this.tabPageKor.Controls.Add((Control) this.bMassKor3);
      this.tabPageKor.Controls.Add((Control) this.bMassKor2);
      this.tabPageKor.Controls.Add((Control) this.bMassKor1);
      this.tabPageKor.Controls.Add((Control) this.tMassKor4);
      this.tabPageKor.Controls.Add((Control) this.tMassKor3);
      this.tabPageKor.Controls.Add((Control) this.tMassKor2);
      this.tabPageKor.Controls.Add((Control) this.tMassKor1);
      ((Control) this.tabPageKor).Location = new Point(4, 22);
      this.tabPageKor.Name = "tabPageKor";
      this.tabPageKor.Size = new Size(344, 158);
      this.tabPageKor.TabIndex = 5;
      this.tabPageKor.Text = "Коррекция";
      this.bMassKor4.Location = new Point(112, 88);
      this.bMassKor4.Name = "bMassKor4";
      this.bMassKor4.TabIndex = 7;
      this.bMassKor4.Text = "Пост4";
      this.bMassKor4.Click += new EventHandler(this.bMassKor_Click);
      this.bMassKor3.Location = new Point(112, 64);
      this.bMassKor3.Name = "bMassKor3";
      this.bMassKor3.TabIndex = 6;
      this.bMassKor3.Text = "Пост3";
      this.bMassKor3.Click += new EventHandler(this.bMassKor_Click);
      this.bMassKor2.Location = new Point(112, 40);
      this.bMassKor2.Name = "bMassKor2";
      this.bMassKor2.TabIndex = 5;
      this.bMassKor2.Text = "Пост2";
      this.bMassKor2.Click += new EventHandler(this.bMassKor_Click);
      this.bMassKor1.Location = new Point(112, 16);
      this.bMassKor1.Name = "bMassKor1";
      this.bMassKor1.TabIndex = 4;
      this.bMassKor1.Text = "Пост1";
      this.bMassKor1.Click += new EventHandler(this.bMassKor_Click);
      this.tMassKor4.Location = new Point(8, 88);
      this.tMassKor4.Name = "tMassKor4";
      this.tMassKor4.TabIndex = 3;
      this.tMassKor4.Text = "textBox4";
      this.tMassKor3.Location = new Point(8, 64);
      this.tMassKor3.Name = "tMassKor3";
      this.tMassKor3.TabIndex = 2;
      this.tMassKor3.Text = "textBox3";
      this.tMassKor2.Location = new Point(8, 40);
      this.tMassKor2.Name = "tMassKor2";
      this.tMassKor2.TabIndex = 1;
      this.tMassKor2.Text = "MassKor2";
      this.tMassKor1.Location = new Point(8, 16);
      this.tMassKor1.Name = "tMassKor1";
      this.tMassKor1.TabIndex = 0;
      this.tMassKor1.Text = "MassKor1";
      this.tabPagePover.Controls.Add((Control) this.groupBox1);
      this.tabPagePover.Controls.Add((Control) this.groupBox2);
      this.tabPagePover.Controls.Add((Control) this.groupBox4);
      ((Control) this.tabPagePover).Location = new Point(4, 22);
      this.tabPagePover.Name = "tabPagePover";
      this.tabPagePover.Size = new Size(344, 158);
      this.tabPagePover.TabIndex = 1;
      this.tabPagePover.Text = "Поверка и калибровка";
      this.groupBox4.Controls.Add((Control) this.EKKAPost4);
      this.groupBox4.Controls.Add((Control) this.EKKAPost2);
      this.groupBox4.Controls.Add((Control) this.EKKAPost1);
      this.groupBox4.Controls.Add((Control) this.EKKAPost3);
      this.groupBox4.Location = new Point(216, 16);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(112, 120);
      this.groupBox4.TabIndex = 34;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Им. ЭККА";
      this.EKKAPost4.Location = new Point(8, 96);
      this.EKKAPost4.Name = "EKKAPost4";
      this.EKKAPost4.Size = new Size(64, 16);
      this.EKKAPost4.TabIndex = 21;
      this.EKKAPost4.Text = "Пост4";
      this.EKKAPost4.CheckedChanged += new EventHandler(this.EKKA_CheckedChanged);
      this.EKKAPost2.Location = new Point(8, 48);
      this.EKKAPost2.Name = "EKKAPost2";
      this.EKKAPost2.Size = new Size(64, 16);
      this.EKKAPost2.TabIndex = 20;
      this.EKKAPost2.Text = "Пост2";
      this.EKKAPost2.CheckedChanged += new EventHandler(this.EKKA_CheckedChanged);
      this.EKKAPost1.Location = new Point(8, 24);
      this.EKKAPost1.Name = "EKKAPost1";
      this.EKKAPost1.Size = new Size(64, 16);
      this.EKKAPost1.TabIndex = 18;
      this.EKKAPost1.Text = "Пост1";
      this.EKKAPost1.CheckedChanged += new EventHandler(this.EKKA_CheckedChanged);
      this.EKKAPost3.Location = new Point(8, 72);
      this.EKKAPost3.Name = "EKKAPost3";
      this.EKKAPost3.Size = new Size(64, 16);
      this.EKKAPost3.TabIndex = 19;
      this.EKKAPost3.Text = "Пост3";
      this.EKKAPost3.CheckedChanged += new EventHandler(this.EKKA_CheckedChanged);
      this.tabPageLight.Controls.Add((Control) this.label19);
      this.tabPageLight.Controls.Add((Control) this.label18);
      this.tabPageLight.Controls.Add((Control) this.BeginNightLight);
      this.tabPageLight.Controls.Add((Control) this.BeginDayLight);
      this.tabPageLight.Controls.Add((Control) this.label17);
      this.tabPageLight.Controls.Add((Control) this.label16);
      this.tabPageLight.Controls.Add((Control) this.WriteLight);
      this.tabPageLight.Controls.Add((Control) this.label11);
      this.tabPageLight.Controls.Add((Control) this.label2);
      this.tabPageLight.Controls.Add((Control) this.FBoxWordPover);
      this.tabPageLight.Controls.Add((Control) this.FBoxLine);
      this.tabPageLight.Controls.Add((Control) this.LightCheck);
      ((Control) this.tabPageLight).Location = new Point(4, 22);
      this.tabPageLight.Name = "tabPageLight";
      this.tabPageLight.Size = new Size(344, 158);
      this.tabPageLight.TabIndex = 3;
      this.tabPageLight.Text = "Индикация";
      this.label19.Location = new Point(176, 128);
      this.label19.Name = "label19";
      this.label19.Size = new Size(40, 16);
      this.label19.TabIndex = 42;
      this.label19.Text = "часов";
      this.label18.Location = new Point(176, 104);
      this.label18.Name = "label18";
      this.label18.Size = new Size(40, 16);
      this.label18.TabIndex = 41;
      this.label18.Text = "часов";
      this.BeginNightLight.Location = new Point(128, 120);
      this.BeginNightLight.Maximum = new Decimal(new int[4]
      {
        23,
        0,
        0,
        0
      });
      this.BeginNightLight.Name = "BeginNightLight";
      this.BeginNightLight.Size = new Size(40, 20);
      this.BeginNightLight.TabIndex = 40;
      this.BeginNightLight.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.BeginDayLight.Location = new Point(128, 96);
      this.BeginDayLight.Maximum = new Decimal(new int[4]
      {
        23,
        0,
        0,
        0
      });
      this.BeginDayLight.Name = "BeginDayLight";
      this.BeginDayLight.Size = new Size(40, 20);
      this.BeginDayLight.TabIndex = 39;
      this.BeginDayLight.Value = new Decimal(new int[4]
      {
        6,
        0,
        0,
        0
      });
      this.label17.Location = new Point(16, 128);
      this.label17.Name = "label17";
      this.label17.Size = new Size(96, 16);
      this.label17.TabIndex = 38;
      this.label17.Text = "Ночная яркость с";
      this.label16.Location = new Point(16, 104);
      this.label16.Name = "label16";
      this.label16.Size = new Size(104, 16);
      this.label16.TabIndex = 37;
      this.label16.Text = "Дневная яркость с ";
      this.WriteLight.Location = new Point(272, 8);
      this.WriteLight.Name = "WriteLight";
      this.WriteLight.Size = new Size(64, 32);
      this.WriteLight.TabIndex = 36;
      this.WriteLight.Text = "Записать";
      this.WriteLight.Click += new EventHandler(this.WriteLight_Click);
      this.label11.Location = new Point(56, 72);
      this.label11.Name = "label11";
      this.label11.Size = new Size(160, 16);
      this.label11.TabIndex = 5;
      this.label11.Text = "Частота индикации \"ПОВЕР\"";
      this.label2.Location = new Point(56, 48);
      this.label2.Name = "label2";
      this.label2.Size = new Size(176, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Частота индикации заправки";
      this.FBoxWordPover.Location = new Point(16, 72);
      this.FBoxWordPover.Name = "FBoxWordPover";
      this.FBoxWordPover.Size = new Size(32, 20);
      this.FBoxWordPover.TabIndex = 3;
      this.FBoxWordPover.Text = "0";
      this.FBoxWordPover.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.FBoxLine.Location = new Point(16, 48);
      this.FBoxLine.Name = "FBoxLine";
      this.FBoxLine.Size = new Size(32, 20);
      this.FBoxLine.TabIndex = 1;
      this.FBoxLine.Text = "0";
      this.FBoxLine.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.LightCheck.Checked = true;
      this.LightCheck.CheckState = CheckState.Checked;
      this.LightCheck.Location = new Point(16, 16);
      this.LightCheck.Name = "LightCheck";
      this.LightCheck.Size = new Size(200, 24);
      this.LightCheck.TabIndex = 0;
      this.LightCheck.Text = "Включить индикацию заправки";
      this.LightCheck.CheckedChanged += new EventHandler(this.LightCheck_CheckedChanged);
      this.tabPageRulePosts.Controls.Add((Control) this.groupBox6);
      this.tabPageRulePosts.Controls.Add((Control) this.groupBox5);
      this.tabPageRulePosts.Controls.Add((Control) this.OnlyPost);
      this.tabPageRulePosts.Controls.Add((Control) this.OnlyPC);
      this.tabPageRulePosts.Controls.Add((Control) this.PcAndPost);
      ((Control) this.tabPageRulePosts).Location = new Point(4, 22);
      this.tabPageRulePosts.Name = "tabPageRulePosts";
      this.tabPageRulePosts.Size = new Size(344, 158);
      this.tabPageRulePosts.TabIndex = 2;
      this.tabPageRulePosts.Text = "Заправка";
      this.groupBox6.Controls.Add((Control) this.ShowOver4);
      this.groupBox6.Controls.Add((Control) this.ShowOver3);
      this.groupBox6.Controls.Add((Control) this.ShowOver2);
      this.groupBox6.Controls.Add((Control) this.ShowOver1);
      this.groupBox6.Location = new Point(8, 80);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(144, 72);
      this.groupBox6.TabIndex = 4;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Показ. перелив";
      this.ShowOver4.Checked = true;
      this.ShowOver4.CheckState = CheckState.Checked;
      this.ShowOver4.Location = new Point(80, 40);
      this.ShowOver4.Name = "ShowOver4";
      this.ShowOver4.Size = new Size(56, 24);
      this.ShowOver4.TabIndex = 3;
      this.ShowOver4.Text = "Пост4";
      this.ShowOver4.CheckedChanged += new EventHandler(this.ShowOver4_CheckedChanged);
      this.ShowOver3.Checked = true;
      this.ShowOver3.CheckState = CheckState.Checked;
      this.ShowOver3.Location = new Point(80, 16);
      this.ShowOver3.Name = "ShowOver3";
      this.ShowOver3.Size = new Size(56, 24);
      this.ShowOver3.TabIndex = 2;
      this.ShowOver3.Text = "Пост3";
      this.ShowOver3.CheckedChanged += new EventHandler(this.ShowOver3_CheckedChanged);
      this.ShowOver2.Checked = true;
      this.ShowOver2.CheckState = CheckState.Checked;
      this.ShowOver2.Location = new Point(8, 40);
      this.ShowOver2.Name = "ShowOver2";
      this.ShowOver2.Size = new Size(56, 24);
      this.ShowOver2.TabIndex = 1;
      this.ShowOver2.Text = "Пост2";
      this.ShowOver2.CheckedChanged += new EventHandler(this.ShowOver2_CheckedChanged);
      this.ShowOver1.Checked = true;
      this.ShowOver1.CheckState = CheckState.Checked;
      this.ShowOver1.Location = new Point(8, 16);
      this.ShowOver1.Name = "ShowOver1";
      this.ShowOver1.Size = new Size(56, 24);
      this.ShowOver1.TabIndex = 0;
      this.ShowOver1.Text = "Пост1";
      this.ShowOver1.CheckedChanged += new EventHandler(this.ShowOver1_CheckedChanged);
      this.groupBox5.Controls.Add((Control) this.WriteK);
      this.groupBox5.Controls.Add((Control) this.label23);
      this.groupBox5.Controls.Add((Control) this.label22);
      this.groupBox5.Controls.Add((Control) this.label21);
      this.groupBox5.Controls.Add((Control) this.label20);
      this.groupBox5.Controls.Add((Control) this.tOutstrip4);
      this.groupBox5.Controls.Add((Control) this.tOutstrip3);
      this.groupBox5.Controls.Add((Control) this.tOutstrip2);
      this.groupBox5.Controls.Add((Control) this.tOutstrip1);
      this.groupBox5.Location = new Point(160, 8);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(176, 144);
      this.groupBox5.TabIndex = 3;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Коэффициент  предзакрытия  клапана";
      this.WriteK.Location = new Point(136, 24);
      this.WriteK.Name = "WriteK";
      this.WriteK.Size = new Size(32, 112);
      this.WriteK.TabIndex = 8;
      this.WriteK.Text = "З   а   п    и    с    а    т    ь";
      this.WriteK.Click += new EventHandler(this.WriteK_Click);
      this.label23.Location = new Point(80, 104);
      this.label23.Name = "label23";
      this.label23.Size = new Size(48, 23);
      this.label23.TabIndex = 7;
      this.label23.Text = "Пост4";
      this.label23.TextAlign = ContentAlignment.MiddleLeft;
      this.label22.Location = new Point(80, 80);
      this.label22.Name = "label22";
      this.label22.Size = new Size(48, 23);
      this.label22.TabIndex = 6;
      this.label22.Text = "Пост3";
      this.label22.TextAlign = ContentAlignment.MiddleLeft;
      this.label21.Location = new Point(80, 56);
      this.label21.Name = "label21";
      this.label21.Size = new Size(48, 23);
      this.label21.TabIndex = 5;
      this.label21.Text = "Пост2";
      this.label21.TextAlign = ContentAlignment.MiddleLeft;
      this.label20.Location = new Point(80, 32);
      this.label20.Name = "label20";
      this.label20.Size = new Size(48, 23);
      this.label20.TabIndex = 4;
      this.label20.Text = "Пост1";
      this.label20.TextAlign = ContentAlignment.MiddleLeft;
      this.tOutstrip4.Location = new Point(16, 104);
      this.tOutstrip4.Name = "tOutstrip4";
      this.tOutstrip4.Size = new Size(56, 20);
      this.tOutstrip4.TabIndex = 3;
      this.tOutstrip4.Text = "";
      this.tOutstrip4.TextChanged += new EventHandler(this.tOutstrip4_TextChanged);
      this.tOutstrip3.Location = new Point(16, 80);
      this.tOutstrip3.Name = "tOutstrip3";
      this.tOutstrip3.Size = new Size(56, 20);
      this.tOutstrip3.TabIndex = 2;
      this.tOutstrip3.Text = "";
      this.tOutstrip3.TextChanged += new EventHandler(this.tOutstrip3_TextChanged);
      this.tOutstrip2.Location = new Point(16, 56);
      this.tOutstrip2.Name = "tOutstrip2";
      this.tOutstrip2.Size = new Size(56, 20);
      this.tOutstrip2.TabIndex = 1;
      this.tOutstrip2.Text = "";
      this.tOutstrip2.TextChanged += new EventHandler(this.tOutstrip2_TextChanged);
      this.tOutstrip1.Location = new Point(16, 32);
      this.tOutstrip1.Name = "tOutstrip1";
      this.tOutstrip1.Size = new Size(56, 20);
      this.tOutstrip1.TabIndex = 0;
      this.tOutstrip1.Text = "";
      this.tOutstrip1.TextChanged += new EventHandler(this.tOutstrip1_TextChanged);
      this.OnlyPost.Location = new Point(16, 56);
      this.OnlyPost.Name = "OnlyPost";
      this.OnlyPost.Size = new Size(144, 24);
      this.OnlyPost.TabIndex = 2;
      this.OnlyPost.Tag = (object) "";
      this.OnlyPost.Text = "Только с поста";
      this.OnlyPost.Click += new EventHandler(this.PostRuleChange);
      this.OnlyPC.Location = new Point(16, 32);
      this.OnlyPC.Name = "OnlyPC";
      this.OnlyPC.Size = new Size(144, 24);
      this.OnlyPC.TabIndex = 1;
      this.OnlyPC.Tag = (object) "";
      this.OnlyPC.Text = "Только с компьютера ";
      this.OnlyPC.Click += new EventHandler(this.PostRuleChange);
      this.PcAndPost.Checked = true;
      this.PcAndPost.Location = new Point(16, 8);
      this.PcAndPost.Name = "PcAndPost";
      this.PcAndPost.Size = new Size(144, 24);
      this.PcAndPost.TabIndex = 0;
      this.PcAndPost.TabStop = true;
      this.PcAndPost.Tag = (object) "";
      this.PcAndPost.Text = "С компьютера и поста";
      this.PcAndPost.Click += new EventHandler(this.PostRuleChange);
      this.tabPageAlarms.Controls.Add((Control) this.label15);
      this.tabPageAlarms.Controls.Add((Control) this.FlowOnEKM);
      this.tabPageAlarms.Controls.Add((Control) this.label12);
      this.tabPageAlarms.Controls.Add((Control) this.WriteAlarm);
      this.tabPageAlarms.Controls.Add((Control) this.MinFlowBox);
      this.tabPageAlarms.Controls.Add((Control) this.label4);
      this.tabPageAlarms.Controls.Add((Control) this.label3);
      this.tabPageAlarms.Controls.Add((Control) this.MaxFlowBox);
      this.tabPageAlarms.Controls.Add((Control) this.label6);
      this.tabPageAlarms.Controls.Add((Control) this.label1);
      this.tabPageAlarms.Controls.Add((Control) this.groupBox3);
      ((Control) this.tabPageAlarms).Location = new Point(4, 22);
      this.tabPageAlarms.Name = "tabPageAlarms";
      this.tabPageAlarms.Size = new Size(344, 158);
      this.tabPageAlarms.TabIndex = 4;
      this.tabPageAlarms.Text = "Аварии";
      this.label15.Location = new Point(208, 67);
      this.label15.Name = "label15";
      this.label15.Size = new Size(56, 16);
      this.label15.TabIndex = 39;
      this.label15.Text = "нм3/мин";
      this.FlowOnEKM.Location = new Point(144, 65);
      this.FlowOnEKM.Name = "FlowOnEKM";
      this.FlowOnEKM.Size = new Size(56, 20);
      this.FlowOnEKM.TabIndex = 38;
      this.FlowOnEKM.Text = "0";
      this.FlowOnEKM.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.label12.Location = new Point(8, 67);
      this.label12.Name = "label12";
      this.label12.Size = new Size(120, 16);
      this.label12.TabIndex = 37;
      this.label12.Text = "Расход вкл ЕКМ";
      this.WriteAlarm.Location = new Point(272, 8);
      this.WriteAlarm.Name = "WriteAlarm";
      this.WriteAlarm.Size = new Size(64, 32);
      this.WriteAlarm.TabIndex = 36;
      this.WriteAlarm.Text = "Записать";
      this.WriteAlarm.Click += new EventHandler(this.WriteAlarm_Click);
      this.groupBox3.Controls.Add((Control) this.ResetAlarmsPost4);
      this.groupBox3.Controls.Add((Control) this.ResetAlarmsPost2);
      this.groupBox3.Controls.Add((Control) this.ResetAlarmsPost3);
      this.groupBox3.Controls.Add((Control) this.ResetAlarmsPost1);
      this.groupBox3.Controls.Add((Control) this.ResetAlarmsAllPosts);
      this.groupBox3.Location = new Point(8, 96);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(328, 48);
      this.groupBox3.TabIndex = 34;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Сброс аварий";
      this.ResetAlarmsPost4.Location = new Point(264, 16);
      this.ResetAlarmsPost4.Name = "ResetAlarmsPost4";
      this.ResetAlarmsPost4.Size = new Size(56, 23);
      this.ResetAlarmsPost4.TabIndex = 4;
      this.ResetAlarmsPost4.Text = "Пост4";
      this.ResetAlarmsPost4.Click += new EventHandler(this.ResetAlarm);
      this.ResetAlarmsPost2.Location = new Point(136, 16);
      this.ResetAlarmsPost2.Name = "ResetAlarmsPost2";
      this.ResetAlarmsPost2.Size = new Size(56, 23);
      this.ResetAlarmsPost2.TabIndex = 3;
      this.ResetAlarmsPost2.Text = "Пост2";
      this.ResetAlarmsPost2.Click += new EventHandler(this.ResetAlarm);
      this.ResetAlarmsPost3.Location = new Point(200, 16);
      this.ResetAlarmsPost3.Name = "ResetAlarmsPost3";
      this.ResetAlarmsPost3.Size = new Size(56, 23);
      this.ResetAlarmsPost3.TabIndex = 2;
      this.ResetAlarmsPost3.Text = "Пост3";
      this.ResetAlarmsPost3.Click += new EventHandler(this.ResetAlarm);
      this.ResetAlarmsPost1.Location = new Point(72, 16);
      this.ResetAlarmsPost1.Name = "ResetAlarmsPost1";
      this.ResetAlarmsPost1.Size = new Size(56, 23);
      this.ResetAlarmsPost1.TabIndex = 1;
      this.ResetAlarmsPost1.Text = "Пост1";
      this.ResetAlarmsPost1.Click += new EventHandler(this.ResetAlarm);
      this.ResetAlarmsAllPosts.Location = new Point(8, 16);
      this.ResetAlarmsAllPosts.Name = "ResetAlarmsAllPosts";
      this.ResetAlarmsAllPosts.Size = new Size(56, 24);
      this.ResetAlarmsAllPosts.TabIndex = 0;
      this.ResetAlarmsAllPosts.Text = "На всех";
      this.ResetAlarmsAllPosts.Click += new EventHandler(this.ResetAlarmsAllPosts_Click);
      this.timer1.Interval = 1000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.timer2.Interval = 1000;
      this.timer2.Tick += new EventHandler(this.timer2_Tick);
      this.timer3.Interval = 1000;
      this.timer3.Tick += new EventHandler(this.timer3_Tick);
      this.timer4.Interval = 1000;
      this.timer4.Tick += new EventHandler(this.timer4_Tick);
      this.tabPageTotalGas.Controls.Add((Control) this.bTotalGas4);
      this.tabPageTotalGas.Controls.Add((Control) this.bTotalGas3);
      this.tabPageTotalGas.Controls.Add((Control) this.bTotalGas2);
      this.tabPageTotalGas.Controls.Add((Control) this.label27);
      this.tabPageTotalGas.Controls.Add((Control) this.label26);
      this.tabPageTotalGas.Controls.Add((Control) this.label25);
      this.tabPageTotalGas.Controls.Add((Control) this.label24);
      this.tabPageTotalGas.Controls.Add((Control) this.bTotalGas1);
      this.tabPageTotalGas.Controls.Add((Control) this.TotalGas4);
      this.tabPageTotalGas.Controls.Add((Control) this.TotalGas3);
      this.tabPageTotalGas.Controls.Add((Control) this.TotalGas2);
      this.tabPageTotalGas.Controls.Add((Control) this.TotalGas1);
      ((Control) this.tabPageTotalGas).Location = new Point(4, 22);
      this.tabPageTotalGas.Name = "tabPageTotalGas";
      this.tabPageTotalGas.Size = new Size(344, 158);
      this.tabPageTotalGas.TabIndex = 6;
      this.tabPageTotalGas.Text = "Сумматоры газа";
      this.TotalGas1.Location = new Point(64, 24);
      this.TotalGas1.Name = "TotalGas1";
      this.TotalGas1.Size = new Size(88, 20);
      this.TotalGas1.TabIndex = 0;
      this.TotalGas1.Text = "";
      this.TotalGas2.Location = new Point(64, 56);
      this.TotalGas2.Name = "TotalGas2";
      this.TotalGas2.Size = new Size(88, 20);
      this.TotalGas2.TabIndex = 1;
      this.TotalGas2.Text = "";
      this.TotalGas3.Location = new Point(64, 88);
      this.TotalGas3.Name = "TotalGas3";
      this.TotalGas3.Size = new Size(88, 20);
      this.TotalGas3.TabIndex = 2;
      this.TotalGas3.Text = "";
      this.TotalGas4.Location = new Point(64, 120);
      this.TotalGas4.Name = "TotalGas4";
      this.TotalGas4.Size = new Size(88, 20);
      this.TotalGas4.TabIndex = 3;
      this.TotalGas4.Text = "";
      this.bTotalGas1.Location = new Point(168, 24);
      this.bTotalGas1.Name = "bTotalGas1";
      this.bTotalGas1.TabIndex = 4;
      this.bTotalGas1.Text = "Записать";
      this.bTotalGas1.Click += new EventHandler(this.bTotalGas1_Click);
      this.label24.Location = new Point(8, 24);
      this.label24.Name = "label24";
      this.label24.Size = new Size(56, 24);
      this.label24.TabIndex = 5;
      this.label24.Text = "Пост №1";
      this.label24.TextAlign = ContentAlignment.MiddleLeft;
      this.label25.Location = new Point(8, 56);
      this.label25.Name = "label25";
      this.label25.Size = new Size(56, 24);
      this.label25.TabIndex = 6;
      this.label25.Text = "Пост №2";
      this.label25.TextAlign = ContentAlignment.MiddleLeft;
      this.label26.Location = new Point(8, 88);
      this.label26.Name = "label26";
      this.label26.Size = new Size(56, 24);
      this.label26.TabIndex = 7;
      this.label26.Text = "Пост №3";
      this.label26.TextAlign = ContentAlignment.MiddleLeft;
      this.label27.Location = new Point(8, 120);
      this.label27.Name = "label27";
      this.label27.Size = new Size(56, 24);
      this.label27.TabIndex = 8;
      this.label27.Text = "Пост №4";
      this.label27.TextAlign = ContentAlignment.MiddleLeft;
      this.bTotalGas2.Location = new Point(168, 56);
      this.bTotalGas2.Name = "bTotalGas2";
      this.bTotalGas2.TabIndex = 9;
      this.bTotalGas2.Text = "Записать";
      this.bTotalGas2.Click += new EventHandler(this.bTotalGas2_Click);
      this.bTotalGas3.Location = new Point(168, 88);
      this.bTotalGas3.Name = "bTotalGas3";
      this.bTotalGas3.TabIndex = 10;
      this.bTotalGas3.Text = "Записать";
      this.bTotalGas3.Click += new EventHandler(this.bTotalGas3_Click);
      this.bTotalGas4.Location = new Point(168, 120);
      this.bTotalGas4.Name = "bTotalGas4";
      this.bTotalGas4.TabIndex = 11;
      this.bTotalGas4.Text = "Записать";
      this.bTotalGas4.Click += new EventHandler(this.bTotalGas4_Click);
      this.AcceptButton = (IButtonControl) this.ExitFromForm;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(440, 213);
      this.Controls.Add((Control) this.ExitFromForm);
      this.Controls.Add((Control) this.tabControl1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ChangeParamPosts);
      this.Text = "Настройка постов";
      this.Closing += new CancelEventHandler(this.ChangeParamPosts_Closing);
      this.VisibleChanged += new EventHandler(this.ChangeParamPosts_VisibleChanged);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.tabPageGas.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPageKor.ResumeLayout(false);
      this.tabPagePover.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.tabPageLight.ResumeLayout(false);
      this.BeginNightLight.EndInit();
      this.BeginDayLight.EndInit();
      this.tabPageRulePosts.ResumeLayout(false);
      this.groupBox6.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.tabPageAlarms.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.tabPageTotalGas.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void PriceBox_TextChanged(object sender, EventArgs e)
    {
      figures.TestingFigures((TextBox) sender);
    }

    private void WriteParam_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv1 = new int[3];
      int[] _handlesSrv2 = new int[3];
      int[] _handlesSrv3 = new int[3];
      int[] _handlesSrv4 = new int[3];
      object[] itemValues = new object[3];
      _handlesSrv1[0] = this.m_OPCAdapter.m_Data1.handlesdensity;
      _handlesSrv1[1] = this.m_OPCAdapter.m_Data1.handlesAmount;
      _handlesSrv1[2] = this.m_OPCAdapter.m_Data1.handlesVo;
      _handlesSrv2[0] = this.m_OPCAdapter2.m_Data1.handlesdensity;
      _handlesSrv2[1] = this.m_OPCAdapter2.m_Data1.handlesAmount;
      _handlesSrv2[2] = this.m_OPCAdapter2.m_Data1.handlesVo;
      _handlesSrv3[0] = this.m_OPCAdapter3.m_Data1.handlesdensity;
      _handlesSrv3[1] = this.m_OPCAdapter3.m_Data1.handlesAmount;
      _handlesSrv3[2] = this.m_OPCAdapter3.m_Data1.handlesVo;
      _handlesSrv4[0] = this.m_OPCAdapter4.m_Data1.handlesdensity;
      _handlesSrv4[1] = this.m_OPCAdapter4.m_Data1.handlesAmount;
      _handlesSrv4[2] = this.m_OPCAdapter4.m_Data1.handlesVo;
      if (this.DensityBox.Text != "" && this.MoBox.Text != "" && this.VoBox.Text != "")
      {
        itemValues[0] = (object) (int) (double.Parse(this.DensityBox.Text) * 100.0);
        itemValues[1] = (object) float.Parse(this.MoBox.Text);
        itemValues[2] = (object) float.Parse(this.VoBox.Text);
        this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
        this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
        this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
        this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
      }
      else
      {
        int num = (int) MessageBox.Show("Ввдены не все параметры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void ExitFromForm_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void PostZero1_Click(object sender, EventArgs e)
    {
      object[] itemValues = new object[1];
      int[] _handlesSrv = new int[1];
      itemValues[0] = (object) true;
      switch (((Control) sender).Text)
      {
        case "Пост1":
          _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesControl;
          this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
          this.timer1.Start();
          break;
        case "Пост2":
          _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesControl;
          this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
          this.timer2.Start();
          break;
        case "Пост3":
          _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesControl;
          this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
          this.timer3.Start();
          break;
        case "Пост4":
          _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesControl;
          this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv);
          this.timer4.Start();
          break;
      }
    }

    private void TestPost1_CheckedChanged(object sender, EventArgs e)
    {
      object[] itemValues = new object[1];
      int[] _handlesSrv = new int[1];
      CheckBox checkBox = (CheckBox) sender;
      switch (checkBox.Text)
      {
        case " Пост1":
          _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesTest;
          itemValues[0] = (object) checkBox.Checked;
          this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
          break;
        case " Пост2":
          _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesTest;
          itemValues[0] = (object) checkBox.Checked;
          this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
          break;
        case " Пост3":
          _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesTest;
          itemValues[0] = (object) checkBox.Checked;
          this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
          break;
        case " Пост4":
          _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesTest;
          itemValues[0] = (object) checkBox.Checked;
          this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv);
          break;
      }
    }

    public void MayChangeParamPost1()
    {
      Button writeLight = this.WriteLight;
      RadioButton onlyPost = this.OnlyPost;
      RadioButton onlyPc = this.OnlyPC;
      RadioButton pcAndPost = this.PcAndPost;
      Button resetAlarmsAllPosts = this.ResetAlarmsAllPosts;
      Button writeAlarm = this.WriteAlarm;
      TextBox maxFlowBox = this.MaxFlowBox;
      TextBox minFlowBox = this.MinFlowBox;
      TextBox densityBox = this.DensityBox;
      TextBox moBox = this.MoBox;
      TextBox voBox = this.VoBox;
      bool flag1;
      this.WriteAllPosts.Enabled = flag1 = !this.m_OPCAdapter.m_Data1.klapan && !this.m_OPCAdapter2.m_Data1.klapan && !this.m_OPCAdapter3.m_Data1.klapan && !this.m_OPCAdapter4.m_Data1.klapan;
      int num1;
      bool flag2 = (num1 = flag1 ? 1 : 0) != 0;
      voBox.Enabled = num1 != 0;
      int num2;
      bool flag3 = (num2 = flag2 ? 1 : 0) != 0;
      moBox.Enabled = num2 != 0;
      int num3;
      bool flag4 = (num3 = flag3 ? 1 : 0) != 0;
      densityBox.Enabled = num3 != 0;
      int num4;
      bool flag5 = (num4 = flag4 ? 1 : 0) != 0;
      minFlowBox.Enabled = num4 != 0;
      int num5;
      bool flag6 = (num5 = flag5 ? 1 : 0) != 0;
      maxFlowBox.Enabled = num5 != 0;
      int num6;
      bool flag7 = (num6 = flag6 ? 1 : 0) != 0;
      writeAlarm.Enabled = num6 != 0;
      int num7;
      bool flag8 = (num7 = flag7 ? 1 : 0) != 0;
      resetAlarmsAllPosts.Enabled = num7 != 0;
      int num8;
      bool flag9 = (num8 = flag8 ? 1 : 0) != 0;
      pcAndPost.Enabled = num8 != 0;
      int num9;
      bool flag10 = (num9 = flag9 ? 1 : 0) != 0;
      onlyPc.Enabled = num9 != 0;
      int num10;
      bool flag11 = (num10 = flag10 ? 1 : 0) != 0;
      onlyPost.Enabled = num10 != 0;
      int num11 = flag11 ? 1 : 0;
      writeLight.Enabled = num11 != 0;
    }

    private void ParamPost1()
    {
      this.MaxFlowBox.Text = this.m_OPCAdapter.m_Data1.LimitFlowMax.ToString();
      this.MinFlowBox.Text = this.m_OPCAdapter.m_Data1.LimitFlowMin.ToString();
      this.DensityBox.Text = "" + (object) (float) ((double) this.m_OPCAdapter.m_Data1.density / 100.0);
      this.MoBox.Text = this.m_OPCAdapter.m_Data1.amount.ToString();
      this.VoBox.Text = this.m_OPCAdapter.m_Data1.Vo.ToString();
      if (this.m_OPCAdapter.m_Data1.sleep != 0)
        this.FBoxLine.Text = "" + (object) (100 / this.m_OPCAdapter.m_Data1.sleep);
      else
        this.FBoxLine.Text = "100";
      if (this.m_OPCAdapter.m_Data1.TESTFRQ != 0)
        this.FBoxWordPover.Text = "" + (object) (100 / this.m_OPCAdapter.m_Data1.TESTFRQ);
      else
        this.FBoxWordPover.Text = "100";
      this.FlowOnEKM.Text = this.m_OPCAdapter.m_Data1.FlowOnEKM.ToString();
      this.LightCheck.Checked = this.m_OPCAdapter.m_Data1.ONOFFINDICAT;
      this.TestPost1.Checked = this.m_OPCAdapter.m_Data1.Test;
      this.TestPost2.Checked = this.m_OPCAdapter2.m_Data1.Test;
      this.TestPost3.Checked = this.m_OPCAdapter3.m_Data1.Test;
      this.TestPost4.Checked = this.m_OPCAdapter4.m_Data1.Test;
      this.EKKAPost1.Checked = this.m_OPCAdapter.m_Data1.ComAsEkka;
      this.EKKAPost2.Checked = this.m_OPCAdapter2.m_Data1.ComAsEkka;
      this.EKKAPost3.Checked = this.m_OPCAdapter3.m_Data1.ComAsEkka;
      this.EKKAPost4.Checked = this.m_OPCAdapter4.m_Data1.ComAsEkka;
      if (!this.OnlyPost.Checked)
      {
        this.PcAndPost.Checked = this.m_OPCAdapter.m_Data1.DoubleRule;
        this.OnlyPC.Checked = !this.m_OPCAdapter.m_Data1.DoubleRule;
      }
      this.ShowOver1.Checked = this.m_OPCAdapter.m_Data1.ShowOver;
      this.ShowOver2.Checked = this.m_OPCAdapter2.m_Data1.ShowOver;
      this.ShowOver3.Checked = this.m_OPCAdapter3.m_Data1.ShowOver;
      this.ShowOver4.Checked = this.m_OPCAdapter4.m_Data1.ShowOver;
      this.tOutstrip1.Text = this.m_OPCAdapter.m_Data1.K_FLOW.ToString();
      this.tOutstrip2.Text = this.m_OPCAdapter2.m_Data1.K_FLOW.ToString();
      this.tOutstrip3.Text = this.m_OPCAdapter3.m_Data1.K_FLOW.ToString();
      this.tOutstrip4.Text = this.m_OPCAdapter4.m_Data1.K_FLOW.ToString();
      this.tMassKor1.Text = this.m_OPCAdapter.m_Data1.AddMass.ToString();
      this.tMassKor2.Text = this.m_OPCAdapter2.m_Data1.AddMass.ToString();
      this.tMassKor3.Text = this.m_OPCAdapter3.m_Data1.AddMass.ToString();
      this.tMassKor4.Text = this.m_OPCAdapter4.m_Data1.AddMass.ToString();
      this.TotalGas1.Text = Math.Round((double) this.m_OPCAdapter.m_Data1.gTG1 * 0.01 + (double) this.m_OPCAdapter.m_Data1.gTG2 * 0.1 + (double) this.m_OPCAdapter.m_Data1.gTG3 + (double) (this.m_OPCAdapter.m_Data1.gTG4 * 10) + (double) (this.m_OPCAdapter.m_Data1.gTG5 * 100) + (double) (this.m_OPCAdapter.m_Data1.gTG6 * 1000) + (double) (this.m_OPCAdapter.m_Data1.gTG7 * 10000) + (double) (this.m_OPCAdapter.m_Data1.gTG8 * 100000) + (double) (this.m_OPCAdapter.m_Data1.gTG9 * 1000000) + (double) (this.m_OPCAdapter.m_Data1.gTG10 * 10000000) + (double) (this.m_OPCAdapter.m_Data1.gTG11 * 100000000) + (double) (this.m_OPCAdapter.m_Data1.gTG12 * 1000000000), 2).ToString();
      this.TotalGas2.Text = Math.Round((double) this.m_OPCAdapter2.m_Data1.gTG1 * 0.01 + (double) this.m_OPCAdapter2.m_Data1.gTG2 * 0.1 + (double) this.m_OPCAdapter2.m_Data1.gTG3 + (double) (this.m_OPCAdapter2.m_Data1.gTG4 * 10) + (double) (this.m_OPCAdapter2.m_Data1.gTG5 * 100) + (double) (this.m_OPCAdapter2.m_Data1.gTG6 * 1000) + (double) (this.m_OPCAdapter2.m_Data1.gTG7 * 10000) + (double) (this.m_OPCAdapter2.m_Data1.gTG8 * 100000) + (double) (this.m_OPCAdapter2.m_Data1.gTG9 * 1000000) + (double) (this.m_OPCAdapter2.m_Data1.gTG10 * 10000000) + (double) (this.m_OPCAdapter2.m_Data1.gTG11 * 100000000) + (double) (this.m_OPCAdapter2.m_Data1.gTG12 * 1000000000), 2).ToString();
      this.TotalGas3.Text = Math.Round((double) this.m_OPCAdapter3.m_Data1.gTG1 * 0.01 + (double) this.m_OPCAdapter3.m_Data1.gTG2 * 0.1 + (double) this.m_OPCAdapter3.m_Data1.gTG3 + (double) (this.m_OPCAdapter3.m_Data1.gTG4 * 10) + (double) (this.m_OPCAdapter3.m_Data1.gTG5 * 100) + (double) (this.m_OPCAdapter3.m_Data1.gTG6 * 1000) + (double) (this.m_OPCAdapter3.m_Data1.gTG7 * 10000) + (double) (this.m_OPCAdapter3.m_Data1.gTG8 * 100000) + (double) (this.m_OPCAdapter3.m_Data1.gTG9 * 1000000) + (double) (this.m_OPCAdapter3.m_Data1.gTG10 * 10000000) + (double) (this.m_OPCAdapter3.m_Data1.gTG11 * 100000000) + (double) (this.m_OPCAdapter3.m_Data1.gTG12 * 1000000000), 2).ToString();
      this.TotalGas4.Text = Math.Round((double) this.m_OPCAdapter4.m_Data1.gTG1 * 0.01 + (double) this.m_OPCAdapter4.m_Data1.gTG2 * 0.1 + (double) this.m_OPCAdapter4.m_Data1.gTG3 + (double) (this.m_OPCAdapter4.m_Data1.gTG4 * 10) + (double) (this.m_OPCAdapter4.m_Data1.gTG5 * 100) + (double) (this.m_OPCAdapter4.m_Data1.gTG6 * 1000) + (double) (this.m_OPCAdapter4.m_Data1.gTG7 * 10000) + (double) (this.m_OPCAdapter4.m_Data1.gTG8 * 100000) + (double) (this.m_OPCAdapter4.m_Data1.gTG9 * 1000000) + (double) (this.m_OPCAdapter4.m_Data1.gTG10 * 10000000) + (double) (this.m_OPCAdapter4.m_Data1.gTG11 * 100000000) + (double) (this.m_OPCAdapter4.m_Data1.gTG12 * 1000000000), 2).ToString();
    }

    private void ChangeParamPosts_Closing(object sender, CancelEventArgs e)
    {
      this.Hide();
    }

    private void ChangeParamPosts_VisibleChanged(object sender, EventArgs e)
    {
      this.ParamPost1();
    }

    private void InputCarNumber_CheckedChanged(object sender, EventArgs e)
    {
      this.OnChangeParamPost1(sender, new EventParam(this.OnlyPost.Checked, this.EKKAPost1.Checked));
      this.OnChangeParamPost1(sender, new EventParam(this.OnlyPost.Checked, this.EKKAPost2.Checked));
      this.OnChangeParamPost1(sender, new EventParam(this.OnlyPost.Checked, this.EKKAPost3.Checked));
      this.OnChangeParamPost1(sender, new EventParam(this.OnlyPost.Checked, this.EKKAPost4.Checked));
    }

    private void WriteAlarm_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv1 = new int[3];
      int[] _handlesSrv2 = new int[3];
      int[] _handlesSrv3 = new int[3];
      int[] _handlesSrv4 = new int[3];
      object[] itemValues = new object[3];
      _handlesSrv1[0] = this.m_OPCAdapter.m_Data1.handlesLimitFlowMax;
      _handlesSrv1[1] = this.m_OPCAdapter.m_Data1.handlesLimitFlowMin;
      _handlesSrv1[2] = this.m_OPCAdapter.m_Data1.handlesFlowOnEKM;
      _handlesSrv2[0] = this.m_OPCAdapter2.m_Data1.handlesLimitFlowMax;
      _handlesSrv2[1] = this.m_OPCAdapter2.m_Data1.handlesLimitFlowMin;
      _handlesSrv2[2] = this.m_OPCAdapter2.m_Data1.handlesFlowOnEKM;
      _handlesSrv3[0] = this.m_OPCAdapter3.m_Data1.handlesLimitFlowMax;
      _handlesSrv3[1] = this.m_OPCAdapter3.m_Data1.handlesLimitFlowMin;
      _handlesSrv3[2] = this.m_OPCAdapter3.m_Data1.handlesFlowOnEKM;
      _handlesSrv4[0] = this.m_OPCAdapter4.m_Data1.handlesLimitFlowMax;
      _handlesSrv4[1] = this.m_OPCAdapter4.m_Data1.handlesLimitFlowMin;
      _handlesSrv4[2] = this.m_OPCAdapter4.m_Data1.handlesFlowOnEKM;
      if (this.MaxFlowBox.Text != "" && this.MinFlowBox.Text != "" && this.FlowOnEKM.Text != "")
      {
        itemValues[0] = (object) float.Parse(this.MaxFlowBox.Text);
        itemValues[1] = (object) float.Parse(this.MinFlowBox.Text);
        itemValues[2] = (object) float.Parse(this.FlowOnEKM.Text);
        this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
        this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
        this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
        this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
      }
      else
      {
        int num = (int) MessageBox.Show("Ввдены не все параметры", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void ResetAlarmsAllPosts_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1]{ (object) true };
      _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesResetAlarms;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
      _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesResetAlarms;
      this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
      _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesResetAlarms;
      this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
      _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesResetAlarms;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
    }

    private void WriteLight_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv1 = new int[2];
      int[] _handlesSrv2 = new int[2];
      int[] _handlesSrv3 = new int[2];
      int[] _handlesSrv4 = new int[2];
      object[] itemValues = new object[2];
      _handlesSrv1[0] = this.m_OPCAdapter.m_Data1.handlesSleep;
      _handlesSrv1[1] = this.m_OPCAdapter.m_Data1.handlesTESTFRQ;
      _handlesSrv2[0] = this.m_OPCAdapter2.m_Data1.handlesSleep;
      _handlesSrv2[1] = this.m_OPCAdapter2.m_Data1.handlesTESTFRQ;
      _handlesSrv3[0] = this.m_OPCAdapter3.m_Data1.handlesSleep;
      _handlesSrv3[1] = this.m_OPCAdapter3.m_Data1.handlesTESTFRQ;
      _handlesSrv4[0] = this.m_OPCAdapter4.m_Data1.handlesSleep;
      _handlesSrv4[1] = this.m_OPCAdapter4.m_Data1.handlesTESTFRQ;
      float num1 = float.Parse(this.FBoxLine.Text);
      float num2 = float.Parse(this.FBoxWordPover.Text);
      if ((double) num1 > 100.0 || (double) num2 > 100.0 || ((double) num1 == 0.0 || (double) num2 == 0.0))
      {
        int num3 = (int) MessageBox.Show("частота от 0(не включая) до 100Гц!!!");
      }
      else
      {
        itemValues[0] = (object) (int) (100.0 / (double) num1);
        itemValues[1] = (object) (int) (100.0 / (double) num2);
        this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
        this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
        this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
        this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
      }
    }

    private void ResetAlarm(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1]{ (object) true };
      switch (((Control) sender).Text)
      {
        case "Пост1":
          _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesResetAlarms;
          this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост2":
          _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesResetAlarms;
          this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост3":
          _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesResetAlarms;
          this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост4":
          _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesResetAlarms;
          this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
          break;
      }
    }

    private void LightCheck_CheckedChanged(object sender, EventArgs e)
    {
      int[] _handlesSrv1 = new int[1];
      int[] _handlesSrv2 = new int[1];
      int[] _handlesSrv3 = new int[1];
      int[] _handlesSrv4 = new int[1];
      object[] itemValues = new object[1]
      {
        (object) this.LightCheck.Checked
      };
      _handlesSrv1[0] = this.m_OPCAdapter.m_Data1.handlesONOFFINDICAT;
      _handlesSrv2[0] = this.m_OPCAdapter2.m_Data1.handlesONOFFINDICAT;
      _handlesSrv3[0] = this.m_OPCAdapter3.m_Data1.handlesONOFFINDICAT;
      _handlesSrv4[0] = this.m_OPCAdapter4.m_Data1.handlesONOFFINDICAT;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
      this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
      this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
      this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
    }

    private void PostRuleChange(object sender, EventArgs e)
    {
      int[] _handlesSrv1 = new int[1];
      int[] _handlesSrv2 = new int[1];
      int[] _handlesSrv3 = new int[1];
      int[] _handlesSrv4 = new int[1];
      _handlesSrv1[0] = this.m_OPCAdapter.m_Data1.handlesDoubleRule;
      _handlesSrv2[0] = this.m_OPCAdapter2.m_Data1.handlesDoubleRule;
      _handlesSrv3[0] = this.m_OPCAdapter3.m_Data1.handlesDoubleRule;
      _handlesSrv4[0] = this.m_OPCAdapter4.m_Data1.handlesDoubleRule;
      object[] itemValues = new object[1];
      RadioButton radioButton = (RadioButton) sender;
      if (radioButton.Text == "С компьютера и поста")
      {
        itemValues[0] = (object) true;
        this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
        this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
        this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
        this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
        this.OnChangeParamPost1(sender, new EventParam(false, this.EKKAPost1.Checked));
        this.OnChangeParamPost2(sender, new EventParam(false, this.EKKAPost2.Checked));
        this.OnChangeParamPost3(sender, new EventParam(false, this.EKKAPost3.Checked));
        this.OnChangeParamPost4(sender, new EventParam(false, this.EKKAPost4.Checked));
      }
      else if (radioButton.Text == "Только с компьютера ")
      {
        itemValues[0] = (object) false;
        this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
        this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
        this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
        this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
        this.OnChangeParamPost1(sender, new EventParam(false, this.EKKAPost1.Checked));
        this.OnChangeParamPost2(sender, new EventParam(false, this.EKKAPost2.Checked));
        this.OnChangeParamPost3(sender, new EventParam(false, this.EKKAPost3.Checked));
        this.OnChangeParamPost4(sender, new EventParam(false, this.EKKAPost4.Checked));
      }
      else
      {
        if (!(radioButton.Text == "Только с поста"))
          return;
        itemValues[0] = (object) true;
        this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
        this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
        this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
        this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
        this.OnChangeParamPost1(sender, new EventParam(true, this.EKKAPost1.Checked));
        this.OnChangeParamPost2(sender, new EventParam(true, this.EKKAPost2.Checked));
        this.OnChangeParamPost3(sender, new EventParam(true, this.EKKAPost3.Checked));
        this.OnChangeParamPost4(sender, new EventParam(true, this.EKKAPost4.Checked));
      }
    }

    private void EKKA_CheckedChanged(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1]
      {
        (object) ((CheckBox) sender).Checked
      };
      switch (((Control) sender).Text)
      {
        case "Пост1":
          _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesComAsEkka;
          this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост2":
          _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesComAsEkka;
          this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост3":
          _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesComAsEkka;
          this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост4":
          _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesComAsEkka;
          this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv);
          break;
      }
    }

    private void tOutstrip1_TextChanged(object sender, EventArgs e)
    {
      figures.TestingFigures((TextBox) sender);
    }

    private void tOutstrip2_TextChanged(object sender, EventArgs e)
    {
      figures.TestingFigures((TextBox) sender);
    }

    private void tOutstrip3_TextChanged(object sender, EventArgs e)
    {
      figures.TestingFigures((TextBox) sender);
    }

    private void tOutstrip4_TextChanged(object sender, EventArgs e)
    {
      figures.TestingFigures((TextBox) sender);
    }

    private void ShowOver1_CheckedChanged(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1];
      _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesShowOver;
      itemValues[0] = (object) this.ShowOver1.Checked;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
    }

    private void ShowOver2_CheckedChanged(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1];
      _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesShowOver;
      itemValues[0] = (object) this.ShowOver2.Checked;
      this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
    }

    private void ShowOver3_CheckedChanged(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1];
      _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesShowOver;
      itemValues[0] = (object) this.ShowOver3.Checked;
      this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
    }

    private void ShowOver4_CheckedChanged(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1];
      _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesShowOver;
      itemValues[0] = (object) this.ShowOver4.Checked;
      this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      object[] itemValues = new object[1];
      int[] _handlesSrv = new int[1];
      itemValues[0] = (object) false;
      _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesControl;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
      this.timer1.Stop();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      object[] itemValues = new object[1];
      int[] _handlesSrv = new int[1];
      itemValues[0] = (object) false;
      _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesControl;
      this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
      this.timer2.Stop();
    }

    private void timer3_Tick(object sender, EventArgs e)
    {
      object[] itemValues = new object[1];
      int[] _handlesSrv = new int[1];
      itemValues[0] = (object) false;
      _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesControl;
      this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
      this.timer3.Stop();
    }

    private void timer4_Tick(object sender, EventArgs e)
    {
      object[] itemValues = new object[1];
      int[] _handlesSrv = new int[1];
      itemValues[0] = (object) false;
      _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesControl;
      this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv);
      this.timer4.Stop();
    }

    private void WriteK_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv1 = new int[1];
      int[] _handlesSrv2 = new int[1];
      int[] _handlesSrv3 = new int[1];
      int[] _handlesSrv4 = new int[1];
      object[] itemValues1 = new object[1];
      object[] itemValues2 = new object[1];
      object[] itemValues3 = new object[1];
      object[] itemValues4 = new object[1];
      _handlesSrv1[0] = this.m_OPCAdapter.m_Data1.handlesK_FLOW;
      _handlesSrv2[0] = this.m_OPCAdapter2.m_Data1.handlesK_FLOW;
      _handlesSrv3[0] = this.m_OPCAdapter3.m_Data1.handlesK_FLOW;
      _handlesSrv4[0] = this.m_OPCAdapter4.m_Data1.handlesK_FLOW;
      itemValues1[0] = (object) float.Parse(this.tOutstrip1.Text);
      itemValues2[0] = (object) float.Parse(this.tOutstrip2.Text);
      itemValues3[0] = (object) float.Parse(this.tOutstrip3.Text);
      itemValues4[0] = (object) float.Parse(this.tOutstrip4.Text);
      this.m_OPCAdapter.WriteTag(itemValues1, _handlesSrv1);
      this.m_OPCAdapter2.WriteTag(itemValues2, _handlesSrv2);
      this.m_OPCAdapter3.WriteTag(itemValues3, _handlesSrv3);
      this.m_OPCAdapter4.WriteTag(itemValues4, _handlesSrv4);
    }

    private void bMassKor_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[1];
      object[] itemValues = new object[1];
      switch (((Control) sender).Text)
      {
        case "Пост1":
          try
          {
            itemValues[0] = (object) float.Parse(this.tMassKor1.Text);
          }
          catch
          {
            this.tMassKor1.Text = "0";
          }
          _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesAddMass;
          this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост2":
          try
          {
            itemValues[0] = (object) float.Parse(this.tMassKor2.Text);
          }
          catch
          {
            this.tMassKor2.Text = "0";
          }
          _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesAddMass;
          this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост3":
          try
          {
            itemValues[0] = (object) float.Parse(this.tMassKor3.Text);
          }
          catch
          {
            this.tMassKor3.Text = "0";
          }
          _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesAddMass;
          this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
          break;
        case "Пост4":
          try
          {
            itemValues[0] = (object) float.Parse(this.tMassKor4.Text);
          }
          catch
          {
            this.tMassKor4.Text = "0";
          }
          _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesAddMass;
          this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv);
          break;
      }
    }

    private void bTotalGas1_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[12];
      object[] itemValues = new object[12];
      double num1;
      try
      {
        num1 = double.Parse(this.TotalGas1.Text);
      }
      catch
      {
        this.ParamPost1();
        num1 = double.Parse(this.TotalGas1.Text);
      }
      double num2 = num1 * 100.0;
      long num3 = 100000000000;
      for (int index = 0; index < 12; ++index)
      {
        long num4 = (long) num2 / num3;
        num2 -= (double) (num4 * num3);
        num3 /= 10L;
        itemValues[index] = (object) num4;
      }
      _handlesSrv[0] = this.m_OPCAdapter.m_Data1.handlesgTG12;
      _handlesSrv[1] = this.m_OPCAdapter.m_Data1.handlesgTG11;
      _handlesSrv[2] = this.m_OPCAdapter.m_Data1.handlesgTG10;
      _handlesSrv[3] = this.m_OPCAdapter.m_Data1.handlesgTG9;
      _handlesSrv[4] = this.m_OPCAdapter.m_Data1.handlesgTG8;
      _handlesSrv[5] = this.m_OPCAdapter.m_Data1.handlesgTG7;
      _handlesSrv[6] = this.m_OPCAdapter.m_Data1.handlesgTG6;
      _handlesSrv[7] = this.m_OPCAdapter.m_Data1.handlesgTG5;
      _handlesSrv[8] = this.m_OPCAdapter.m_Data1.handlesgTG4;
      _handlesSrv[9] = this.m_OPCAdapter.m_Data1.handlesgTG3;
      _handlesSrv[10] = this.m_OPCAdapter.m_Data1.handlesgTG2;
      _handlesSrv[11] = this.m_OPCAdapter.m_Data1.handlesgTG1;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
    }

    private void bTotalGas2_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[12];
      object[] itemValues = new object[12];
      double num1;
      try
      {
        num1 = double.Parse(this.TotalGas2.Text);
      }
      catch
      {
        this.ParamPost1();
        num1 = double.Parse(this.TotalGas2.Text);
      }
      double num2 = num1 * 100.0;
      long num3 = 100000000000;
      for (int index = 0; index < 12; ++index)
      {
        long num4 = (long) num2 / num3;
        num2 -= (double) (num4 * num3);
        num3 /= 10L;
        itemValues[index] = (object) num4;
      }
      _handlesSrv[0] = this.m_OPCAdapter2.m_Data1.handlesgTG12;
      _handlesSrv[1] = this.m_OPCAdapter2.m_Data1.handlesgTG11;
      _handlesSrv[2] = this.m_OPCAdapter2.m_Data1.handlesgTG10;
      _handlesSrv[3] = this.m_OPCAdapter2.m_Data1.handlesgTG9;
      _handlesSrv[4] = this.m_OPCAdapter2.m_Data1.handlesgTG8;
      _handlesSrv[5] = this.m_OPCAdapter2.m_Data1.handlesgTG7;
      _handlesSrv[6] = this.m_OPCAdapter2.m_Data1.handlesgTG6;
      _handlesSrv[7] = this.m_OPCAdapter2.m_Data1.handlesgTG5;
      _handlesSrv[8] = this.m_OPCAdapter2.m_Data1.handlesgTG4;
      _handlesSrv[9] = this.m_OPCAdapter2.m_Data1.handlesgTG3;
      _handlesSrv[10] = this.m_OPCAdapter2.m_Data1.handlesgTG2;
      _handlesSrv[11] = this.m_OPCAdapter2.m_Data1.handlesgTG1;
      this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv);
    }

    private void bTotalGas3_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[12];
      object[] itemValues = new object[12];
      double num1;
      try
      {
        num1 = double.Parse(this.TotalGas3.Text);
      }
      catch
      {
        this.ParamPost1();
        num1 = double.Parse(this.TotalGas3.Text);
      }
      double num2 = num1 * 100.0;
      long num3 = 100000000000;
      for (int index = 0; index < 12; ++index)
      {
        long num4 = (long) num2 / num3;
        num2 -= (double) (num4 * num3);
        num3 /= 10L;
        itemValues[index] = (object) num4;
      }
      _handlesSrv[0] = this.m_OPCAdapter3.m_Data1.handlesgTG12;
      _handlesSrv[1] = this.m_OPCAdapter3.m_Data1.handlesgTG11;
      _handlesSrv[2] = this.m_OPCAdapter3.m_Data1.handlesgTG10;
      _handlesSrv[3] = this.m_OPCAdapter3.m_Data1.handlesgTG9;
      _handlesSrv[4] = this.m_OPCAdapter3.m_Data1.handlesgTG8;
      _handlesSrv[5] = this.m_OPCAdapter3.m_Data1.handlesgTG7;
      _handlesSrv[6] = this.m_OPCAdapter3.m_Data1.handlesgTG6;
      _handlesSrv[7] = this.m_OPCAdapter3.m_Data1.handlesgTG5;
      _handlesSrv[8] = this.m_OPCAdapter3.m_Data1.handlesgTG4;
      _handlesSrv[9] = this.m_OPCAdapter3.m_Data1.handlesgTG3;
      _handlesSrv[10] = this.m_OPCAdapter3.m_Data1.handlesgTG2;
      _handlesSrv[11] = this.m_OPCAdapter3.m_Data1.handlesgTG1;
      this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv);
    }

    private void bTotalGas4_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[12];
      object[] itemValues = new object[12];
      double num1;
      try
      {
        num1 = double.Parse(this.TotalGas4.Text);
      }
      catch
      {
        this.ParamPost1();
        num1 = double.Parse(this.TotalGas4.Text);
      }
      double num2 = num1 * 100.0;
      long num3 = 100000000000;
      for (int index = 0; index < 12; ++index)
      {
        long num4 = (long) num2 / num3;
        num2 -= (double) (num4 * num3);
        num3 /= 10L;
        itemValues[index] = (object) num4;
      }
      _handlesSrv[0] = this.m_OPCAdapter4.m_Data1.handlesgTG12;
      _handlesSrv[1] = this.m_OPCAdapter4.m_Data1.handlesgTG11;
      _handlesSrv[2] = this.m_OPCAdapter4.m_Data1.handlesgTG10;
      _handlesSrv[3] = this.m_OPCAdapter4.m_Data1.handlesgTG9;
      _handlesSrv[4] = this.m_OPCAdapter4.m_Data1.handlesgTG8;
      _handlesSrv[5] = this.m_OPCAdapter4.m_Data1.handlesgTG7;
      _handlesSrv[6] = this.m_OPCAdapter4.m_Data1.handlesgTG6;
      _handlesSrv[7] = this.m_OPCAdapter4.m_Data1.handlesgTG5;
      _handlesSrv[8] = this.m_OPCAdapter4.m_Data1.handlesgTG4;
      _handlesSrv[9] = this.m_OPCAdapter4.m_Data1.handlesgTG3;
      _handlesSrv[10] = this.m_OPCAdapter4.m_Data1.handlesgTG2;
      _handlesSrv[11] = this.m_OPCAdapter4.m_Data1.handlesgTG1;
      this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv);
    }
  }
}
