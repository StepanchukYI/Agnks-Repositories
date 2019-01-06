// Decompiled with JetBrains decompiler
// Type: agnks.ChangePasswordForm
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class ChangePasswordForm : Form
  {
    private Container components = (Container) null;
    private Button butOK;
    private Button butCancel;
    private Label label1;
    private Label label2;
    private Label label3;
    public TextBox BoxOldPass;
    public TextBox BoxNewPass;
    public TextBox BoxNewPassRep;

    public ChangePasswordForm()
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
      this.BoxOldPass = new TextBox();
      this.BoxNewPass = new TextBox();
      this.BoxNewPassRep = new TextBox();
      this.butOK = new Button();
      this.butCancel = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.SuspendLayout();
      this.BoxOldPass.Location = new Point(144, 16);
      this.BoxOldPass.Name = "BoxOldPass";
      this.BoxOldPass.PasswordChar = '*';
      this.BoxOldPass.Size = new Size(144, 20);
      this.BoxOldPass.TabIndex = 0;
      this.BoxOldPass.Text = "";
      this.BoxNewPass.Location = new Point(144, 48);
      this.BoxNewPass.Name = "BoxNewPass";
      this.BoxNewPass.PasswordChar = '*';
      this.BoxNewPass.Size = new Size(144, 20);
      this.BoxNewPass.TabIndex = 1;
      this.BoxNewPass.Text = "";
      this.BoxNewPassRep.Location = new Point(144, 80);
      this.BoxNewPassRep.Name = "BoxNewPassRep";
      this.BoxNewPassRep.PasswordChar = '*';
      this.BoxNewPassRep.Size = new Size(144, 20);
      this.BoxNewPassRep.TabIndex = 2;
      this.BoxNewPassRep.Text = "";
      this.butOK.DialogResult = DialogResult.OK;
      this.butOK.Location = new Point(48, 128);
      this.butOK.Name = "butOK";
      this.butOK.TabIndex = 3;
      this.butOK.Text = "OK";
      this.butCancel.DialogResult = DialogResult.Cancel;
      this.butCancel.Location = new Point(168, 128);
      this.butCancel.Name = "butCancel";
      this.butCancel.TabIndex = 4;
      this.butCancel.Text = "Отмена";
      this.label1.Location = new Point(8, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(136, 23);
      this.label1.TabIndex = 5;
      this.label1.Text = "Введите старый пароль";
      this.label1.TextAlign = ContentAlignment.MiddleLeft;
      this.label2.Location = new Point(8, 48);
      this.label2.Name = "label2";
      this.label2.Size = new Size(136, 23);
      this.label2.TabIndex = 6;
      this.label2.Text = "Введите новый пароль";
      this.label2.TextAlign = ContentAlignment.MiddleLeft;
      this.label3.Location = new Point(8, 80);
      this.label3.Name = "label3";
      this.label3.Size = new Size(136, 23);
      this.label3.TabIndex = 7;
      this.label3.Text = "Подтвердите новый пароль";
      this.label3.TextAlign = ContentAlignment.MiddleLeft;
      this.AcceptButton = (IButtonControl) this.butOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.butCancel;
      this.ClientSize = new Size(292, 157);
      this.Controls.AddRange(new Control[8]
      {
        (Control) this.label3,
        (Control) this.label2,
        (Control) this.label1,
        (Control) this.butCancel,
        (Control) this.butOK,
        (Control) this.BoxNewPassRep,
        (Control) this.BoxNewPass,
        (Control) this.BoxOldPass
      });
      this.MaximizeBox = false;
      this.Name = nameof (ChangePasswordForm);
      this.Text = "Изменение пароля";
      this.ResumeLayout(false);
    }
  }
}
