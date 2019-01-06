// Decompiled with JetBrains decompiler
// Type: agnks.AddUserForm
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class AddUserForm : Form
  {
    private Container components = (Container) null;
    private Label label1;
    public TextBox UserName;
    private Label UserLabel;
    private Label PasswordLabel;
    public TextBox Password;
    private Label HeadLabel;
    private Button buttonOK;
    private Button ButtonCancel;
    public ComboBox UserRight;

    public AddUserForm()
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
      this.label1 = new Label();
      this.UserName = new TextBox();
      this.UserLabel = new Label();
      this.PasswordLabel = new Label();
      this.Password = new TextBox();
      this.HeadLabel = new Label();
      this.buttonOK = new Button();
      this.ButtonCancel = new Button();
      this.UserRight = new ComboBox();
      this.SuspendLayout();
      this.label1.Location = new Point(8, 96);
      this.label1.Name = "label1";
      this.label1.Size = new Size(48, 16);
      this.label1.TabIndex = 21;
      this.label1.Text = "Доступ";
      this.UserName.Location = new Point(56, 32);
      this.UserName.Name = "UserName";
      this.UserName.Size = new Size(168, 20);
      this.UserName.TabIndex = 19;
      this.UserName.Text = "";
      this.UserLabel.Location = new Point(8, 32);
      this.UserLabel.Name = "UserLabel";
      this.UserLabel.Size = new Size(32, 23);
      this.UserLabel.TabIndex = 18;
      this.UserLabel.Text = "Имя";
      this.PasswordLabel.Location = new Point(8, 64);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new Size(48, 23);
      this.PasswordLabel.TabIndex = 17;
      this.PasswordLabel.Text = "Пароль";
      this.Password.Location = new Point(56, 64);
      this.Password.MaxLength = 8;
      this.Password.Name = "Password";
      this.Password.PasswordChar = '*';
      this.Password.Size = new Size(168, 20);
      this.Password.TabIndex = 16;
      this.Password.Text = "";
      this.HeadLabel.Location = new Point(8, 8);
      this.HeadLabel.Name = "HeadLabel";
      this.HeadLabel.Size = new Size(232, 16);
      this.HeadLabel.TabIndex = 15;
      this.HeadLabel.Text = "Введите имя нового оператора и пароль";
      this.buttonOK.DialogResult = DialogResult.OK;
      this.buttonOK.Location = new Point(8, 136);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.TabIndex = 0;
      this.buttonOK.Text = "OK";
      this.ButtonCancel.DialogResult = DialogResult.Cancel;
      this.ButtonCancel.Location = new Point(144, 136);
      this.ButtonCancel.Name = "ButtonCancel";
      this.ButtonCancel.TabIndex = 5;
      this.ButtonCancel.Text = "Отмена";
      this.UserRight.Items.AddRange(new object[3]
      {
        (object) "АДМИНИСТРАТОР",
        (object) "МАСТЕР",
        (object) "ОПЕРАТОР"
      });
      this.UserRight.Location = new Point(56, 96);
      this.UserRight.Name = "UserRight";
      this.UserRight.Size = new Size(168, 21);
      this.UserRight.TabIndex = 22;
      this.AcceptButton = (IButtonControl) this.buttonOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.ButtonCancel;
      this.ClientSize = new Size(232, 165);
      this.Controls.Add((Control) this.UserRight);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.UserName);
      this.Controls.Add((Control) this.UserLabel);
      this.Controls.Add((Control) this.PasswordLabel);
      this.Controls.Add((Control) this.Password);
      this.Controls.Add((Control) this.HeadLabel);
      this.Controls.Add((Control) this.ButtonCancel);
      this.Controls.Add((Control) this.buttonOK);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AddUserForm);
      this.Text = "Новый оператор";
      this.TopMost = true;
      this.ResumeLayout(false);
    }
  }
}
