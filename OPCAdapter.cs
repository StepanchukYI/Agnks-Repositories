// Decompiled with JetBrains decompiler
// Type: agnks.OPCAdapter
// Assembly: agnks, Version=1.0.2228.24035, Culture=neutral, PublicKeyToken=null
// MVID: B3823D92-49A0-4E5B-9B21-6679BE501FA4
// Assembly location: C:\AGNKS1\AGNKS\Program\agnks.exe

using OPC.Common;
using OPC.Data;
using OPC.Data.Interface;
using System.Runtime.InteropServices;
using System.Threading;

namespace agnks
{
  public class OPCAdapter
  {
    private OPCItemDef[] itemDefs = new OPCItemDef[50];
    private int[] handlesSrv = new int[50];
    private bool OutThreadTags = true;
    public DataOfCol m_Data1;
    public string NameGroup;
    public string NameItems;
    private int[] aE;
    private OpcServer theSrv;
    private OpcGroup theGrp;
    private ThreadStart pThreadStart;
    private Thread pThread;

    public void CreateConnect()
    {
      this.theSrv = new OpcServer();
      this.theSrv.Connect("Fastwel.plcnetopc.1");
      Thread.Sleep(2000);
      this.theGrp = this.theSrv.AddGroup(this.NameGroup, false, 900);
      this.itemDefs[0] = new OPCItemDef(this.NameItems + "EkkaStart", true, 1111, VarEnum.VT_EMPTY);
      this.itemDefs[1] = new OPCItemDef(this.NameItems + "cPrice", true, 2222, VarEnum.VT_EMPTY);
      this.itemDefs[2] = new OPCItemDef(this.NameItems + "pVolume", true, 3333, VarEnum.VT_EMPTY);
      this.itemDefs[3] = new OPCItemDef(this.NameItems + "saveCountAlarm", true, 4444, VarEnum.VT_EMPTY);
      this.itemDefs[4] = new OPCItemDef(this.NameItems + "pCost", true, 5555, VarEnum.VT_EMPTY);
      this.itemDefs[5] = new OPCItemDef(this.NameItems + "TEST", true, 6666, VarEnum.VT_EMPTY);
      this.itemDefs[6] = new OPCItemDef(this.NameItems + "CountControl", true, 7777, VarEnum.VT_EMPTY);
      this.itemDefs[7] = new OPCItemDef(this.NameItems + "EkkaGun", true, 8888, VarEnum.VT_EMPTY);
      this.itemDefs[8] = new OPCItemDef(this.NameItems + "saveAlarmFlow", true, 9999, VarEnum.VT_EMPTY);
      this.itemDefs[9] = new OPCItemDef(this.NameItems + "saveNoGasAlarm", true, 9910, VarEnum.VT_EMPTY);
      this.itemDefs[10] = new OPCItemDef(this.NameItems + "saveAlarmLeakage", true, 9911, VarEnum.VT_EMPTY);
      this.itemDefs[11] = new OPCItemDef(this.NameItems + "amount", true, 9912, VarEnum.VT_EMPTY);
      this.itemDefs[12] = new OPCItemDef(this.NameItems + "Flow", true, 9913, VarEnum.VT_EMPTY);
      this.itemDefs[13] = new OPCItemDef(this.NameItems + "PuskPC", true, 9914, VarEnum.VT_EMPTY);
      this.itemDefs[14] = new OPCItemDef(this.NameItems + "ConnectOut", true, 9915, VarEnum.VT_EMPTY);
      this.itemDefs[15] = new OPCItemDef(this.NameItems + "klapan", true, 9916, VarEnum.VT_EMPTY);
      this.itemDefs[16] = new OPCItemDef(this.NameItems + "LimitFlowMax", true, 9917, VarEnum.VT_EMPTY);
      this.itemDefs[17] = new OPCItemDef(this.NameItems + "LimitFlowMin", true, 9918, VarEnum.VT_EMPTY);
      this.itemDefs[18] = new OPCItemDef(this.NameItems + "Pusk", true, 9919, VarEnum.VT_EMPTY);
      this.itemDefs[19] = new OPCItemDef(this.NameItems + "Stop", true, 9920, VarEnum.VT_EMPTY);
      this.itemDefs[20] = new OPCItemDef(this.NameItems + "temperature", true, 9921, VarEnum.VT_EMPTY);
      this.itemDefs[21] = new OPCItemDef(this.NameItems + "cdensity", true, 9922, VarEnum.VT_EMPTY);
      this.itemDefs[22] = new OPCItemDef(this.NameItems + "Vo", true, 9923, VarEnum.VT_EMPTY);
      this.itemDefs[23] = new OPCItemDef(this.NameItems + "StopPC", true, 9924, VarEnum.VT_EMPTY);
      this.itemDefs[24] = new OPCItemDef(this.NameItems + "ResetAlarms", true, 9925, VarEnum.VT_EMPTY);
      this.itemDefs[25] = new OPCItemDef(this.NameItems + "ONOFFINDIKAT", true, 9926, VarEnum.VT_EMPTY);
      this.itemDefs[26] = new OPCItemDef(this.NameItems + "DoubleRule", true, 9927, VarEnum.VT_EMPTY);
      this.itemDefs[27] = new OPCItemDef(this.NameItems + "sleep", true, 9928, VarEnum.VT_EMPTY);
      this.itemDefs[28] = new OPCItemDef(this.NameItems + "TESTFRQ", true, 9929, VarEnum.VT_EMPTY);
      this.itemDefs[29] = new OPCItemDef(this.NameItems + "LIGHTDOWN", true, 9930, VarEnum.VT_EMPTY);
      this.itemDefs[30] = new OPCItemDef(this.NameItems + "ComAsEkka", true, 9931, VarEnum.VT_EMPTY);
      this.itemDefs[31] = new OPCItemDef(this.NameItems + "FlowOnEKM", true, 9932, VarEnum.VT_EMPTY);
      this.itemDefs[32] = new OPCItemDef(this.NameItems + "UpDoze", true, 9933, VarEnum.VT_EMPTY);
      this.itemDefs[33] = new OPCItemDef(this.NameItems + "ShowOver", true, 9934, VarEnum.VT_EMPTY);
      this.itemDefs[34] = new OPCItemDef(this.NameItems + "K_FLOW", true, 9935, VarEnum.VT_EMPTY);
      this.itemDefs[35] = new OPCItemDef(this.NameItems + "AddMass", true, 9936, VarEnum.VT_EMPTY);
      this.itemDefs[36] = new OPCItemDef(this.NameItems + "EKM", true, 9937, VarEnum.VT_EMPTY);
      this.itemDefs[37] = new OPCItemDef(this.NameItems + "TOTALGAS", true, 9938, VarEnum.VT_EMPTY);
      this.itemDefs[38] = new OPCItemDef(this.NameItems + "gTG1", true, 9939, VarEnum.VT_EMPTY);
      this.itemDefs[39] = new OPCItemDef(this.NameItems + "gTG2", true, 9940, VarEnum.VT_EMPTY);
      this.itemDefs[40] = new OPCItemDef(this.NameItems + "gTG3", true, 9941, VarEnum.VT_EMPTY);
      this.itemDefs[41] = new OPCItemDef(this.NameItems + "gTG4", true, 9942, VarEnum.VT_EMPTY);
      this.itemDefs[42] = new OPCItemDef(this.NameItems + "gTG5", true, 9943, VarEnum.VT_EMPTY);
      this.itemDefs[43] = new OPCItemDef(this.NameItems + "gTG6", true, 9944, VarEnum.VT_EMPTY);
      this.itemDefs[44] = new OPCItemDef(this.NameItems + "gTG7", true, 9945, VarEnum.VT_EMPTY);
      this.itemDefs[45] = new OPCItemDef(this.NameItems + "gTG8", true, 9946, VarEnum.VT_EMPTY);
      this.itemDefs[46] = new OPCItemDef(this.NameItems + "gTG9", true, 9947, VarEnum.VT_EMPTY);
      this.itemDefs[47] = new OPCItemDef(this.NameItems + "gTG10", true, 9948, VarEnum.VT_EMPTY);
      this.itemDefs[48] = new OPCItemDef(this.NameItems + "gTG11", true, 9949, VarEnum.VT_EMPTY);
      this.itemDefs[49] = new OPCItemDef(this.NameItems + "gTG12", true, 9950, VarEnum.VT_EMPTY);
      OPCItemResult[] arrRes;
      this.theGrp.AddItems(this.itemDefs, out arrRes);
      this.handlesSrv[0] = arrRes[0].HandleServer;
      this.handlesSrv[1] = arrRes[1].HandleServer;
      this.handlesSrv[2] = arrRes[2].HandleServer;
      this.handlesSrv[3] = arrRes[3].HandleServer;
      this.handlesSrv[4] = arrRes[4].HandleServer;
      this.handlesSrv[5] = arrRes[5].HandleServer;
      this.handlesSrv[6] = arrRes[6].HandleServer;
      this.handlesSrv[7] = arrRes[7].HandleServer;
      this.handlesSrv[8] = arrRes[8].HandleServer;
      this.handlesSrv[9] = arrRes[9].HandleServer;
      this.handlesSrv[10] = arrRes[10].HandleServer;
      this.handlesSrv[11] = arrRes[11].HandleServer;
      this.handlesSrv[12] = arrRes[12].HandleServer;
      this.handlesSrv[13] = arrRes[13].HandleServer;
      this.handlesSrv[14] = arrRes[14].HandleServer;
      this.handlesSrv[15] = arrRes[15].HandleServer;
      this.handlesSrv[16] = arrRes[16].HandleServer;
      this.handlesSrv[17] = arrRes[17].HandleServer;
      this.handlesSrv[18] = arrRes[18].HandleServer;
      this.handlesSrv[19] = arrRes[19].HandleServer;
      this.handlesSrv[20] = arrRes[20].HandleServer;
      this.handlesSrv[21] = arrRes[21].HandleServer;
      this.handlesSrv[22] = arrRes[22].HandleServer;
      this.handlesSrv[23] = arrRes[23].HandleServer;
      this.handlesSrv[24] = arrRes[24].HandleServer;
      this.handlesSrv[25] = arrRes[25].HandleServer;
      this.handlesSrv[26] = arrRes[26].HandleServer;
      this.handlesSrv[27] = arrRes[27].HandleServer;
      this.handlesSrv[28] = arrRes[28].HandleServer;
      this.handlesSrv[29] = arrRes[29].HandleServer;
      this.handlesSrv[30] = arrRes[30].HandleServer;
      this.handlesSrv[31] = arrRes[31].HandleServer;
      this.handlesSrv[32] = arrRes[32].HandleServer;
      this.handlesSrv[33] = arrRes[33].HandleServer;
      this.handlesSrv[34] = arrRes[34].HandleServer;
      this.handlesSrv[35] = arrRes[35].HandleServer;
      this.handlesSrv[36] = arrRes[36].HandleServer;
      this.handlesSrv[37] = arrRes[37].HandleServer;
      this.handlesSrv[38] = arrRes[38].HandleServer;
      this.handlesSrv[39] = arrRes[39].HandleServer;
      this.handlesSrv[40] = arrRes[40].HandleServer;
      this.handlesSrv[41] = arrRes[41].HandleServer;
      this.handlesSrv[42] = arrRes[42].HandleServer;
      this.handlesSrv[43] = arrRes[43].HandleServer;
      this.handlesSrv[44] = arrRes[44].HandleServer;
      this.handlesSrv[45] = arrRes[45].HandleServer;
      this.handlesSrv[46] = arrRes[46].HandleServer;
      this.handlesSrv[47] = arrRes[47].HandleServer;
      this.handlesSrv[48] = arrRes[48].HandleServer;
      this.handlesSrv[49] = arrRes[49].HandleServer;
      this.theGrp.SetEnable(true);
      this.theGrp.Active = true;
    }

