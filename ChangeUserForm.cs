// Decompiled with JetBrains decompiler
// Type: agnks.ChangeUserForm
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace agnks
{
  public class ChangeUserForm : Form
  {
    public string Path = "test.txt";
    private Container components = (Container) null;
    private Button buttonOK;
    private Button RemouteUser;
    private Button AddUser;
    public ArrayList ArrayUsers;
    public Form1 f;
    private ListView Userslist;
    private ColumnHeader NameColumn;
    private ColumnHeader RightColumn;

    public ChangeUserForm()
    {
      this.InitializeComponent();
      this.ArrayUsers = new ArrayList();
      if (!File.Exists(this.Path))
        return;
      Stream serializationStream = (Stream) File.OpenRead(this.Path);
      this.ArrayUsers = (ArrayList) new SoapFormatter().Deserialize(serializationStream);
      serializationStream.Close();
      this.Userslist.Items.Clear();
      foreach (User arrayUser in this.ArrayUsers)
        this.Userslist.Items.Add(new ListViewItem(arrayUser.name)
        {
          SubItems = {
            arrayUser.right
          }
        });
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.buttonOK = new Button();
      this.RemouteUser = new Button();
      this.AddUser = new Button();
      this.Userslist = new ListView();
      this.NameColumn = new ColumnHeader();
      this.RightColumn = new ColumnHeader();
      this.SuspendLayout();
      this.buttonOK.DialogResult = DialogResult.OK;
      this.buttonOK.Location = new Point(272, 72);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new Size(104, 23);
      this.buttonOK.TabIndex = 7;
      this.buttonOK.Text = "Выход";
      this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
      this.RemouteUser.Location = new Point(272, 40);
      this.RemouteUser.Name = "RemouteUser";
      this.RemouteUser.Size = new Size(104, 23);
      this.RemouteUser.TabIndex = 6;
      this.RemouteUser.Text = "Удалить";
      this.RemouteUser.Click += new EventHandler(this.RemouteUser_Click);
      this.AddUser.Location = new Point(272, 8);
      this.AddUser.Name = "AddUser";
      this.AddUser.Size = new Size(104, 23);
      this.AddUser.TabIndex = 5;
      this.AddUser.Text = "Добавить";
      this.AddUser.Click += new EventHandler(this.AddUser_Click);
      this.Userslist.Columns.AddRange(new ColumnHeader[2]
      {
        this.NameColumn,
        this.RightColumn
      });
      this.Userslist.FullRowSelect = true;
      this.Userslist.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.Userslist.Name = "Userslist";
      this.Userslist.Size = new Size(264, 224);
      this.Userslist.TabIndex = 8;
      this.Userslist.View = View.Details;
      this.NameColumn.Text = "Имя";
      this.NameColumn.Width = 110;
      this.RightColumn.Text = "Право доступа";
      this.RightColumn.Width = 150;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(384, 229);
      this.Controls.AddRange(new Control[4]
      {
        (Control) this.Userslist,
        (Control) this.buttonOK,
        (Control) this.RemouteUser,
        (Control) this.AddUser
      });
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ChangeUserForm);
      this.Text = "Список операторов";
      this.TopMost = true;
      this.Closing += new CancelEventHandler(this.ChangeUserForm_Closing);
      this.ResumeLayout(false);
    }

    public string NewUser()
    {
      newusers newusers = new newusers();
      newusers.FormBorderStyle = FormBorderStyle.FixedDialog;
      foreach (User arrayUser in this.ArrayUsers)
        newusers.NameUser.Items.Add((object) arrayUser.name);
      int num1 = (int) newusers.ShowDialog();
      if (newusers.DialogResult == DialogResult.OK)
      {
        if (newusers.NameUser.Text == "ADMIN" && newusers.Password.Text == "1234")
        {
          this.f.security("АДМИНИСТРАТОР");
          return "ADMIN";
        }
        foreach (User arrayUser in this.ArrayUsers)
        {
          if (arrayUser.name == newusers.NameUser.Text)
          {
            if (arrayUser.password == newusers.Password.Text)
            {
              this.f.security(arrayUser.right);
              return arrayUser.name;
            }
            this.f.security("");
            int num2 = (int) MessageBox.Show("Неверный пароль!");
            return "";
          }
        }
        this.f.security("");
        int num3 = (int) MessageBox.Show("Нeт такого оператора!");
      }
      else
        this.f.security("");
      return "";
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void ChangeUserForm_Closing(object sender, CancelEventArgs e)
    {
      this.Hide();
    }

    private void AddUser_Click(object sender, EventArgs e)
    {
      AddUserForm addUserForm = new AddUserForm();
      addUserForm.FormBorderStyle = FormBorderStyle.FixedDialog;
      int num1 = (int) addUserForm.ShowDialog();
      if (addUserForm.DialogResult != DialogResult.OK)
        return;
      if (addUserForm.UserName.Text == "")
      {
        int num2 = (int) MessageBox.Show("Введите имя!!!");
      }
      else
      {
        foreach (User arrayUser in this.ArrayUsers)
        {
          if (arrayUser.name == addUserForm.UserName.Text)
          {
            int num3 = (int) MessageBox.Show("Такой пользователь уже есть!!!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
        this.ArrayUsers.Add((object) new User()
        {
          name = addUserForm.UserName.Text,
          password = addUserForm.Password.Text,
          right = addUserForm.UserRight.Text
        });
        this.saveArrayUsers();
        this.Userslist.Items.Clear();
        foreach (User arrayUser in this.ArrayUsers)
          this.Userslist.Items.Add(new ListViewItem(arrayUser.name)
          {
            SubItems = {
              arrayUser.right
            }
          });
      }
    }

    private void RemouteUser_Click(object sender, EventArgs e)
    {
      string str = "";
      foreach (ListViewItem listViewItem in this.Userslist.Items)
      {
        if (listViewItem.Selected)
        {
          str = listViewItem.Text;
          this.Userslist.Items.RemoveAt(listViewItem.Index);
        }
      }
      foreach (User arrayUser in this.ArrayUsers)
      {
        if (arrayUser.name == str)
        {
          this.ArrayUsers.Remove((object) arrayUser);
          break;
        }
      }
      this.saveArrayUsers();
    }

    private void saveArrayUsers()
    {
      if (File.Exists(this.Path))
        File.Delete(this.Path);
      Stream serializationStream = (Stream) File.OpenWrite(this.Path);
      new SoapFormatter().Serialize(serializationStream, (object) this.ArrayUsers);
      serializationStream.Close();
    }

    public void LoadListUser()
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    public void ChangePassword(string username)
    {
      string str = "";
      ChangePasswordForm changePasswordForm = new ChangePasswordForm();
      changePasswordForm.FormBorderStyle = FormBorderStyle.FixedDialog;
      foreach (User arrayUser in this.ArrayUsers)
      {
        if (arrayUser.name == username)
        {
          str = arrayUser.password;
          break;
        }
      }
      int num1 = (int) changePasswordForm.ShowDialog();
      if (changePasswordForm.DialogResult != DialogResult.OK)
        return;
      if (str == changePasswordForm.BoxOldPass.Text)
      {
        if (changePasswordForm.BoxNewPass.Text == changePasswordForm.BoxNewPassRep.Text)
        {
          foreach (User arrayUser in this.ArrayUsers)
          {
            if (arrayUser.name == username)
            {
              arrayUser.password = changePasswordForm.BoxNewPass.Text;
              break;
            }
          }
          this.saveArrayUsers();
        }
        else
        {
          int num2 = (int) MessageBox.Show("Неверно подтверждён новый пароль");
        }
      }
      else
      {
        int num3 = (int) MessageBox.Show("Неверный пароль");
      }
    }
  }
}
