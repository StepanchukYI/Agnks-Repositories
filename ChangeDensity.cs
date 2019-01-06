// Decompiled with JetBrains decompiler
// Type: agnks.ChangeDensity
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class ChangeDensity : Form
  {
    private Container components = (Container) null;
    private TextBox DensityBox;
    private Label label8;
    private Label label5;
    public Button bSave;
    private Button bCansel;
    public OPCAdapter m_OPCAdapter;
    public OPCAdapter m_OPCAdapter2;
    public OPCAdapter m_OPCAdapter3;
    public OPCAdapter m_OPCAdapter4;

    public ChangeDensity()
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
      this.DensityBox = new TextBox();
      this.label8 = new Label();
      this.label5 = new Label();
      this.bSave = new Button();
      this.bCansel = new Button();
      this.SuspendLayout();
      this.DensityBox.Location = new Point(104, 24);
      this.DensityBox.Name = "DensityBox";
      this.DensityBox.Size = new Size(48, 20);
      this.DensityBox.TabIndex = 31;
      this.DensityBox.Text = "0";
      this.label8.Location = new Point(160, 20);
      this.label8.Name = "label8";
      this.label8.Size = new Size(56, 24);
      this.label8.TabIndex = 32;
      this.label8.Text = "кг/нм3";
      this.label8.TextAlign = ContentAlignment.MiddleLeft;
      this.label5.Location = new Point(8, 24);
      this.label5.Name = "label5";
      this.label5.Size = new Size(96, 16);
      this.label5.TabIndex = 30;
      this.label5.Text = "Плотность газа";
      this.bSave.Location = new Point(16, 72);
      this.bSave.Name = "bSave";
      this.bSave.TabIndex = 33;
      this.bSave.Text = "Записать";
      this.bSave.Click += new EventHandler(this.bSave_Click);
      this.bCansel.DialogResult = DialogResult.Cancel;
      this.bCansel.Location = new Point(128, 72);
      this.bCansel.Name = "bCansel";
      this.bCansel.TabIndex = 34;
      this.bCansel.Text = "Выход";
      this.bCansel.Click += new EventHandler(this.bCansel_Click);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.bCansel;
      this.ClientSize = new Size(216, 101);
      this.ControlBox = false;
      this.Controls.Add((Control) this.bCansel);
      this.Controls.Add((Control) this.bSave);
      this.Controls.Add((Control) this.DensityBox);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ChangeDensity);
      this.Text = "Изменение плотности";
      this.VisibleChanged += new EventHandler(this.ChangeDensity_VisibleChanged);
      this.ResumeLayout(false);
    }

    private void bSave_Click(object sender, EventArgs e)
    {
      int[] _handlesSrv1 = new int[1];
      int[] _handlesSrv2 = new int[1];
      int[] _handlesSrv3 = new int[1];
      int[] _handlesSrv4 = new int[1];
      object[] itemValues = new object[1];
      try
      {
        itemValues[0] = (object) (int) (double.Parse(this.DensityBox.Text) * 100.0);
      }
      catch
      {
        this.DensityBox.Text = Math.Round((double) this.m_OPCAdapter.m_Data1.density / 100.0, 2).ToString();
        itemValues[0] = (object) (int) (double.Parse(this.DensityBox.Text) * 100.0);
      }
      _handlesSrv1[0] = this.m_OPCAdapter.m_Data1.handlesdensity;
      _handlesSrv2[0] = this.m_OPCAdapter2.m_Data1.handlesdensity;
      _handlesSrv3[0] = this.m_OPCAdapter3.m_Data1.handlesdensity;
      _handlesSrv4[0] = this.m_OPCAdapter4.m_Data1.handlesdensity;
      this.m_OPCAdapter.WriteTag(itemValues, _handlesSrv1);
      this.m_OPCAdapter2.WriteTag(itemValues, _handlesSrv2);
      this.m_OPCAdapter3.WriteTag(itemValues, _handlesSrv3);
      this.m_OPCAdapter4.WriteTag(itemValues, _handlesSrv4);
    }

    private void bCansel_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void ChangeDensity_VisibleChanged(object sender, EventArgs e)
    {
      this.DensityBox.Text = Math.Round((double) this.m_OPCAdapter.m_Data1.density / 100.0, 2).ToString();
    }
  }
}
