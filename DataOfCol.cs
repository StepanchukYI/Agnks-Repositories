// Decompiled with JetBrains decompiler
// Type: agnks.DataOfCol
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

namespace agnks
{
  public class DataOfCol
  {
    public bool ini = true;
    public bool AlarmRefresh = false;
    public bool refresh = false;
    public bool NoConnect = false;
    public bool Start = false;
    public int Price = 0;
    public float Volume = 0.0f;
    public float Cost = 0.0f;
    public bool AlarmFlow = false;
    public bool NoGasAlarm = false;
    public bool AlarmLeakage = false;
    public bool CountAlarm = false;
    public bool Test = false;
    public bool CountControl = false;
    public float amount = 0.0f;
    public float Flow = 0.0f;
    public bool PuskPC = false;
    public bool ConnectOut = false;
    public bool klapan = false;
    public float LimitFlowMax = 0.0f;
    public float LimitFlowMin = 0.0f;
    public bool Pusk = false;
    public bool Stop = false;
    public float Temperature = 0.0f;
    public int density = 0;
    public float Vo = 0.0f;
    public float FlowOnEKM = 0.0f;
    public float K_FLOW = 0.0f;
    public float AddMass = 0.0f;
    public double TOTALGAS = 0.0;
    public int gTG1 = 0;
    public int gTG2 = 0;
    public int gTG3 = 0;
    public int gTG4 = 0;
    public int gTG5 = 0;
    public int gTG6 = 0;
    public int gTG7 = 0;
    public int gTG8 = 0;
    public int gTG9 = 0;
    public int gTG10 = 0;
    public int gTG11 = 0;
    public int gTG12 = 0;
    private string _car = "";
    public int sleep = 0;
    public int TESTFRQ = 0;
    public int LIGHTDOWN = 0;
    private bool OldStart = false;
    private int OldPrice = 0;
    private float OldVolume = 0.0f;
    private float OldCost = 0.0f;
    private bool OldAlarmFlow = false;
    private bool OldNoGasAlarm = false;
    private bool OldAlarmLeakage = false;
    private bool OldCountAlarm = false;
    private bool OldTest = false;
    private bool OldCountControl = false;
    private float Oldamount = 0.0f;
    private float OldFlow = 0.0f;
    private bool OldPuskPC = false;
    private bool OldConnectOut = false;
    private bool Oldklapan = false;
    private float OldLimitFlowMax = 0.0f;
    private float OldLimitFlowMin = 0.0f;
    private bool OldPusk = false;
    private bool OldStop = false;
    private float OldTemperature = 0.0f;
    private int Olddensity = 0;
    private bool OldEkkaGun = false;
    private float OldVo = 0.0f;
    private bool OldStopPC = false;
    public int Oldsleep = 0;
    public int OldTESTFRQ = 0;
    public int OldLIGHTDOWN = 0;
    public float OldFlowOnEKM = 0.0f;
    public double OldTOTALGAS = 0.0;
    public int OldgTG1 = 0;
    public int OldgTG2 = 0;
    public int OldgTG3 = 0;
    public int OldgTG4 = 0;
    public int OldgTG5 = 0;
    public int OldgTG6 = 0;
    public int OldgTG7 = 0;
    public int OldgTG8 = 0;
    public int OldgTG9 = 0;
    public int OldgTG10 = 0;
    public int OldgTG11 = 0;
    public int OldgTG12 = 0;
    public int handlesStopPC;
    public int handlesPuskPC;
    public int handlesPrice;
    public int handlesAmount;
    public int handlesLimitFlowMax;
    public int handlesLimitFlowMin;
    public int handlesVo;
    public int handlesResetAlarms;
    public int handlesONOFFINDICAT;
    public int handlesDoubleRule;
    public int handlesdensity;
    public int handlesTest;
    public int handlesControl;
    public int handlesSleep;
    public int handlesTESTFRQ;
    public int handlesLIGHTDOWN;
    public int handlesComAsEkka;
    public int handlesSaveCountAlarm;
    public int handlesSaveAlarmFlow;
    public int handlesSaveNoGasAlarm;
    public int handlesSaveAlarmLeakage;
    public int handlesFlowOnEKM;
    public int handlesUpDoze;
    public int handlesShowOver;
    public int handlesK_FLOW;
    public int handlesAddMass;
    public int handlesEKM;
    public int handlesTOTALGAS;
    public int handlesgTG1;
    public int handlesgTG2;
    public int handlesgTG3;
    public int handlesgTG4;
    public int handlesgTG5;
    public int handlesgTG6;
    public int handlesgTG7;
    public int handlesgTG8;
    public int handlesgTG9;
    public int handlesgTG10;
    public int handlesgTG11;
    public int handlesgTG12;
    public bool EkkaGun;
    public bool StopPC;
    public bool ShowOver;
    public bool EKM;
    public bool ResetAlarms;
    public bool ONOFFINDICAT;
    public bool DoubleRule;
    public bool ComAsEkka;
    public bool OldResetAlarms;
    public bool OldONOFFINDICAT;
    public bool OldDoubleRule;
    public bool OldEKM;

