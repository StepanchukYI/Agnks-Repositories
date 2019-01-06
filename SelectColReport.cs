// Decompiled with JetBrains decompiler
// Type: agnks.SelectColReport
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class SelectColReport : Form
  {
    private Container components = (Container) null;
    private Button butOK;
    private Button butCancel;
    public CheckBox m_User;
    public CheckBox m_Car;
    public CheckBox m_Density;
    public CheckBox m_Price;
    public CheckBox m_CodPrice;
    public CheckBox m_Post;
    public CheckBox m_Volume;
    public CheckBox m_Cost;
    public CheckBox m_Date;

    public SelectColReport()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.butOK = new Button();
      this.butCancel = new Button();
      this.m_User = new CheckBox();
      this.m_Car = new CheckBox();
      this.m_Density = new CheckBox();
      this.m_Price = new CheckBox();
      this.m_CodPrice = new CheckBox();
      this.m_Post = new CheckBox();
      this.m_Volume = new CheckBox();
      this.m_Cost = new CheckBox();
      this.m_Date = new CheckBox();
      this.SuspendLayout();
      this.butOK.DialogResult = DialogResult.OK;
      this.butOK.Location = new Point(136, 8);
      this.butOK.Name = "butOK";
      this.butOK.TabIndex = 6;
      this.butOK.Text = "ОК";
      this.butCancel.DialogResult = DialogResult.Cancel;
      this.butCancel.Location = new Point(136, 40);
      this.butCancel.Name = "butCancel";
      this.butCancel.TabIndex = 7;
      this.butCancel.Text = "Отменить";
      this.m_User.Checked = true;
      this.m_User.CheckState = CheckState.Checked;
      this.m_User.Location = new Point(8, 152);
      this.m_User.Name = "m_User";
      this.m_User.TabIndex = 8;
      this.m_User.Text = "Оператор";
      this.m_Car.Location = new Point(8, 176);
      this.m_Car.Name = "m_Car";
      this.m_Car.Size = new Size(120, 24);
      this.m_Car.TabIndex = 9;
      this.m_Car.Text = "Номер машины";
      this.m_Density.Location = new Point(8, 200);
      this.m_Density.Name = "m_Density";
      this.m_Density.TabIndex = 10;
      this.m_Density.Text = "Плотность";
      this.m_Price.Checked = true;
      this.m_Price.CheckState = CheckState.Checked;
      this.m_Price.Location = new Point(8, 80);
      this.m_Price.Name = "m_Price";
      this.m_Price.TabIndex = 1;
      this.m_Price.Text = "Цена";
      this.m_CodPrice.Checked = true;
      this.m_CodPrice.CheckState = CheckState.Checked;
      this.m_CodPrice.Location = new Point(8, 56);
      this.m_CodPrice.Name = "m_CodPrice";
      this.m_CodPrice.TabIndex = 2;
      this.m_CodPrice.Text = "Код цены";
      this.m_Post.Checked = true;
      this.m_Post.CheckState = CheckState.Checked;
      this.m_Post.Location = new Point(8, 32);
      this.m_Post.Name = "m_Post";
      this.m_Post.TabIndex = 4;
      this.m_Post.Text = "Пост";
      this.m_Volume.Checked = true;
      this.m_Volume.CheckState = CheckState.Checked;
      this.m_Volume.Location = new Point(8, 104);
      this.m_Volume.Name = "m_Volume";
      this.m_Volume.TabIndex = 3;
      this.m_Volume.Text = "Объём";
      this.m_Cost.Checked = true;
      this.m_Cost.CheckState = CheckState.Checked;
      this.m_Cost.Location = new Point(8, 128);
      this.m_Cost.Name = "m_Cost";
      this.m_Cost.TabIndex = 5;
      this.m_Cost.Text = "Стоимость";
      this.m_Date.Checked = true;
      this.m_Date.CheckState = CheckState.Checked;
      this.m_Date.Location = new Point(8, 8);
      this.m_Date.Name = "m_Date";
      this.m_Date.TabIndex = 0;
      this.m_Date.Text = "Дата заправки";
      this.AcceptButton = (IButtonControl) this.butOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.butCancel;
      this.ClientSize = new Size(216, 229);
      this.Controls.AddRange(new Control[11]
      {
        (Control) this.m_Density,
        (Control) this.m_Car,
        (Control) this.m_User,
        (Control) this.butCancel,
        (Control) this.butOK,
        (Control) this.m_Cost,
        (Control) this.m_Post,
        (Control) this.m_Volume,
        (Control) this.m_CodPrice,
        (Control) this.m_Price,
        (Control) this.m_Date
      });
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SelectColReport);
      this.Text = "Выбор ";
      this.ResumeLayout(false);
    }

    public int GetNumCol()
    {
      return 0;
    }
  }
}