    public void StartThreadOPC()
    {
      this.pThreadStart = new ThreadStart(this.threadtags);
      this.pThread = new Thread(this.pThreadStart);
      this.pThread.Start();
    }

    public void FreeOPCAdapter()
    {
      this.OutThreadTags = false;
    }

    public void WriteTag(object[] itemValues, int[] _handlesSrv)
    {
      int cancelID;
      int[] arrErr;
      this.theGrp.Write(_handlesSrv, itemValues, 99887766, out cancelID, out arrErr);
    }

    public void WriteHandlers()
    {
      this.m_Data1.handlesAmount = this.handlesSrv[11];
      this.m_Data1.handlesdensity = this.handlesSrv[21];
      this.m_Data1.handlesDoubleRule = this.handlesSrv[26];
      this.m_Data1.handlesLimitFlowMax = this.handlesSrv[16];
      this.m_Data1.handlesLimitFlowMin = this.handlesSrv[17];
      this.m_Data1.handlesONOFFINDICAT = this.handlesSrv[25];
      this.m_Data1.handlesPrice = this.handlesSrv[1];
      this.m_Data1.handlesPuskPC = this.handlesSrv[13];
      this.m_Data1.handlesResetAlarms = this.handlesSrv[24];
      this.m_Data1.handlesStopPC = this.handlesSrv[23];
      this.m_Data1.handlesVo = this.handlesSrv[22];
      this.m_Data1.handlesTest = this.handlesSrv[5];
      this.m_Data1.handlesControl = this.handlesSrv[6];
      this.m_Data1.handlesSleep = this.handlesSrv[27];
      this.m_Data1.handlesTESTFRQ = this.handlesSrv[28];
      this.m_Data1.handlesLIGHTDOWN = this.handlesSrv[29];
      this.m_Data1.handlesComAsEkka = this.handlesSrv[30];
      this.m_Data1.handlesSaveAlarmFlow = this.handlesSrv[8];
      this.m_Data1.handlesSaveAlarmLeakage = this.handlesSrv[10];
      this.m_Data1.handlesSaveCountAlarm = this.handlesSrv[3];
      this.m_Data1.handlesSaveNoGasAlarm = this.handlesSrv[9];
      this.m_Data1.handlesFlowOnEKM = this.handlesSrv[31];
      this.m_Data1.handlesUpDoze = this.handlesSrv[32];
      this.m_Data1.handlesShowOver = this.handlesSrv[33];
      this.m_Data1.handlesK_FLOW = this.handlesSrv[34];
      this.m_Data1.handlesAddMass = this.handlesSrv[35];
      this.m_Data1.handlesEKM = this.handlesSrv[36];
      this.m_Data1.handlesTOTALGAS = this.handlesSrv[37];
      this.m_Data1.handlesgTG1 = this.handlesSrv[38];
      this.m_Data1.handlesgTG2 = this.handlesSrv[39];
      this.m_Data1.handlesgTG3 = this.handlesSrv[40];
      this.m_Data1.handlesgTG4 = this.handlesSrv[41];
      this.m_Data1.handlesgTG5 = this.handlesSrv[42];
      this.m_Data1.handlesgTG6 = this.handlesSrv[43];
      this.m_Data1.handlesgTG7 = this.handlesSrv[44];
      this.m_Data1.handlesgTG8 = this.handlesSrv[45];
      this.m_Data1.handlesgTG9 = this.handlesSrv[46];
      this.m_Data1.handlesgTG10 = this.handlesSrv[47];
      this.m_Data1.handlesgTG11 = this.handlesSrv[48];
      this.m_Data1.handlesgTG12 = this.handlesSrv[49];
    }

