// Decompiled with JetBrains decompiler
// Type: agnks.DataSet1
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace agnks
{
  [Serializable]
  public class DataSet1 : DataSet
  {
    private DataSet1.ArhiveDataTable tableArhive;

    public DataSet1()
    {
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }

    protected DataSet1(SerializationInfo info, StreamingContext context)
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (s != null)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (Arhive)] != null)
          this.Tables.Add((DataTable) new DataSet1.ArhiveDataTable(dataSet.Tables[nameof (Arhive)]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
        this.InitClass();
      this.GetSerializationData(info, context);
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }

    public DataSet1.ArhiveDataTable Arhive
    {
      get
      {
        return this.tableArhive;
      }
    }

    public override DataSet Clone()
    {
      DataSet1 dataSet1 = (DataSet1) base.Clone();
      dataSet1.InitVars();
      return (DataSet) dataSet1;
    }

    protected override bool ShouldSerializeTables()
    {
      return false;
    }

    protected override bool ShouldSerializeRelations()
    {
      return false;
    }

    protected override void ReadXmlSerializable(XmlReader reader)
    {
      this.Reset();
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml(reader);
      if (dataSet.Tables["Arhive"] != null)
        this.Tables.Add((DataTable) new DataSet1.ArhiveDataTable(dataSet.Tables["Arhive"]));
      this.DataSetName = dataSet.DataSetName;
      this.Prefix = dataSet.Prefix;
      this.Namespace = dataSet.Namespace;
      this.Locale = dataSet.Locale;
      this.CaseSensitive = dataSet.CaseSensitive;
      this.EnforceConstraints = dataSet.EnforceConstraints;
      this.Merge(dataSet, false, MissingSchemaAction.Add);
      this.InitVars();
    }

    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    internal void InitVars()
    {
      this.tableArhive = (DataSet1.ArhiveDataTable) this.Tables["Arhive"];
      if (this.tableArhive == null)
        return;
      this.tableArhive.InitVars();
    }

    private void InitClass()
    {
      this.DataSetName = nameof (DataSet1);
      this.Prefix = "";
      this.Namespace = "http://www.tempuri.org/DataSet1.xsd";
      this.Locale = new CultureInfo("ru-RU");
      this.CaseSensitive = false;
      this.EnforceConstraints = true;
      this.tableArhive = new DataSet1.ArhiveDataTable();
      this.Tables.Add((DataTable) this.tableArhive);
    }

    private bool ShouldSerializeArhive()
    {
      return false;
    }

    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    public delegate void ArhiveRowChangeEventHandler(object sender, DataSet1.ArhiveRowChangeEvent e);

    public class ArhiveDataTable : DataTable, IEnumerable
    {
      private DataColumn columnДата;
      private DataColumn columnКод_цены;
      private DataColumn columnНомер_машины;
      private DataColumn columnОбъём_нм3;
      private DataColumn columnОператор;
      private DataColumn column_Плотность_кг_м3;
      private DataColumn columnПост;
      private DataColumn columnСтоимость_грн;
      private DataColumn columnЦена_грн;
      private DataColumn columnВремя;

      internal ArhiveDataTable()
        : base("Arhive")
      {
        this.InitClass();
      }

      internal ArhiveDataTable(DataTable table)
        : base(table.TableName)
      {
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
        this.DisplayExpression = table.DisplayExpression;
      }

      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      internal DataColumn ДатаColumn
      {
        get
        {
          return this.columnДата;
        }
      }

      internal DataColumn Код_ценыColumn
      {
        get
        {
          return this.columnКод_цены;
        }
      }

      internal DataColumn Номер_машиныColumn
      {
        get
        {
          return this.columnНомер_машины;
        }
      }

      internal DataColumn Объём_нм3Column
      {
        get
        {
          return this.columnОбъём_нм3;
        }
      }

      internal DataColumn ОператорColumn
      {
        get
        {
          return this.columnОператор;
        }
      }

      internal DataColumn _Плотность_кг_м3Column
      {
        get
        {
          return this.column_Плотность_кг_м3;
        }
      }

      internal DataColumn ПостColumn
      {
        get
        {
          return this.columnПост;
        }
      }

      internal DataColumn Стоимость_грнColumn
      {
        get
        {
          return this.columnСтоимость_грн;
        }
      }

      internal DataColumn Цена_грнColumn
      {
        get
        {
          return this.columnЦена_грн;
        }
      }

      internal DataColumn ВремяColumn
      {
        get
        {
          return this.columnВремя;
        }
      }

      public DataSet1.ArhiveRow get_Item(int index)
      {
        return (DataSet1.ArhiveRow) this.Rows[index];
      }

      public event DataSet1.ArhiveRowChangeEventHandler ArhiveRowChanged;

      public event DataSet1.ArhiveRowChangeEventHandler ArhiveRowChanging;

      public event DataSet1.ArhiveRowChangeEventHandler ArhiveRowDeleted;

      public event DataSet1.ArhiveRowChangeEventHandler ArhiveRowDeleting;

      public void AddArhiveRow(DataSet1.ArhiveRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      public DataSet1.ArhiveRow AddArhiveRow(
        DateTime Дата,
        string Код_цены,
        string Номер_машины,
        double Объём_нм3,
        string Оператор,
        double _Плотность_кг_м3,
        short Пост,
        double Стоимость_грн,
        double Цена_грн,
        DateTime Время)
      {
        DataSet1.ArhiveRow arhiveRow = (DataSet1.ArhiveRow) this.NewRow();
        arhiveRow.ItemArray = new object[10]
        {
          (object) Дата,
          (object) Код_цены,
          (object) Номер_машины,
          (object) Объём_нм3,
          (object) Оператор,
          (object) _Плотность_кг_м3,
          (object) Пост,
          (object) Стоимость_грн,
          (object) Цена_грн,
          (object) Время
        };
        this.Rows.Add((DataRow) arhiveRow);
        return arhiveRow;
      }

      public IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      public override DataTable Clone()
      {
        DataSet1.ArhiveDataTable arhiveDataTable = (DataSet1.ArhiveDataTable) base.Clone();
        arhiveDataTable.InitVars();
        return (DataTable) arhiveDataTable;
      }

      protected override DataTable CreateInstance()
      {
        return (DataTable) new DataSet1.ArhiveDataTable();
      }

      internal void InitVars()
      {
        this.columnДата = this.Columns["Дата"];
        this.columnКод_цены = this.Columns["Код цены"];
        this.columnНомер_машины = this.Columns["Номер машины"];
        this.columnОбъём_нм3 = this.Columns["Объём нм3"];
        this.columnОператор = this.Columns["Оператор"];
        this.column_Плотность_кг_м3 = this.Columns["Плотность кг/м3"];
        this.columnПост = this.Columns["Пост"];
        this.columnСтоимость_грн = this.Columns["Стоимость грн"];
        this.columnЦена_грн = this.Columns["Цена грн"];
        this.columnВремя = this.Columns["Время"];
      }

      private void InitClass()
      {
        this.columnДата = new DataColumn("Дата", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnДата);
        this.columnКод_цены = new DataColumn("Код цены", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnКод_цены);
        this.columnНомер_машины = new DataColumn("Номер машины", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnНомер_машины);
        this.columnОбъём_нм3 = new DataColumn("Объём нм3", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnОбъём_нм3);
        this.columnОператор = new DataColumn("Оператор", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnОператор);
        this.column_Плотность_кг_м3 = new DataColumn("Плотность кг/м3", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.column_Плотность_кг_м3);
        this.columnПост = new DataColumn("Пост", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnПост);
        this.columnСтоимость_грн = new DataColumn("Стоимость грн", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnСтоимость_грн);
        this.columnЦена_грн = new DataColumn("Цена грн", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnЦена_грн);
        this.columnВремя = new DataColumn("Время", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnВремя);
      }

      public DataSet1.ArhiveRow NewArhiveRow()
      {
        return (DataSet1.ArhiveRow) this.NewRow();
      }

      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new DataSet1.ArhiveRow(builder);
      }

      protected override Type GetRowType()
      {
        return typeof (DataSet1.ArhiveRow);
      }

      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ArhiveRowChanged == null)
          return;
        this.ArhiveRowChanged((object) this, new DataSet1.ArhiveRowChangeEvent((DataSet1.ArhiveRow) e.Row, e.Action));
      }

      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ArhiveRowChanging == null)
          return;
        this.ArhiveRowChanging((object) this, new DataSet1.ArhiveRowChangeEvent((DataSet1.ArhiveRow) e.Row, e.Action));
      }

      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ArhiveRowDeleted == null)
          return;
        this.ArhiveRowDeleted((object) this, new DataSet1.ArhiveRowChangeEvent((DataSet1.ArhiveRow) e.Row, e.Action));
      }

      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ArhiveRowDeleting == null)
          return;
        this.ArhiveRowDeleting((object) this, new DataSet1.ArhiveRowChangeEvent((DataSet1.ArhiveRow) e.Row, e.Action));
      }

      public void RemoveArhiveRow(DataSet1.ArhiveRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class ArhiveRow : DataRow
    {
      private DataSet1.ArhiveDataTable tableArhive;

      internal ArhiveRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableArhive = (DataSet1.ArhiveDataTable) this.Table;
      }

      public DateTime Дата
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableArhive.ДатаColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.ДатаColumn] = (object) value;
        }
      }

      public string Код_цены
      {
        get
        {
          try
          {
            return (string) this[this.tableArhive.Код_ценыColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.Код_ценыColumn] = (object) value;
        }
      }

      public string Номер_машины
      {
        get
        {
          try
          {
            return (string) this[this.tableArhive.Номер_машиныColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.Номер_машиныColumn] = (object) value;
        }
      }

      public double Объём_нм3
      {
        get
        {
          try
          {
            return (double) this[this.tableArhive.Объём_нм3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.Объём_нм3Column] = (object) value;
        }
      }

      public string Оператор
      {
        get
        {
          try
          {
            return (string) this[this.tableArhive.ОператорColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.ОператорColumn] = (object) value;
        }
      }

      public double _Плотность_кг_м3
      {
        get
        {
          try
          {
            return (double) this[this.tableArhive._Плотность_кг_м3Column];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive._Плотность_кг_м3Column] = (object) value;
        }
      }

      public short Пост
      {
        get
        {
          try
          {
            return (short) this[this.tableArhive.ПостColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.ПостColumn] = (object) value;
        }
      }

      public double Стоимость_грн
      {
        get
        {
          try
          {
            return (double) this[this.tableArhive.Стоимость_грнColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.Стоимость_грнColumn] = (object) value;
        }
      }

      public double Цена_грн
      {
        get
        {
          try
          {
            return (double) this[this.tableArhive.Цена_грнColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.Цена_грнColumn] = (object) value;
        }
      }

      public DateTime Время
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableArhive.ВремяColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableArhive.ВремяColumn] = (object) value;
        }
      }

      public bool IsДатаNull()
      {
        return this.IsNull(this.tableArhive.ДатаColumn);
      }

      public void SetДатаNull()
      {
        this[this.tableArhive.ДатаColumn] = Convert.DBNull;
      }

      public bool IsКод_ценыNull()
      {
        return this.IsNull(this.tableArhive.Код_ценыColumn);
      }

      public void SetКод_ценыNull()
      {
        this[this.tableArhive.Код_ценыColumn] = Convert.DBNull;
      }

      public bool IsНомер_машиныNull()
      {
        return this.IsNull(this.tableArhive.Номер_машиныColumn);
      }

      public void SetНомер_машиныNull()
      {
        this[this.tableArhive.Номер_машиныColumn] = Convert.DBNull;
      }

      public bool IsОбъём_нм3Null()
      {
        return this.IsNull(this.tableArhive.Объём_нм3Column);
      }

      public void SetОбъём_нм3Null()
      {
        this[this.tableArhive.Объём_нм3Column] = Convert.DBNull;
      }

      public bool IsОператорNull()
      {
        return this.IsNull(this.tableArhive.ОператорColumn);
      }

      public void SetОператорNull()
      {
        this[this.tableArhive.ОператорColumn] = Convert.DBNull;
      }

      public bool Is_Плотность_кг_м3Null()
      {
        return this.IsNull(this.tableArhive._Плотность_кг_м3Column);
      }

      public void Set_Плотность_кг_м3Null()
      {
        this[this.tableArhive._Плотность_кг_м3Column] = Convert.DBNull;
      }

      public bool IsПостNull()
      {
        return this.IsNull(this.tableArhive.ПостColumn);
      }

      public void SetПостNull()
      {
        this[this.tableArhive.ПостColumn] = Convert.DBNull;
      }

      public bool IsСтоимость_грнNull()
      {
        return this.IsNull(this.tableArhive.Стоимость_грнColumn);
      }

      public void SetСтоимость_грнNull()
      {
        this[this.tableArhive.Стоимость_грнColumn] = Convert.DBNull;
      }

      public bool IsЦена_грнNull()
      {
        return this.IsNull(this.tableArhive.Цена_грнColumn);
      }

      public void SetЦена_грнNull()
      {
        this[this.tableArhive.Цена_грнColumn] = Convert.DBNull;
      }

      public bool IsВремяNull()
      {
        return this.IsNull(this.tableArhive.ВремяColumn);
      }

      public void SetВремяNull()
      {
        this[this.tableArhive.ВремяColumn] = Convert.DBNull;
      }
    }

    public class ArhiveRowChangeEvent : EventArgs
    {
      private DataSet1.ArhiveRow eventRow;
      private DataRowAction eventAction;

      public ArhiveRowChangeEvent(DataSet1.ArhiveRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      public DataSet1.ArhiveRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }
    }
  }
}
