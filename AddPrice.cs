// Decompiled with JetBrains decompiler
// Type: agnks.AddPrice
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class AddPrice : Form
  {
    private Container components = (Container) null;
    private Button ButOK;
    private Button butCansel;
    public TextBox CodBox;
    public TextBox PriceBox;
    private Label label1;
    private Label label2;
    private Label label3;

    public AddPrice()
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
      this.ButOK = new Button();
      this.butCansel = new Button();
      this.CodBox = new TextBox();
      this.PriceBox = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.SuspendLayout();
      this.ButOK.DialogResult = DialogResult.OK;
      this.ButOK.Location = new Point(192, 8);
      this.ButOK.Name = "ButOK";
      this.ButOK.TabIndex = 0;
      this.ButOK.Text = "OK";
      this.butCansel.DialogResult = DialogResult.Cancel;
      this.butCansel.Location = new Point(192, 40);
      this.butCansel.Name = "butCansel";
      this.butCansel.TabIndex = 1;
      this.butCansel.Text = "Отменить";
      this.CodBox.Location = new Point(48, 16);
      this.CodBox.Name = "CodBox";
      this.CodBox.TabIndex = 2;
      this.CodBox.Text = "";
      this.PriceBox.Location = new Point(48, 40);
      this.PriceBox.Name = "PriceBox";
      this.PriceBox.TabIndex = 3;
      this.PriceBox.Text = "0";
      this.PriceBox.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.label1.Location = new Point(8, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(32, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = "Код";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(8, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(40, 23);
      this.label2.TabIndex = 5;
      this.label2.Text = "Цена";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(152, 40);
      this.label3.Name = "label3";
      this.label3.Size = new Size(32, 23);
      this.label3.TabIndex = 6;
      this.label3.Text = "грн";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.ButOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.butCansel;
      this.ClientSize = new Size(272, 69);
      this.Controls.AddRange(new Control[7]
      {
        (Control) this.label3,
        (Control) this.label2,
        (Control) this.label1,
        (Control) this.PriceBox,
        (Control) this.CodBox,
        (Control) this.butCansel,
        (Control) this.ButOK
      });
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AddPrice);
      this.Text = "Новые код и цена";
      this.TopMost = true;
      this.ResumeLayout(false);
    }

    private void PriceBox_TextChanged(object sender, EventArgs e)
    {
      figures.TestingFigures((TextBox) sender);
    }
  }
}
