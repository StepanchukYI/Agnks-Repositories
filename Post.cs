// Decompiled with JetBrains decompiler
// Type: agnks.Post
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace agnks
{
  public class Post : UserControl
  {
    private bool bStartSetPrice = true;
    public int nPost = 0;
    private bool EndCharge = false;
    private int NoConnect = 0;
    private bool flagNoConnect = true;
    private bool statePostButton = true;
    private bool OnlyPost = false;
    private string PriceCod = "";
    private DateTime dtStartRefuelling = DateTime.Now;
    private DateTime dtContinueRefuelling = DateTime.Now;
    public GroupBox PostBox;
    private TextBox State;
    private Label label8;
    private Label label2;
    private Label label5;
    public TextBox tem;
    private Label label1;
    public Button button;
    private Label label7;
    public TextBox Cost;
    private Label label6;
    private Label TextVolume;
    public TextBox Volume;
    private Label label4;
    private Label label3;
    private Label lGot;
    private Label lStop;
    private Label lPusk;
    public TextBox Flow;
    private DataOfCol m_Data;
    private ChangeParamPosts m_ChangeParamPosts;
    private Timer timeNoConnect;
    private IContainer components;
    public TextBox numCar;
    private ComboBox PriceCodBox;
    private TextBox PriceBox;
    private Label label9;
    private Label label10;
    private Label label11;
    private Button WritePrice;
    private Arhive arh;
    private Button AlarmReset;
    private Label label12;
    private TextBox Doz;
    private ComboBox selectDoz;
    public AlarmsArhive m_AlarmsArhive;
    private OPCAdapter m_OPCAdapter;
    private Label labTime;
    private Label labEKM;
    private Timer timRefuelling;
    private Post._dChangedTags dChangeTags;
    private ListView Pricelist;

    public OPCAdapter pOPCAdapter
    {
      set
      {
        this.m_OPCAdapter = value;
      }
    }

    public Arhive pArh
    {
      set
      {
        this.arh = value;
      }
    }

    public DataOfCol data
    {
      set
      {
        this.m_Data = value;
        this.m_Data.OnChangeValue += new ChangeValue(this.PostChangedTags);
      }
    }

    public ChangeParamPosts ParamPosts
    {
      set
      {
        this.m_ChangeParamPosts = value;
        switch (this.PostBox.Text)
        {
          case "Пост[1]":
            this.m_ChangeParamPosts.OnChangeParamPost1 += new ChangeParam(this.RulePost);
            break;
          case "Пост[2]":
            this.m_ChangeParamPosts.OnChangeParamPost2 += new ChangeParam(this.RulePost);
            break;
          case "Пост[3]":
            this.m_ChangeParamPosts.OnChangeParamPost3 += new ChangeParam(this.RulePost);
            break;
          case "Пост[4]":
            this.m_ChangeParamPosts.OnChangeParamPost4 += new ChangeParam(this.RulePost);
            break;
        }
      }
    }

    private void RulePost(object sender, EventParam e)
    {
      this.OnlyPost = e.Rule;
      if (this.OnlyPost)
        this.buttonShowAs("Стоп");
      else
        this.buttonShowAs("Пуск");
    }

    public Post()
    {
      this.InitializeComponent();
      this.timeNoConnect.Enabled = true;
      this.dChangeTags = new Post._dChangedTags(this.ChangedTags);
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
      ResourceManager resourceManager = new ResourceManager(typeof (Post));
      this.PostBox = new GroupBox();
      this.labTime = new Label();
      this.selectDoz = new ComboBox();
      this.label12 = new Label();
      this.Doz = new TextBox();
      this.AlarmReset = new Button();
      this.WritePrice = new Button();
      this.lStop = new Label();
      this.lPusk = new Label();
      this.lGot = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.PriceBox = new TextBox();
      this.PriceCodBox = new ComboBox();
      this.numCar = new TextBox();
      this.label5 = new Label();
      this.tem = new TextBox();
      this.label1 = new Label();
      this.button = new Button();
      this.label7 = new Label();
      this.Cost = new TextBox();
      this.label6 = new Label();
      this.TextVolume = new Label();
      this.Volume = new TextBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.Flow = new TextBox();
      this.label2 = new Label();
      this.label8 = new Label();
      this.State = new TextBox();
      this.labEKM = new Label();
      this.timeNoConnect = new Timer(this.components);
      this.timRefuelling = new Timer(this.components);
      this.PostBox.SuspendLayout();
      this.SuspendLayout();
      this.PostBox.Controls.AddRange(new Control[31]
      {
        (Control) this.labTime,
        (Control) this.selectDoz,
        (Control) this.label12,
        (Control) this.Doz,
        (Control) this.AlarmReset,
        (Control) this.WritePrice,
        (Control) this.lStop,
        (Control) this.lPusk,
        (Control) this.lGot,
        (Control) this.label11,
        (Control) this.label10,
        (Control) this.label9,
        (Control) this.PriceBox,
        (Control) this.PriceCodBox,
        (Control) this.numCar,
        (Control) this.label5,
        (Control) this.tem,
        (Control) this.label1,
        (Control) this.button,
        (Control) this.label7,
        (Control) this.Cost,
        (Control) this.label6,
        (Control) this.TextVolume,
        (Control) this.Volume,
        (Control) this.label4,
        (Control) this.label3,
        (Control) this.Flow,
        (Control) this.label2,
        (Control) this.label8,
        (Control) this.State,
        (Control) this.labEKM
      });
      this.PostBox.Font = new Font("Microsoft Sans Serif", 12.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.PostBox.Name = "PostBox";
      this.PostBox.Size = new Size(184, 472);
      this.PostBox.TabIndex = 0;
      this.PostBox.TabStop = false;
      this.PostBox.Text = "Пост[]";
      this.labTime.ForeColor = Color.Blue;
      this.labTime.Location = new Point((int) sbyte.MaxValue, 0);
      this.labTime.Name = "labTime";
      this.labTime.Size = new Size(50, 19);
      this.labTime.TabIndex = 45;
      this.labTime.Text = "00:00";
      this.selectDoz.Items.AddRange(new object[3]
      {
        (object) "полный",
        (object) "нм3",
        (object) "грн"
      });
      this.selectDoz.Location = new Point(96, 204);
      this.selectDoz.Name = "selectDoz";
      this.selectDoz.Size = new Size(84, 28);
      this.selectDoz.TabIndex = 44;
      this.selectDoz.Text = "полный";
      this.selectDoz.SelectedIndexChanged += new EventHandler(this.selectDoz_SelectedIndexChanged);
      this.label12.Font = new Font("Microsoft Sans Serif", 12.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label12.Location = new Point(9, 180);
      this.label12.Name = "label12";
      this.label12.Size = new Size(84, 23);
      this.label12.TabIndex = 43;
      this.label12.Text = "Доза";
      this.Doz.Location = new Point(9, 205);
      this.Doz.Name = "Doz";
      this.Doz.Size = new Size(85, 26);
      this.Doz.TabIndex = 42;
      this.Doz.Text = "";
      this.Doz.TextChanged += new EventHandler(this.Doz_TextChanged);
      this.AlarmReset.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.AlarmReset.Location = new Point(136, 22);
      this.AlarmReset.Name = "AlarmReset";
      this.AlarmReset.Size = new Size(43, 30);
      this.AlarmReset.TabIndex = 38;
      this.AlarmReset.Text = "Сброс";
      this.AlarmReset.TextAlign = ContentAlignment.MiddleLeft;
      this.AlarmReset.Click += new EventHandler(this.AlarmReset_Click);
      this.WritePrice.Image = (Image) resourceManager.GetObject("WritePrice.Image");
      this.WritePrice.Location = new Point(135, 94);
      this.WritePrice.Name = "WritePrice";
      this.WritePrice.Size = new Size(43, 28);
      this.WritePrice.TabIndex = 37;
      this.WritePrice.Click += new EventHandler(this.WritePrice_Click);
      this.lStop.Font = new Font("Microsoft Sans Serif", 22.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lStop.ForeColor = Color.DarkBlue;
      this.lStop.Location = new Point(152, 401);
      this.lStop.Name = "lStop";
      this.lStop.Size = new Size(24, 32);
      this.lStop.TabIndex = 6;
      this.lStop.Text = "C";
      this.lStop.TextAlign = ContentAlignment.MiddleCenter;
      this.lPusk.Font = new Font("Microsoft Sans Serif", 22.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lPusk.ForeColor = Color.SeaGreen;
      this.lPusk.Location = new Point(152, 364);
      this.lPusk.Name = "lPusk";
      this.lPusk.Size = new Size(24, 32);
      this.lPusk.TabIndex = 5;
      this.lPusk.Text = "П";
      this.lPusk.TextAlign = ContentAlignment.MiddleCenter;
      this.lGot.Font = new Font("Microsoft Sans Serif", 22.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.lGot.ForeColor = Color.DeepSkyBlue;
      this.lGot.Location = new Point(152, 326);
      this.lGot.Name = "lGot";
      this.lGot.Size = new Size(24, 32);
      this.lGot.TabIndex = 7;
      this.lGot.Text = "Г";
      this.lGot.TextAlign = ContentAlignment.MiddleCenter;
      this.label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label11.Location = new Point(8, 79);
      this.label11.Name = "label11";
      this.label11.Size = new Size(66, 12);
      this.label11.TabIndex = 36;
      this.label11.Text = "Код цены";
      this.label10.Location = new Point(96, 145);
      this.label10.Name = "label10";
      this.label10.Size = new Size(33, 23);
      this.label10.TabIndex = 35;
      this.label10.Text = "грн";
      this.label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label9.Location = new Point(8, 123);
      this.label9.Name = "label9";
      this.label9.Size = new Size(74, 14);
      this.label9.TabIndex = 34;
      this.label9.Text = "Цена газа";
      this.PriceBox.BackColor = SystemColors.Info;
      this.PriceBox.Font = new Font("Microsoft Sans Serif", 15.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.PriceBox.Location = new Point(8, 141);
      this.PriceBox.Name = "PriceBox";
      this.PriceBox.ReadOnly = true;
      this.PriceBox.Size = new Size(88, 31);
      this.PriceBox.TabIndex = 33;
      this.PriceBox.Text = "0";
      this.PriceCodBox.Location = new Point(8, 94);
      this.PriceCodBox.Name = "PriceCodBox";
      this.PriceCodBox.Size = new Size(122, 28);
      this.PriceCodBox.Sorted = true;
      this.PriceCodBox.TabIndex = 32;
      this.PriceCodBox.KeyPress += new KeyPressEventHandler(this.PriceCodBox_KeyPress);
      this.PriceCodBox.SelectedIndexChanged += new EventHandler(this.PriceCodBox_SelectedIndexChanged);
      this.numCar.Location = new Point(8, 53);
      this.numCar.Name = "numCar";
      this.numCar.Size = new Size(80, 26);
      this.numCar.TabIndex = 31;
      this.numCar.Text = "";
      this.numCar.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.label5.Location = new Point(103, 314);
      this.label5.Name = "label5";
      this.label5.Size = new Size(24, 23);
      this.label5.TabIndex = 30;
      this.label5.Text = "C";
      this.label5.TextAlign = ContentAlignment.MiddleLeft;
      this.tem.BackColor = SystemColors.Info;
      this.tem.Font = new Font("Microsoft Sans Serif", 15.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.tem.Location = new Point(8, 308);
      this.tem.Name = "tem";
      this.tem.ReadOnly = true;
      this.tem.Size = new Size(88, 31);
      this.tem.TabIndex = 29;
      this.tem.Text = "0";
      this.label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label1.Location = new Point(8, 292);
      this.label1.Name = "label1";
      this.label1.Size = new Size(110, 14);
      this.label1.TabIndex = 28;
      this.label1.Text = "Температура газа";
      this.button.BackColor = Color.Red;
      this.button.Font = new Font("Microsoft Sans Serif", 10.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.button.ForeColor = SystemColors.ControlText;
      this.button.Location = new Point(8, 440);
      this.button.Name = "button";
      this.button.Size = new Size(89, 23);
      this.button.TabIndex = 27;
      this.button.Text = "Стоп";
      this.button.Click += new EventHandler(this.button_Click);
      this.label7.Location = new Point(102, 407);
      this.label7.Name = "label7";
      this.label7.Size = new Size(40, 23);
      this.label7.TabIndex = 26;
      this.label7.Text = "грн";
      this.label7.TextAlign = ContentAlignment.MiddleLeft;
      this.Cost.BackColor = SystemColors.Info;
      this.Cost.Font = new Font("Microsoft Sans Serif", 15.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Cost.Location = new Point(8, 403);
      this.Cost.Name = "Cost";
      this.Cost.ReadOnly = true;
      this.Cost.Size = new Size(88, 31);
      this.Cost.TabIndex = 25;
      this.Cost.Text = "0";
      this.label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label6.Location = new Point(8, 388);
      this.label6.Name = "label6";
      this.label6.Size = new Size(80, 13);
      this.label6.TabIndex = 24;
      this.label6.Text = "К оплате";
      this.TextVolume.Location = new Point(101, 360);
      this.TextVolume.Name = "TextVolume";
      this.TextVolume.Size = new Size(40, 23);
      this.TextVolume.TabIndex = 23;
      this.TextVolume.Text = "нм3";
      this.TextVolume.TextAlign = ContentAlignment.MiddleLeft;
      this.Volume.BackColor = SystemColors.Info;
      this.Volume.Font = new Font("Microsoft Sans Serif", 15.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Volume.Location = new Point(8, 355);
      this.Volume.Name = "Volume";
      this.Volume.ReadOnly = true;
      this.Volume.Size = new Size(88, 31);
      this.Volume.TabIndex = 22;
      this.Volume.Text = "0";
      this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label4.Location = new Point(8, 340);
      this.label4.Name = "label4";
      this.label4.Size = new Size(104, 14);
      this.label4.TabIndex = 21;
      this.label4.Text = "Заправлено";
      this.label3.Location = new Point(103, 265);
      this.label3.Name = "label3";
      this.label3.Size = new Size(72, 24);
      this.label3.TabIndex = 20;
      this.label3.Text = "нм3/мин";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.Flow.BackColor = SystemColors.Info;
      this.Flow.Font = new Font("Microsoft Sans Serif", 15.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.Flow.Location = new Point(8, 259);
      this.Flow.Name = "Flow";
      this.Flow.ReadOnly = true;
      this.Flow.Size = new Size(88, 31);
      this.Flow.TabIndex = 19;
      this.Flow.Text = "0";
      this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.label2.Location = new Point(8, 244);
      this.label2.Name = "label2";
      this.label2.Size = new Size(78, 14);
      this.label2.TabIndex = 18;
      this.label2.Text = "Расход газа";
      this.label8.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.label8.Location = new Point(88, 54);
      this.label8.Name = "label8";
      this.label8.Size = new Size(88, 23);
      this.label8.TabIndex = 17;
      this.label8.Text = "№ машины";
      this.label8.TextAlign = ContentAlignment.MiddleLeft;
      this.State.BackColor = SystemColors.Info;
      this.State.Location = new Point(8, 24);
      this.State.Name = "State";
      this.State.ReadOnly = true;
      this.State.Size = new Size(122, 26);
      this.State.TabIndex = 0;
      this.State.Text = "";
      this.labEKM.Font = new Font("Microsoft Sans Serif", 12.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
      this.labEKM.ForeColor = Color.DeepSkyBlue;
      this.labEKM.Location = new Point(138, 443);
      this.labEKM.Name = "labEKM";
      this.labEKM.Size = new Size(44, 23);
      this.labEKM.TabIndex = 46;
      this.labEKM.Text = "ЭКМ";
      this.timeNoConnect.Interval = 1000;
      this.timeNoConnect.Tick += new EventHandler(this.timeNoConnect_Tick);
      this.timRefuelling.Interval = 1000;
      this.timRefuelling.Tick += new EventHandler(this.timRefuelling_Tick);
      this.Controls.AddRange(new Control[1]
      {
        (Control) this.PostBox
      });
      this.Name = nameof (Post);
      this.Size = new Size(184, 472);
      this.PostBox.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void button_Click(object sender, EventArgs e)
    {
      this.m_OPCAdapter.WriteTag(new object[1]
      {
        (object) true
      }, new int[1]
      {
        !(this.button.Text == "Стоп") ? this.m_Data.handlesPuskPC : this.m_Data.handlesStopPC
      });
    }

    public string PostName
    {
      get
      {
        return this.PostBox.Text;
      }
      set
      {
        this.PostBox.Text = value;
      }
    }

    private string RoundValue(float snum)
    {
      return (Math.Round((double) snum * 100.0) / 100.0).ToString("0.00");
    }

    private string RoundValue(float snum, int z)
    {
      return (Math.Round((double) snum * (double) z) / (double) z).ToString("0.0");
    }

    private void PostChangedTags(object sender, EventInfo ei)
    {
      this.Invoke((Delegate) this.dChangeTags, sender, (object) ei);
    }

    public void ChangedTags(object sender, EventInfo ei)
    {
      this.NoConnect = 0;
      this.flagNoConnect = true;
      if (ei.msg == "Volume")
        this.Volume.Text = this.RoundValue(this.m_Data.Volume);
      if (ei.msg == "Cost")
        this.Cost.Text = this.RoundValue(this.m_Data.Cost);
      if (ei.msg == "Flow")
        this.Flow.Text = this.RoundValue(this.m_Data.Flow);
      if (ei.msg == "Temperature")
        this.tem.Text = this.RoundValue(this.m_Data.Temperature, 10);
      if (ei.msg == "Startklapan")
        this.OnKlapanStart();
      if (ei.msg == "Pusk")
        this.OnPusk();
      if (ei.msg == "Stop")
        this.OnStop();
      if (ei.msg == "AlarmFlow")
        this.OnAlarmFlow();
      if (ei.msg == "NoGasAlarm")
        this.OnNoGasAlarm();
      if (ei.msg == "AlarmLeakage")
        this.OnAlarmLeakage();
      if (ei.msg == "CountAlarm")
        this.OnCountAlarm();
      if (ei.msg == "ConnectOut")
        this.OnConnectOut();
      if (ei.msg == "Price")
      {
        this.PriceBox.Text = ((float) this.m_Data.Price / 100f).ToString();
        if (this.bStartSetPrice)
        {
          this.bStartSetPrice = false;
          this.SetPrice();
        }
      }
      if (!(ei.msg == "EKM"))
        return;
      this.OnEKM();
    }

    private void OnKlapanStart()
    {
      this.m_ChangeParamPosts.MayChangeParamPost1();
      this.WritePrice.Enabled = true;
      this.m_Data.NoConnect = false;
      if (this.m_Data.klapan && !this.m_Data.AlarmFlow && (!this.m_Data.NoGasAlarm && !this.m_Data.AlarmLeakage))
      {
        this.State.Text = "Идёт заправка";
        this.PostBox.BackColor = Color.LightGreen;
        this.EndCharge = true;
        this.buttonShowAs("Стоп");
        this.WritePrice.Enabled = false;
        this.WriteDoz();
        this.dtStartRefuelling = DateTime.Now;
        this.timRefuelling.Start();
        this.labTime.Text = "00:00";
      }
      if (this.m_Data.Start && !this.m_Data.klapan)
      {
        this.State.Text = "Готовность";
        this.PostBox.BackColor = SystemColors.Control;
        this.lGot.Text = "Г";
        this.buttonShowAs("Пуск");
        this.timRefuelling.Stop();
      }
      else
      {
        this.lGot.Text = "";
        this.buttonShowAs("Стоп");
      }
      if (this.m_Data.Start)
        return;
      this.timRefuelling.Stop();
      this.buttonShowAs("Стоп");
      this.lGot.Text = "";
      this.State.Text = "";
      this.PostBox.BackColor = SystemColors.Control;
      if (!this.EndCharge)
        return;
      this.EndCharge = false;
      this.arh.m_OPCAdapter = this.m_OPCAdapter;
      if (this.PriceCodBox.Text != "")
        this.arh.InsertBase(this.nPost, this.PriceCod);
      else
        this.arh.InsertBase(this.nPost, "(нет)");
      this.numCar.Text = "";
      this.Doz.Text = "";
      this.selectDoz.Text = "полный";
      this.SetPrice();
    }

    private void SetPrice()
    {
      this.PriceCodBox.Text = ChangePricesForm.MainCodPrice;
      this.PriceCod = this.PriceCodBox.Text;
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
      {
        if (listViewItem.SubItems[0].Text == this.PriceCodBox.Text & (int) (double.Parse(listViewItem.SubItems[1].Text) * 100.0) != this.m_Data.Price)
        {
          int[] _handlesSrv = new int[1]
          {
            this.m_Data.handlesPrice
          };
          this.m_OPCAdapter.WriteTag(new object[1]
          {
            (object) (int) (double.Parse(listViewItem.SubItems[1].Text) * 100.0)
          }, _handlesSrv);
          this.PriceCod = this.PriceCodBox.Text;
        }
      }
    }

    private void OnPusk()
    {
      if (this.m_Data.Pusk)
        this.lPusk.Text = "П";
      else
        this.lPusk.Text = "";
    }

    private void OnEKM()
    {
      if (this.m_Data.EKM)
        this.labEKM.Text = "";
      else
        this.labEKM.Text = "ЭKM";
    }

    private void OnStop()
    {
      if (this.m_Data.Stop)
        this.lStop.Text = "С";
      else
        this.lStop.Text = "";
    }

    private void OnAlarmFlow()
    {
      if (!this.m_Data.AlarmFlow && this.State.Text == "Расход сверх нормы")
        this.m_Data.refresh = true;
      if (!this.m_Data.AlarmFlow)
        return;
      this.PostBox.BackColor = Color.Red;
      this.State.Text = "Расход сверх нормы";
    }

    private void OnNoGasAlarm()
    {
      if (!this.m_Data.NoGasAlarm && this.State.Text == "Нет газа")
        this.m_Data.refresh = true;
      if (!this.m_Data.NoGasAlarm)
        return;
      this.PostBox.BackColor = Color.Red;
      this.State.Text = "Нет газа";
    }

    private void OnAlarmLeakage()
    {
      if (!this.m_Data.AlarmLeakage && this.State.Text == "Утечка газа")
        this.m_Data.refresh = true;
      if (!this.m_Data.AlarmLeakage)
        return;
      this.PostBox.BackColor = Color.Red;
      this.State.Text = "Утечка газа";
    }

    private void OnCountAlarm()
    {
    }

    private void OnConnectOut()
    {
      if (!(this.State.Text == "Нет связи") || !this.flagNoConnect || !(this.BackColor == Color.Red))
        return;
      this.m_Data.refresh = true;
    }

    private void timeNoConnect_Tick(object sender, EventArgs e)
    {
      if (this.NoConnect > 10 && this.flagNoConnect)
      {
        this.State.Text = "Нет связи";
        this.flagNoConnect = false;
        this.lGot.Text = this.lPusk.Text = this.lStop.Text = "";
        this.PostBox.BackColor = Color.Red;
        this.m_Data.NoConnect = true;
        switch (this.nPost)
        {
          case 1:
            this.m_AlarmsArhive.WriteAlarm("Нет связи c постом", "Пост1", true);
            break;
          case 2:
            this.m_AlarmsArhive.WriteAlarm("Нет связи c постом", "Пост2", true);
            break;
          case 3:
            this.m_AlarmsArhive.WriteAlarm("Нет связи c постом", "Пост3", true);
            break;
          case 4:
            this.m_AlarmsArhive.WriteAlarm("Нет связи c постом", "Пост4", true);
            break;
        }
      }
      else
        ++this.NoConnect;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      this.m_Data.car = ((Control) sender).Text;
    }

    public bool PostButton
    {
      set
      {
        this.statePostButton = value;
        if (!this.statePostButton)
          return;
        this.buttonShowAs("Стоп");
      }
    }

    private void buttonShowAs(string name)
    {
      if (this.OnlyPost)
      {
        this.button.Text = "Стоп";
        this.button.BackColor = Color.Red;
      }
      else if (name == "Стоп")
      {
        this.button.Text = "Стоп";
        this.button.BackColor = Color.Red;
      }
      else
      {
        this.button.Text = "Пуск";
        this.button.BackColor = Color.LightGreen;
      }
    }

    public void ChangePricelist(object sender, EventArgs e)
    {
      this.Pricelist = (ListView) sender;
      this.PriceCodBox.Items.Clear();
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
        this.PriceCodBox.Items.Add((object) listViewItem.SubItems[0].Text);
    }

    private void PriceCodBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void WritePrice_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
      {
        if (listViewItem.SubItems[0].Text == this.PriceCodBox.Text)
        {
          int[] _handlesSrv = new int[1]
          {
            this.m_Data.handlesPrice
          };
          this.m_OPCAdapter.WriteTag(new object[1]
          {
            (object) (int) (double.Parse(listViewItem.SubItems[1].Text) * 100.0)
          }, _handlesSrv);
          this.PriceCod = this.PriceCodBox.Text;
        }
      }
    }

    private void AlarmReset_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv = new int[5];
      object[] itemValues = new object[5]
      {
        (object) true,
        (object) false,
        (object) false,
        (object) false,
        (object) false
      };
      _handlesSrv[0] = this.m_Data.handlesResetAlarms;
      _handlesSrv[1] = this.m_Data.handlesSaveAlarmFlow;
      _handlesSrv[2] = this.m_Data.handlesSaveAlarmLeakage;
      _handlesSrv[3] = this.m_Data.handlesSaveCountAlarm;
      _handlesSrv[4] = this.m_Data.handlesSaveNoGasAlarm;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv);
    }

    private void Doz_TextChanged(object sender, EventArgs e)
    {
      this.selectDoz.Text = "полный";
      figures.TestingFigures((TextBox) sender);
      this.m_OPCAdapter.WriteTag(new object[1]
      {
        (object) 100000.0
      }, new int[1]{ this.m_Data.handlesUpDoze });
    }

    private void selectDoz_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.selectDoz.Text == this.selectDoz.Items[0].ToString())
        this.m_OPCAdapter.WriteTag(new object[1]
        {
          (object) 100000.0
        }, new int[1]{ this.m_Data.handlesUpDoze });
      if (this.Doz.Text == "" && this.selectDoz.Text != this.selectDoz.Items[0].ToString())
      {
        int num = (int) MessageBox.Show("Вначале введите дозу!!!");
        this.selectDoz.Text = this.selectDoz.Items[0].ToString();
      }
      else
        this.WriteDoz();
    }

    private void WriteDoz()
    {
      if (!(this.Doz.Text != ""))
        return;
      double num1 = double.Parse(this.PriceBox.Text);
      double num2;
      switch (this.selectDoz.Text)
      {
        case "полный":
          return;
        case "нм3":
          num2 = 1.0;
          break;
        case "грн":
          num2 = 1.0 / num1;
          break;
        default:
          num2 = 0.0;
          break;
      }
      double num3 = num2 * double.Parse(this.Doz.Text);
      if (num3 <= 0.0)
        return;
      int[] _handlesSrv = new int[1]
      {
        this.m_Data.handlesUpDoze
      };
      this.m_OPCAdapter.WriteTag(new object[1]
      {
        (object) num3
      }, _handlesSrv);
    }

    private void timRefuelling_Tick(object sender, EventArgs e)
    {
      this.dtContinueRefuelling = DateTime.Now;
      TimeSpan timeSpan = this.dtContinueRefuelling - this.dtStartRefuelling;
      this.labTime.Text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");
    }

    private void PriceCodBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      string empty = string.Empty;
      int num = this.PriceCodBox.FindString(this.PriceCodBox.Text);
      if (num == -1)
        return;
      this.PriceCodBox.SelectedIndex = num;
    }

    private delegate void _dChangedTags(object sender, EventInfo ei);
  }
}
