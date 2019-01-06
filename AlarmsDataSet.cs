// Decompiled with JetBrains decompiler
// Type: agnks.AlarmsDataSet
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
  public class AlarmsDataSet : DataSet
  {
    private AlarmsDataSet.AlarmsDataTable tableAlarms;

    public AlarmsDataSet()
    {
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      this.Tables.CollectionChanged += changeEventHandler;
      this.Relations.CollectionChanged += changeEventHandler;
    }

    protected AlarmsDataSet(SerializationInfo info, StreamingContext context)
    {
      string s = (string) info.GetValue("XmlSchema", typeof (string));
      if (s != null)
      {
        DataSet dataSet = new DataSet();
        dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        if (dataSet.Tables[nameof (Alarms)] != null)
          this.Tables.Add((DataTable) new AlarmsDataSet.AlarmsDataTable(dataSet.Tables[nameof (Alarms)]));
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

    public AlarmsDataSet.AlarmsDataTable Alarms
    {
      get
      {
        return this.tableAlarms;
      }
    }

    public override DataSet Clone()
    {
      AlarmsDataSet alarmsDataSet = (AlarmsDataSet) base.Clone();
      alarmsDataSet.InitVars();
      return (DataSet) alarmsDataSet;
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
      if (dataSet.Tables["Alarms"] != null)
        this.Tables.Add((DataTable) new AlarmsDataSet.AlarmsDataTable(dataSet.Tables["Alarms"]));
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
      this.tableAlarms = (AlarmsDataSet.AlarmsDataTable) this.Tables["Alarms"];
      if (this.tableAlarms == null)
        return;
      this.tableAlarms.InitVars();
    }

    private void InitClass()
    {
      this.DataSetName = nameof (AlarmsDataSet);
      this.Prefix = "";
      this.Namespace = "http://www.tempuri.org/AlarmsDataSet.xsd";
      this.Locale = new CultureInfo("ru-RU");
      this.CaseSensitive = false;
      this.EnforceConstraints = true;
      this.tableAlarms = new AlarmsDataSet.AlarmsDataTable();
      this.Tables.Add((DataTable) this.tableAlarms);
    }

    private bool ShouldSerializeAlarms()
    {
      return false;
    }

    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    public delegate void AlarmsRowChangeEventHandler(
      object sender,
      AlarmsDataSet.AlarmsRowChangeEvent e);

    public class AlarmsDataTable : DataTable, IEnumerable
    {
      private DataColumn columnАвария;
      private DataColumn columnДата;
      private DataColumn columnОператор;
      private DataColumn columnПодтверждение;
      private DataColumn columnПост;

      internal AlarmsDataTable()
        : base("Alarms")
      {
        this.InitClass();
      }

      internal AlarmsDataTable(DataTable table)
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

      internal DataColumn АварияColumn
      {
        get
        {
          return this.columnАвария;
        }
      }

      internal DataColumn ДатаColumn
      {
        get
        {
          return this.columnДата;
        }
      }

      internal DataColumn ОператорColumn
      {
        get
        {
          return this.columnОператор;
        }
      }

      internal DataColumn ПодтверждениеColumn
      {
        get
        {
          return this.columnПодтверждение;
        }
      }

      internal DataColumn ПостColumn
      {
        get
        {
          return this.columnПост;
        }
      }

      public AlarmsDataSet.AlarmsRow get_Item(int index)
      {
        return (AlarmsDataSet.AlarmsRow) this.Rows[index];
      }

      public event AlarmsDataSet.AlarmsRowChangeEventHandler AlarmsRowChanged;

      public event AlarmsDataSet.AlarmsRowChangeEventHandler AlarmsRowChanging;

      public event AlarmsDataSet.AlarmsRowChangeEventHandler AlarmsRowDeleted;

      public event AlarmsDataSet.AlarmsRowChangeEventHandler AlarmsRowDeleting;

      public void AddAlarmsRow(AlarmsDataSet.AlarmsRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      public AlarmsDataSet.AlarmsRow AddAlarmsRow(
        string Авария,
        DateTime Дата,
        string Оператор,
        string Подтверждение,
        string Пост)
      {
        AlarmsDataSet.AlarmsRow alarmsRow = (AlarmsDataSet.AlarmsRow) this.NewRow();
        alarmsRow.ItemArray = new object[5]
        {
          (object) Авария,
          (object) Дата,
          (object) Оператор,
          (object) Подтверждение,
          (object) Пост
        };
        this.Rows.Add((DataRow) alarmsRow);
        return alarmsRow;
      }

      public IEnumerator GetEnumerator()
      {
        return this.Rows.GetEnumerator();
      }

      public override DataTable Clone()
      {
        AlarmsDataSet.AlarmsDataTable alarmsDataTable = (AlarmsDataSet.AlarmsDataTable) base.Clone();
        alarmsDataTable.InitVars();
        return (DataTable) alarmsDataTable;
      }

      protected override DataTable CreateInstance()
      {
        return (DataTable) new AlarmsDataSet.AlarmsDataTable();
      }

      internal void InitVars()
      {
        this.columnАвария = this.Columns["Авария"];
        this.columnДата = this.Columns["Дата"];
        this.columnОператор = this.Columns["Оператор"];
        this.columnПодтверждение = this.Columns["Подтверждение"];
        this.columnПост = this.Columns["Пост"];
      }

      private void InitClass()
      {
        this.columnАвария = new DataColumn("Авария", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnАвария);
        this.columnДата = new DataColumn("Дата", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnДата);
        this.columnОператор = new DataColumn("Оператор", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnОператор);
        this.columnПодтверждение = new DataColumn("Подтверждение", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnПодтверждение);
        this.columnПост = new DataColumn("Пост", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnПост);
      }

      public AlarmsDataSet.AlarmsRow NewAlarmsRow()
      {
        return (AlarmsDataSet.AlarmsRow) this.NewRow();
      }

      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new AlarmsDataSet.AlarmsRow(builder);
      }

      protected override Type GetRowType()
      {
        return typeof (AlarmsDataSet.AlarmsRow);
      }

      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.AlarmsRowChanged == null)
          return;
        this.AlarmsRowChanged((object) this, new AlarmsDataSet.AlarmsRowChangeEvent((AlarmsDataSet.AlarmsRow) e.Row, e.Action));
      }

      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.AlarmsRowChanging == null)
          return;
        this.AlarmsRowChanging((object) this, new AlarmsDataSet.AlarmsRowChangeEvent((AlarmsDataSet.AlarmsRow) e.Row, e.Action));
      }

      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.AlarmsRowDeleted == null)
          return;
        this.AlarmsRowDeleted((object) this, new AlarmsDataSet.AlarmsRowChangeEvent((AlarmsDataSet.AlarmsRow) e.Row, e.Action));
      }

      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.AlarmsRowDeleting == null)
          return;
        this.AlarmsRowDeleting((object) this, new AlarmsDataSet.AlarmsRowChangeEvent((AlarmsDataSet.AlarmsRow) e.Row, e.Action));
      }

      public void RemoveAlarmsRow(AlarmsDataSet.AlarmsRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class AlarmsRow : DataRow
    {
      private AlarmsDataSet.AlarmsDataTable tableAlarms;

      internal AlarmsRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableAlarms = (AlarmsDataSet.AlarmsDataTable) this.Table;
      }

      public string Авария
      {
        get
        {
          try
          {
            return (string) this[this.tableAlarms.АварияColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableAlarms.АварияColumn] = (object) value;
        }
      }

      public DateTime Дата
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableAlarms.ДатаColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableAlarms.ДатаColumn] = (object) value;
        }
      }

      public string Оператор
      {
        get
        {
          try
          {
            return (string) this[this.tableAlarms.ОператорColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableAlarms.ОператорColumn] = (object) value;
        }
      }

      public string Подтверждение
      {
        get
        {
          try
          {
            return (string) this[this.tableAlarms.ПодтверждениеColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableAlarms.ПодтверждениеColumn] = (object) value;
        }
      }

      public string Пост
      {
        get
        {
          try
          {
            return (string) this[this.tableAlarms.ПостColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("Cannot get value because it is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableAlarms.ПостColumn] = (object) value;
        }
      }

      public bool IsАварияNull()
      {
        return this.IsNull(this.tableAlarms.АварияColumn);
      }

      public void SetАварияNull()
      {
        this[this.tableAlarms.АварияColumn] = Convert.DBNull;
      }

      public bool IsДатаNull()
      {
        return this.IsNull(this.tableAlarms.ДатаColumn);
      }

      public void SetДатаNull()
      {
        this[this.tableAlarms.ДатаColumn] = Convert.DBNull;
      }

      public bool IsОператорNull()
      {
        return this.IsNull(this.tableAlarms.ОператорColumn);
      }

      public void SetОператорNull()
      {
        this[this.tableAlarms.ОператорColumn] = Convert.DBNull;
      }

      public bool IsПодтверждениеNull()
      {
        return this.IsNull(this.tableAlarms.ПодтверждениеColumn);
      }

      public void SetПодтверждениеNull()
      {
        this[this.tableAlarms.ПодтверждениеColumn] = Convert.DBNull;
      }

      public bool IsПостNull()
      {
        return this.IsNull(this.tableAlarms.ПостColumn);
      }

      public void SetПостNull()
      {
        this[this.tableAlarms.ПостColumn] = Convert.DBNull;
      }
    }

    public class AlarmsRowChangeEvent : EventArgs
    {
      private AlarmsDataSet.AlarmsRow eventRow;
      private DataRowAction eventAction;

      public AlarmsRowChangeEvent(AlarmsDataSet.AlarmsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      public AlarmsDataSet.AlarmsRow Row
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
