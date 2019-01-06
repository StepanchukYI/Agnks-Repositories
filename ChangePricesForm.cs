// Decompiled with JetBrains decompiler
// Type: agnks.ChangePricesForm
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
  public class ChangePricesForm : Form
  {
    public static string MainCodPrice = "";
    public string Path = "ListPrice.txt";
    private Container components = (Container) null;
    public ListView Pricelist;
    private Button OutButton;
    private ColumnHeader CodColumn;
    private ColumnHeader PriceColumn;
    private Button AddButton;
    private Button DelButton;
    private Button ChangeButton;
    private TextBox MainPrice;
    private Button butSelectMainPrice;
    private Label label1;

    public event ChangePriceList OnChangePriceList;

    public ChangePricesForm()
    {
      this.InitializeComponent();
      this.MainPrice.Text = ChangePricesForm.MainCodPrice;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.Pricelist = new ListView();
      this.CodColumn = new ColumnHeader();
      this.PriceColumn = new ColumnHeader();
      this.OutButton = new Button();
      this.AddButton = new Button();
      this.DelButton = new Button();
      this.ChangeButton = new Button();
      this.MainPrice = new TextBox();
      this.butSelectMainPrice = new Button();
      this.label1 = new Label();
      this.SuspendLayout();
      this.Pricelist.Columns.AddRange(new ColumnHeader[2]
      {
        this.CodColumn,
        this.PriceColumn
      });
      this.Pricelist.Cursor = Cursors.IBeam;
      this.Pricelist.FullRowSelect = true;
      this.Pricelist.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.Pricelist.LabelEdit = true;
      this.Pricelist.Location = new Point(8, 8);
      this.Pricelist.MultiSelect = false;
      this.Pricelist.Name = "Pricelist";
      this.Pricelist.Size = new Size(248, 240);
      this.Pricelist.Sorting = SortOrder.Ascending;
      this.Pricelist.TabIndex = 0;
      this.Pricelist.View = View.Details;
      this.Pricelist.MouseLeave += new EventHandler(this.Pricelist_MouseLeave);
      this.CodColumn.Text = "Код";
      this.CodColumn.Width = 160;
      this.PriceColumn.Text = "Цена, грн";
      this.PriceColumn.TextAlign = HorizontalAlignment.Center;
      this.PriceColumn.Width = 80;
      this.OutButton.Location = new Point(264, 8);
      this.OutButton.Name = "OutButton";
      this.OutButton.TabIndex = 1;
      this.OutButton.Text = "Выход";
      this.OutButton.Click += new EventHandler(this.OutButton_Click);
      this.AddButton.Location = new Point(264, 72);
      this.AddButton.Name = "AddButton";
      this.AddButton.TabIndex = 2;
      this.AddButton.Text = "Добавить";
      this.AddButton.Click += new EventHandler(this.AddButton_Click);
      this.DelButton.Enabled = false;
      this.DelButton.Location = new Point(264, 136);
      this.DelButton.Name = "DelButton";
      this.DelButton.TabIndex = 3;
      this.DelButton.Text = "Удалить";
      this.DelButton.Click += new EventHandler(this.DelButton_Click);
      this.ChangeButton.Enabled = false;
      this.ChangeButton.Location = new Point(264, 104);
      this.ChangeButton.Name = "ChangeButton";
      this.ChangeButton.TabIndex = 4;
      this.ChangeButton.Text = "Изменить";
      this.ChangeButton.Click += new EventHandler(this.ChangeButton_Click);
      this.MainPrice.Location = new Point(8, 280);
      this.MainPrice.Name = "MainPrice";
      this.MainPrice.ReadOnly = true;
      this.MainPrice.Size = new Size(248, 20);
      this.MainPrice.TabIndex = 5;
      this.MainPrice.Text = "";
      this.butSelectMainPrice.Enabled = false;
      this.butSelectMainPrice.Location = new Point(264, 184);
      this.butSelectMainPrice.Name = "butSelectMainPrice";
      this.butSelectMainPrice.Size = new Size(75, 56);
      this.butSelectMainPrice.TabIndex = 6;
      this.butSelectMainPrice.Text = "Назначить по умолчанию";
      this.butSelectMainPrice.Click += new EventHandler(this.butSelectMainPrice_Click);
      this.label1.Location = new Point(8, 256);
      this.label1.Name = "label1";
      this.label1.Size = new Size(248, 16);
      this.label1.TabIndex = 7;
      this.label1.Text = "Код цены по умолчанию";
      this.label1.TextAlign = ContentAlignment.BottomLeft;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(344, 310);
      this.Controls.AddRange(new Control[8]
      {
        (Control) this.label1,
        (Control) this.butSelectMainPrice,
        (Control) this.MainPrice,
        (Control) this.ChangeButton,
        (Control) this.DelButton,
        (Control) this.AddButton,
        (Control) this.OutButton,
        (Control) this.Pricelist
      });
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ChangePricesForm);
      this.Text = "Цены";
      this.TopMost = true;
      this.Closing += new CancelEventHandler(this.ChangePricesForm_Closing);
      this.ResumeLayout(false);
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
      AddPrice addPrice = new AddPrice();
      addPrice.FormBorderStyle = FormBorderStyle.FixedDialog;
      int num1 = (int) addPrice.ShowDialog();
      if (addPrice.DialogResult != DialogResult.OK)
        return;
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
      {
        if (listViewItem.SubItems[0].Text == addPrice.CodBox.Text)
        {
          int num2 = (int) MessageBox.Show("Такой код уже есть", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      this.Pricelist.Items.Add(new ListViewItem(addPrice.CodBox.Text)
      {
        SubItems = {
          addPrice.PriceBox.Text
        }
      });
      this.saveArrayPrice();
    }

    private void OutButton_Click(object sender, EventArgs e)
    {
      this.Hide();
    }

    private void DelButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
      {
        if (listViewItem.Selected)
        {
          if (listViewItem.SubItems[0].Text != ChangePricesForm.MainCodPrice)
          {
            this.Pricelist.Items.RemoveAt(listViewItem.Index);
            this.saveArrayPrice();
          }
          else
          {
            int num = (int) MessageBox.Show("Для того чтобы удалить этот код цены назначте другой код цены по умолчанию!");
          }
        }
      }
      this.DelButton.Enabled = false;
    }

    private void ChangePricesForm_Closing(object sender, CancelEventArgs e)
    {
      this.Hide();
    }

    private void ChangeButton_Click(object sender, EventArgs e)
    {
      ChangePrice changePrice = new ChangePrice();
      changePrice.FormBorderStyle = FormBorderStyle.FixedDialog;
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
      {
        if (listViewItem.Selected)
        {
          changePrice.CodPrice.Text = listViewItem.SubItems[0].Text;
          changePrice.PriceBox.Text = listViewItem.SubItems[1].Text;
        }
      }
      int num = (int) changePrice.ShowDialog();
      if (changePrice.DialogResult == DialogResult.OK)
      {
        foreach (ListViewItem listViewItem in this.Pricelist.Items)
        {
          if (listViewItem.Selected)
          {
            listViewItem.SubItems[0].Text = changePrice.CodPrice.Text;
            listViewItem.SubItems[1].Text = changePrice.PriceBox.Text;
          }
        }
        this.saveArrayPrice();
      }
      this.ChangeButton.Enabled = false;
    }

    public void FullPricesList()
    {
      ArrayList arrayList1 = new ArrayList();
      if (!File.Exists(this.Path))
        return;
      Stream serializationStream = (Stream) File.OpenRead(this.Path);
      ArrayList arrayList2 = (ArrayList) new SoapFormatter().Deserialize(serializationStream);
      serializationStream.Close();
      foreach (codprice codprice in arrayList2)
        this.Pricelist.Items.Add(new ListViewItem(codprice.cod)
        {
          SubItems = {
            codprice.price
          }
        });
      this.OnChangePriceList((object) this.Pricelist, new EventArgs());
    }

    private void Pricelist_MouseLeave(object sender, EventArgs e)
    {
      this.ChangeButton.Enabled = false;
      this.DelButton.Enabled = false;
      this.butSelectMainPrice.Enabled = false;
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
      {
        if (listViewItem.Selected)
        {
          this.ChangeButton.Enabled = true;
          this.DelButton.Enabled = true;
          this.butSelectMainPrice.Enabled = true;
          break;
        }
      }
    }

    private void saveArrayPrice()
    {
      ArrayList arrayList = new ArrayList();
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
        arrayList.Add((object) new codprice()
        {
          cod = listViewItem.SubItems[0].Text,
          price = listViewItem.SubItems[1].Text
        });
      if (File.Exists(this.Path))
        File.Delete(this.Path);
      Stream serializationStream = (Stream) File.OpenWrite(this.Path);
      new SoapFormatter().Serialize(serializationStream, (object) arrayList);
      serializationStream.Close();
      this.OnChangePriceList((object) this.Pricelist, new EventArgs());
    }

    public void Security(bool b)
    {
      this.AddButton.Enabled = this.ChangeButton.Enabled = this.DelButton.Enabled = this.butSelectMainPrice.Enabled = b;
    }

    private void butSelectMainPrice_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem listViewItem in this.Pricelist.Items)
      {
        if (listViewItem.Selected)
        {
          ChangePricesForm.MainCodPrice = listViewItem.SubItems[0].Text;
          this.MainPrice.Text = ChangePricesForm.MainCodPrice;
          this.OnChangePriceList((object) this.Pricelist, new EventArgs());
        }
      }
      this.butSelectMainPrice.Enabled = false;
    }
  }
}