    public event ChangeValue OnChangeValue;

    public string car
    {
      set
      {
        this._car = value;
      }
      get
      {
        if (this._car != "")
          return this._car;
        return "(нет)";
      }
    }

    public void HappenChanged()
    {
      int num = 0;
      if (this.Oldklapan != this.klapan || this.ini || (this.OldStart != this.Start || this.AlarmRefresh))
      {
        this.OnChangeValue((object) this, new EventInfo("Startklapan", (object) this.Start));
        this.Oldklapan = this.klapan;
        this.OldStart = this.Start;
      }
      if (this.OldPrice != this.Price || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Price", (object) this.Price));
        this.OldPrice = this.Price;
      }
      if ((double) this.OldVolume != (double) this.Volume || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Volume", (object) this.Volume));
        this.OldVolume = this.Volume;
      }
      if ((double) this.OldCost != (double) this.Cost || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Cost", (object) this.Cost));
        this.OldCost = this.Cost;
      }
      if (this.OldAlarmFlow != this.AlarmFlow || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("AlarmFlow", (object) this.AlarmFlow));
        this.OldAlarmFlow = this.AlarmFlow;
      }
      if (this.OldNoGasAlarm != this.NoGasAlarm || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("NoGasAlarm", (object) this.NoGasAlarm));
        this.OldNoGasAlarm = this.NoGasAlarm;
      }
      if (this.OldAlarmLeakage != this.AlarmLeakage || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("AlarmLeakage", (object) this.AlarmLeakage));
        this.OldAlarmLeakage = this.AlarmLeakage;
      }
      if (this.OldCountAlarm != this.CountAlarm || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("CountAlarm", (object) this.CountAlarm));
        this.OldCountAlarm = this.CountAlarm;
      }
      if (this.OldTest != this.Test || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Test", (object) this.Test));
        this.OldTest = this.Test;
      }
      if (this.OldCountControl != this.CountControl || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("CountControl", (object) this.CountControl));
        this.OldCountControl = this.CountControl;
      }
      if ((double) this.Oldamount != (double) this.amount || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("amount", (object) this.amount));
        this.Oldamount = this.amount;
      }
      if ((double) this.OldFlow != (double) this.Flow || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Flow", (object) this.Flow));
        this.OldFlow = this.Flow;
      }
      if (this.OldPuskPC != this.PuskPC || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("PuskPC", (object) this.PuskPC));
        this.OldPuskPC = this.PuskPC;
      }
      if (this.OldConnectOut != this.ConnectOut || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("ConnectOut", (object) this.ConnectOut));
        this.OldConnectOut = this.ConnectOut;
      }
      if ((double) this.OldLimitFlowMax != (double) this.LimitFlowMax || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("LimitFlowMax", (object) this.LimitFlowMax));
        this.OldLimitFlowMax = this.LimitFlowMax;
      }
      if ((double) this.OldLimitFlowMin != (double) this.LimitFlowMin || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("LimitFlowMin", (object) this.LimitFlowMin));
        this.OldLimitFlowMin = this.LimitFlowMin;
      }
      if (this.OldPusk != this.Pusk || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Pusk", (object) this.Pusk));
        this.OldPusk = this.Pusk;
      }
      if (this.OldStop != this.Stop || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Stop", (object) this.Stop));
        this.OldStop = this.Stop;
      }
      if ((double) this.OldTemperature != (double) this.Temperature || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Temperature", (object) this.Temperature));
        this.OldTemperature = this.Temperature;
      }
      if (this.Olddensity != this.density || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("density", (object) this.density));
        this.Olddensity = this.density;
      }
      if (this.OldEkkaGun != this.EkkaGun || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("EkkaGun", (object) this.EkkaGun));
        this.OldEkkaGun = this.EkkaGun;
      }
      if ((double) this.OldVo != (double) this.Vo || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("Vo", (object) this.Vo));
        this.OldVo = this.Vo;
      }
      if (this.OldStopPC != this.StopPC || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("StopPC", (object) this.StopPC));
        this.OldStopPC = this.StopPC;
      }
      if (this.OldEKM != this.EKM || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("EKM", (object) this.EKM));
        this.OldEKM = this.EKM;
      }
      if (this.Oldsleep != this.sleep || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("sleep", (object) this.sleep));
        this.Oldsleep = this.sleep;
      }
      if (this.OldTESTFRQ != this.TESTFRQ || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("TESTFRQ", (object) this.TESTFRQ));
        this.OldTESTFRQ = this.TESTFRQ;
      }
      if (this.OldLIGHTDOWN != this.LIGHTDOWN || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("LIGHTDOWN", (object) this.LIGHTDOWN));
        this.OldLIGHTDOWN = this.LIGHTDOWN;
      }
      if ((double) this.OldFlowOnEKM != (double) this.FlowOnEKM || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("FlowOnEKM", (object) this.FlowOnEKM));
        this.OldFlowOnEKM = this.FlowOnEKM;
      }
      if (this.OldgTG1 != this.gTG1 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG1", (object) this.gTG1));
        this.OldgTG1 = this.gTG1;
        num = 1;
      }
      if (this.OldgTG2 != this.gTG2 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG2", (object) this.gTG2));
        this.OldgTG2 = this.gTG2;
        num = 1;
      }
      if (this.OldgTG3 != this.gTG3 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG3", (object) this.gTG3));
        this.OldgTG3 = this.gTG3;
        num = 1;
      }
      if (this.OldgTG4 != this.gTG4 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG4", (object) this.gTG4));
        this.OldgTG4 = this.gTG4;
        num = 1;
      }
      if (this.OldgTG5 != this.gTG5 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG5", (object) this.gTG5));
        this.OldgTG5 = this.gTG5;
        num = 1;
      }
      if (this.OldgTG6 != this.gTG6 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG6", (object) this.gTG6));
        this.OldgTG6 = this.gTG6;
        num = 1;
      }
      if (this.OldgTG7 != this.gTG7 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG7", (object) this.gTG7));
        this.OldgTG7 = this.gTG7;
        num = 1;
      }
      if (this.OldgTG8 != this.gTG8 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG8", (object) this.gTG8));
        this.OldgTG8 = this.gTG8;
        num = 1;
      }
      if (this.OldgTG9 != this.gTG9 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG9", (object) this.gTG9));
        this.OldgTG9 = this.gTG9;
        num = 1;
      }
      if (this.OldgTG10 != this.gTG10 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG10", (object) this.gTG10));
        this.OldgTG10 = this.gTG10;
        num = 1;
      }
      if (this.OldgTG11 != this.gTG11 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG11", (object) this.gTG11));
        this.OldgTG11 = this.gTG11;
        num = 1;
      }
      if (this.OldgTG12 != this.gTG12 || this.ini || this.AlarmRefresh)
      {
        this.OnChangeValue((object) this, new EventInfo("gTG12", (object) this.gTG12));
        this.OldgTG12 = this.gTG12;
        num = 1;
      }
      if (num == 1 || this.ini || this.AlarmRefresh)
      {
        this.TOTALGAS = (double) this.gTG1 * 0.01 + (double) this.gTG2 * 0.1 + (double) this.gTG3 + (double) (this.gTG4 * 10) + (double) (this.gTG5 * 100) + (double) (this.gTG6 * 1000) + (double) (this.gTG7 * 10000) + (double) (this.gTG8 * 100000) + (double) (this.gTG9 * 1000000) + (double) (this.gTG10 * 10000000) + (double) (this.gTG11 * 100000000) + (double) (this.gTG12 * 1000000000);
        this.OnChangeValue((object) this, new EventInfo("TOTALGAS", (object) this.TOTALGAS));
        this.OldTOTALGAS = this.TOTALGAS;
      }
      this.ini = false;
      this.AlarmRefresh = false;
    }
  }
}
