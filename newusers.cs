// Decompiled with JetBrains decompiler
// Type: agnks.newusers
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace agnks
{
  public class newusers : Form
  {
    private Container components = (Container) null;
    private Label UserLabel;
    private Label PasswordLabel;
    public TextBox Password;
    private Button ButtonCancel;
    private Button buttonOK;
    public ComboBox NameUser;

    public newusers()
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
      this.UserLabel = new Label();
      this.PasswordLabel = new Label();
      this.Password = new TextBox();
      this.ButtonCancel = new Button();
      this.buttonOK = new Button();
      this.NameUser = new ComboBox();
      this.SuspendLayout();
      this.UserLabel.Location = new Point(8, 8);
      this.UserLabel.Name = "UserLabel";
      this.UserLabel.Size = new Size(32, 23);
      this.UserLabel.TabIndex = 23;
      this.UserLabel.Text = "Имя";
      this.PasswordLabel.Location = new Point(8, 40);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new Size(48, 23);
      this.PasswordLabel.TabIndex = 22;
      this.PasswordLabel.Text = "Пароль";
      this.Password.Location = new Point(64, 40);
      this.Password.MaxLength = 8;
      this.Password.Name = "Password";
      this.Password.PasswordChar = '*';
      this.Password.Size = new Size(168, 20);
      this.Password.TabIndex = 25;
      this.Password.Text = "";
      this.ButtonCancel.DialogResult = DialogResult.Cancel;
      this.ButtonCancel.Location = new Point(144, 72);
      this.ButtonCancel.Name = "ButtonCancel";
      this.ButtonCancel.TabIndex = 30;
      this.ButtonCancel.Text = "Отмена";
      this.buttonOK.DialogResult = DialogResult.OK;
      this.buttonOK.Location = new Point(16, 72);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.TabIndex = 29;
      this.buttonOK.Text = "OK";
      this.NameUser.Location = new Point(64, 8);
      this.NameUser.Name = "NameUser";
      this.NameUser.Size = new Size(168, 21);
      this.NameUser.Sorted = true;
      this.NameUser.TabIndex = 31;
      this.AcceptButton = (IButtonControl) this.buttonOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = (IButtonControl) this.ButtonCancel;
      this.ClientSize = new Size(240, 101);
      this.Controls.AddRange(new Control[6]
      {
        (Control) this.NameUser,
        (Control) this.ButtonCancel,
        (Control) this.buttonOK,
        (Control) this.Password,
        (Control) this.UserLabel,
        (Control) this.PasswordLabel
      });
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (newusers);
      this.Text = "Новый оператор";
      this.TopMost = true;
      this.ResumeLayout(false);
    }
  }
}
