// Decompiled with JetBrains decompiler
// Type: agnks.ChangePrice
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class ChangePrice : Form
  {
    private Container components = (Container) null;
    private Label label1;
    public TextBox PriceBox;
    private Button butOK;
    private Button butCansel;
    public TextBox CodPrice;
    private Label label2;
    private Label label3;

    public ChangePrice()
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
      this.PriceBox = new TextBox();
      this.butOK = new Button();
      this.label1 = new Label();
      this.butCansel = new Button();
      this.CodPrice = new TextBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.SuspendLayout();
      this.PriceBox.Location = new Point(48, 40);
      this.PriceBox.Name = "PriceBox";
      this.PriceBox.Size = new Size(104, 20);
      this.PriceBox.TabIndex = 0;
      this.PriceBox.Text = "0";
      this.PriceBox.TextChanged += new EventHandler(this.PriceBox_TextChanged);
      this.butOK.DialogResult = DialogResult.OK;
      this.butOK.Location = new Point(8, 80);
      this.butOK.Name = "butOK";
      this.butOK.TabIndex = 1;
      this.butOK.Text = "ОК";
      this.label1.Location = new Point(160, 40);
      this.label1.Name = "label1";
      this.label1.Size = new Size(32, 23);
      this.label1.TabIndex = 2;
      this.label1.Text = "грн";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.butCansel.DialogResult = DialogResult.Cancel;
      this.butCansel.Location = new Point(96, 80);
      this.butCansel.Name = "butCansel";
      this.butCansel.TabIndex = 3;
      this.butCansel.Text = "Отменить";
      this.CodPrice.Location = new Point(48, 8);
      this.CodPrice.Name = "CodPrice";
      this.CodPrice.Size = new Size(104, 20);
      this.CodPrice.TabIndex = 4;
      this.CodPrice.Text = "0";
      this.label2.Location = new Point(8, 8);
      this.label2.Name = "label2";
      this.label2.Size = new Size(32, 23);
      this.label2.TabIndex = 5;
      this.label2.Text = "Код";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(8, 40);
      this.label3.Name = "label3";
      this.label3.Size = new Size(40, 23);
      this.label3.TabIndex = 6;
      this.label3.Text = "Цена";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.butOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.butCansel;
      this.ClientSize = new Size(192, 109);
      this.Controls.AddRange(new Control[7]
      {
        (Control) this.label3,
        (Control) this.label2,
        (Control) this.CodPrice,
        (Control) this.butCansel,
        (Control) this.label1,
        (Control) this.butOK,
        (Control) this.PriceBox
      });
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ChangePrice);
      this.Text = "Изменить цену";
      this.TopMost = true;
      this.ResumeLayout(false);
    }

    private void PriceBox_TextChanged(object sender, EventArgs e)
    {
      figures.TestingFigures((TextBox) sender);
    }
  }
}