    private void threadtags()
    {
      bool flag = false;
      while (this.OutThreadTags)
      {
        OPCItemState[] arrStat;
        if (this.theGrp.Read(OPCDATASOURCE.OPC_DS_CACHE, this.handlesSrv, out arrStat))
        {
          foreach (OPCItemState opcItemState in arrStat)
          {
            if (HRESULTS.Succeeded(opcItemState.Error))
            {
              flag = true;
              if (opcItemState.HandleClient == 1111)
                this.m_Data1.Start = !(bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 2222)
                this.m_Data1.Price = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 3333)
                this.m_Data1.Volume = this.Podgon((float) opcItemState.DataValue);
              if (opcItemState.HandleClient == 4444)
                this.m_Data1.CountAlarm = !(bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 5555)
                this.m_Data1.Cost = this.Podgon((float) opcItemState.DataValue);
              if (opcItemState.HandleClient == 6666)
                this.m_Data1.Test = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 7777)
                this.m_Data1.CountControl = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 8888)
                this.m_Data1.EkkaGun = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9999)
                this.m_Data1.AlarmFlow = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9910)
                this.m_Data1.NoGasAlarm = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9911)
                this.m_Data1.AlarmLeakage = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9912)
                this.m_Data1.amount = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9913)
                this.m_Data1.Flow = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9915)
                this.m_Data1.ConnectOut = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9916)
                this.m_Data1.klapan = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9917)
                this.m_Data1.LimitFlowMax = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9918)
                this.m_Data1.LimitFlowMin = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9919)
                this.m_Data1.Pusk = !(bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9920)
                this.m_Data1.Stop = !(bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9921)
                this.m_Data1.Temperature = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9922)
                this.m_Data1.density = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9923)
                this.m_Data1.Vo = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9924)
                this.m_Data1.StopPC = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9925)
                this.m_Data1.ResetAlarms = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9926)
                this.m_Data1.ONOFFINDICAT = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9927)
                this.m_Data1.DoubleRule = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9928)
                this.m_Data1.sleep = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9929)
                this.m_Data1.TESTFRQ = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9930)
                this.m_Data1.LIGHTDOWN = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9931)
                this.m_Data1.ComAsEkka = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9932)
                this.m_Data1.FlowOnEKM = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9934)
                this.m_Data1.ShowOver = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9935)
                this.m_Data1.K_FLOW = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9936)
                this.m_Data1.AddMass = (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9937)
                this.m_Data1.EKM = (bool) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9938)
                this.m_Data1.TOTALGAS = (double) (float) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9939)
                this.m_Data1.gTG1 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9940)
                this.m_Data1.gTG2 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9941)
                this.m_Data1.gTG3 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9942)
                this.m_Data1.gTG4 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9943)
                this.m_Data1.gTG5 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9944)
                this.m_Data1.gTG6 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9945)
                this.m_Data1.gTG7 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9946)
                this.m_Data1.gTG8 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9947)
                this.m_Data1.gTG9 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9948)
                this.m_Data1.gTG10 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9949)
                this.m_Data1.gTG11 = (int) opcItemState.DataValue;
              if (opcItemState.HandleClient == 9950)
                this.m_Data1.gTG12 = (int) opcItemState.DataValue;
            }
          }
        }
        if (flag)
        {
          if (this.m_Data1.refresh)
          {
            this.m_Data1.AlarmRefresh = true;
            this.m_Data1.refresh = false;
          }
          this.m_Data1.HappenChanged();
          flag = false;
        }
        Thread.Sleep(200);
      }
      this.theGrp.RemoveItems(this.handlesSrv, out this.aE);
      this.theGrp.Remove(false);
      this.theSrv.Disconnect();
      this.theGrp = (OpcGroup) null;
      this.theSrv = (OpcServer) null;
    }

    private float Podgon(float f)
    {
      if ((double) f < 0.0)
        return 0.0f;
      return f;
    }
  }
}
