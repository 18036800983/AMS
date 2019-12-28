using MyABPLC.AB;
using MyABPLC.FCS;
using MyPLCDataview;
using Server_Modle.DBase;
using Server_Modle.XML;
using Server_Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_BLL
{
    public class PLC_Bll
    {
        public delegate void recodeStationLog(string name, string message, int b ,bool showFlag);
        public static event recodeStationLog recodePLCStationMessage;
        public delegate void setStatusDg(string name, int index);
        public event setStatusDg setStatusEvent;
        int boltCurNumber = 0;//螺栓颗数
        Trace_Bolt_Bll trace_Bolt_Bll = new Trace_Bolt_Bll();//螺栓表
        Trace_StationStatus_Bll trace_StationStatus_Bll = new Trace_StationStatus_Bll();//在线总成表
        Crafts_Production_Bll crafts_Production_Bll = new Crafts_Production_Bll();//产品表
        Trace_Keypart_Bll trace_Keypart_Bll = new Trace_Keypart_Bll();//物料表
        Trace_Keypart_Modle trace_Keypart_Modle = new Trace_Keypart_Modle();//物料表Model
        public static bool timeAddFlag = false;
        public static int timeAdd = 0;

        public void Init()
        {
            if (XML_Tool.xml.LINE.Count > 0)
            {
                if (XML_Tool.xml.LINE[0].PLCType == "AB")
                    ABPLCInit();
                else if (XML_Tool.xml.LINE[0].PLCType == "siemens")
                    SiemensPLCInit();
            }
        }

        #region siemens plc
        struct SiemensPLCParameter
        {
            public monitorAddress ma;
            public string itemValue;

            public SiemensPLCParameter(monitorAddress ma_, string itemValue_)   // 带参数的构造函数
            {
                ma = ma_;
                itemValue = itemValue_;
            }
        }
        public PLCFunction[] siemensPlc;
        /// <summary>
        /// plc init 
        /// </summary>
        public void SiemensPLCInit()
        {
            #region PLC连接初始化
            try
            {
                siemensPlc = new PLCFunction[XML_Tool.xml.LINE.Count];
                foreach (var line in XML_Tool.xml.LINE)
                {
                    new Thread(new ParameterizedThreadStart(ConnectSiemensPLC)) { IsBackground = true }.Start(line);
                }
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, " PLC initialization error，" + ex.Message, 1, true);
            }
            #endregion
        }

        /// <summary>
        /// plc connect
        /// </summary>
        /// <param name="objLine"></param>
        private void ConnectSiemensPLC(object objLine)
        {
            var line = objLine as Xml_InfoConfig;
            try
            {
                while (!XML_Tool.xml.SysConfig.offlineTest && !Ping(line.IP))
                {
                    recodePLCStationMessage(string.Empty, line.Name + "Network connection failed", 1, true);
                    Thread.Sleep(5000);
                }
                if (siemensPlc[line.Index] != null)
                {
                    siemensPlc[line.Index].DisconnectMonitor();
                    siemensPlc[line.Index].DisconnectPLC();
                }
                siemensPlc[line.Index] = new PLCFunction(line.IP)
                {
                    OffLine = XML_Tool.xml.SysConfig.offlineTest,
                    ThreadCount = line.ThreaCount,
                    UpdateRate = line.UpdateRate,
                    CpuSlot = line.PLCSlot
                };
                siemensPlc[line.Index].connectPLC();
                siemensPlc[line.Index].eventDataChanged += new DataChanged(OnSiemensPLCDataChanged);
                siemensPlc[line.Index].eventErrorOccurred += new ErrorOccurred(OnSiemensEventShowError);
                var c = GetMtAddrList()[line.Name];
                siemensPlc[line.Index].monitor(c);
                new Thread(new ParameterizedThreadStart(SetLifebeat_siemens)) { IsBackground = true }.Start(line);
                recodePLCStationMessage(string.Empty, line.Name + " PLC connection succeeded", 0, true);
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, line.Name + "Failed to start, try to link again after 10 seconds！" + ex.Message, 1, true);
                Thread.Sleep(8000);
                new Thread(new ParameterizedThreadStart(ConnectSiemensPLC)) { IsBackground = true }.Start(line);
            }
        }

        /// <summary>
        /// get all need monitor address
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<monitorAddress>> GetMtAddrList()
        {
            var infoNode = XML_Tool.xdoc.Root.Element("InfoConfig");
            var dic = new Dictionary<string, List<monitorAddress>>();
            foreach (var lineElement in infoNode.Elements("line"))
            {
                var opcList = lineElement.Descendants("opcitem").ToList();

                List<monitorAddress> maList = new List<monitorAddress>();

                foreach (var item in opcList)
                {
                    Dictionary<string, string> para = new Dictionary<string, string>();
                    para.Add("line", item.Parent.Parent.Parent.Attribute("name").Value);
                    para.Add("station", item.Parent.Parent.Attribute("name").Value);
                    para.Add("type", item.Parent.Name.LocalName);
                    foreach (var at in item.Attributes())
                    {
                        para.Add(at.Name.LocalName, at.Value);
                    }
                    monitorAddress ma = new monitorAddress(item.Attribute("addr").Value, para);
                    maList.Add(ma);
                }
                dic.Add(lineElement.Attribute("name").Value, maList);
            }
            return dic;
        }

        /// <summary>
        /// heart beat
        /// </summary>
        private void SetLifebeat_siemens(object objLine)
        {
            var line = objLine as Xml_InfoConfig; PLCFunction plcLifebeat = null;
            try
            {
                plcLifebeat = new PLCFunction(line.IP)
                {
                    OffLine = XML_Tool.xml.SysConfig.offlineTest,
                    CpuSlot = line.PLCSlot
                };
                plcLifebeat.connectPLC();
                var value = false;
                while (true)
                {
                    if (value)
                        setStatusEvent(line.Name, 1);
                    else
                        setStatusEvent(line.Name, 0);
                    siemensPlc[line.Index].Write(line.HeartBeatAddr, value);
                    value = !value;
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, line.Name + "Write heartbeat error:" + ex.Message, 1,true);
                recodePLCStationMessage(string.Empty, line.Name + " The connection is broken and an attempt is made to reconnect...", 0,true);
                if (plcLifebeat != null)
                    plcLifebeat.DisconnectPLC();
                Thread.Sleep(2000);
                new Thread(new ParameterizedThreadStart(ConnectSiemensPLC)) { IsBackground = true }.Start(line);
            }
        }

        /// <summary>
        /// check the net
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        private bool Ping(string ip)
        {
            try
            {
                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
                int timeout = 1000; // Timeout 时间，单位：毫秒  
                System.Net.NetworkInformation.PingReply reply = p.Send(ip, timeout);
                if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// plc data changed
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="objValue"></param>
        private void OnSiemensPLCDataChanged(monitorAddress ma, object objValue)
        {
            string itemValue = objValue.ToString().Replace("\0", "");
            ThreadPool.QueueUserWorkItem(new WaitCallback(DealSiemensPLCEvent),
                new SiemensPLCParameter(ma, itemValue));
        }

        /// <summary>
        /// error event
        /// </summary>
        /// <param name="message"></param>
        private void OnSiemensEventShowError(string message)
        {
            DoErrorEvent(message);
        }
        #endregion

        #region AB plc
        static object _lock = new object();
        public static object ABRead(AllenBradleyNet plc,string address,string dataType,ushort dataLength)
        {
            lock (_lock)
            {
                object value = new object();
                switch (dataType)
                {
                    case "int":
                        value = plc.ReadInt32(address).Content;
                        break;
                    case "bool":
                        value = plc.ReadBool(address).Content;
                        break;
                    case "float":
                        value = plc.ReadFloat(address).Content;
                        break;
                    case "double":
                        value = plc.ReadDouble(address).Content;
                        break;
                    case "string":
                        value = plc.ReadString(address, dataLength).Content;
                        break;
                    case "short":
                        value = plc.ReadInt16(address).Content;
                        break;
                    case "long":
                        value = plc.ReadInt64(address).Content;
                        break;
                    default:
                        break;
                }
                return value;
            }
        }

        public  static bool ABWrite(AllenBradleyNet plc, string address, string value,string dataType,int length)
        {
            lock (_lock)
            {
                bool writeFlag = false;
                switch (dataType)
                {
                    case "int":
                        writeFlag = plc.Write(address, int.Parse(value)).IsSuccess;
                        break;
                    case "bool":
                        writeFlag = plc.Write(address, bool.Parse(value)).IsSuccess;
                        break;
                    case "float":
                        writeFlag = plc.Write(address, float.Parse(value)).IsSuccess;
                        break;
                    case "double":
                        writeFlag = plc.Write(address, double.Parse(value)).IsSuccess;
                        break;
                    case "string":
                        writeFlag = plc.WriteString(address, value,length);
                        break;
                    case "short":
                        writeFlag = plc.Write(address, short.Parse(value)).IsSuccess;
                        break;
                    case "long":
                        writeFlag = plc.Write(address, long.Parse(value)).IsSuccess;
                        break;
                    default:
                        break;
                }
                return writeFlag;
            }
        }

        struct ABPLCParameter
        {
            public MonitorAddress ma;
            public string itemValue;

            public ABPLCParameter(MonitorAddress ma_, string itemValue_)//带参数的构造函数
            {
                ma = ma_;
                itemValue = itemValue_;
            }
        }

        public static  AllenBradleyNet[] abPlc;

        public void ABPLCInit()
        {
            try
            {
                abPlc = new AllenBradleyNet[XML_Tool.xml.LINE.Count];
                foreach (var line in XML_Tool.xml.LINE)
                {
                    abPlc[line.Index] = new AllenBradleyNet("192.168.0.110");
                    new Thread(new ParameterizedThreadStart(ConnectABPLC)) { IsBackground = true }.Start(line);
                }
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, " PLC initialization error，" + ex.Message, 1, true);
            }
        }

        private void ConnectABPLC(object objLine)
        {
            var line = objLine as Xml_InfoConfig;
            try
            {
                while (!XML_Tool.xml.SysConfig.offlineTest && !Ping(line.IP))
                {
                    recodePLCStationMessage(string.Empty, line.Name + " Network connection failed", 1, true);
                    Thread.Sleep(5000);
                }
                if (abPlc[line.Index] != null)
                {
                    abPlc[line.Index].ConnectClose();
                }
                abPlc[line.Index] = new AllenBradleyNet(line.IP)
                {
                    OffLine = XML_Tool.xml.SysConfig.offlineTest,
                    ThreadCount = line.ThreaCount,
                    UpdateRate = line.UpdateRate,
                };
                abPlc[line.Index].ConnectServer();
                abPlc[line.Index].eventDataChanged += new AllenBradleyNet.DataChanged(OnABPLCDataChanged);
                abPlc[line.Index].eventErrorOccurred += new AllenBradleyNet.ErrorOccurred(OnABEventShowError);
                var c = GetMonitorAddrList()[line.Name];
                abPlc[line.Index].Monitor(c);
                new Thread(new ParameterizedThreadStart(SetLifebeat_AB)) { IsBackground = true }.Start(line);
                recodePLCStationMessage(string.Empty, line.Name + " PLC connection succeeded", 0, true);
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, line.Name + " Failed to start, try to link again after 10 seconds！" + ex.Message, 1, true);
                Thread.Sleep(8000);
                new Thread(new ParameterizedThreadStart(ConnectABPLC)) { IsBackground = true }.Start(line);
            }
        }

        /// <summary>
        /// get all need monitor address
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<MonitorAddress>> GetMonitorAddrList()
        {
            var infoNode = XML_Tool.xdoc.Root.Element("InfoConfig");
            var dic = new Dictionary<string, List<MonitorAddress>>();
            foreach (var lineElement in infoNode.Elements("line"))
            {
                var opcList = lineElement.Descendants("opcitem").ToList();

                List<MonitorAddress> maList = new List<MonitorAddress>();

                foreach (var item in opcList)
                {
                    Dictionary<string, string> para = new Dictionary<string, string>
                    {
                        { "line", item.Parent.Parent.Parent.Attribute("name").Value },
                        { "station", item.Parent.Parent.Attribute("name").Value },
                        { "type", item.Parent.Name.LocalName }
                    };
                    foreach (var at in item.Attributes())
                    {
                        para.Add(at.Name.LocalName, at.Value);
                    }
                    MonitorAddress ma = new MonitorAddress(item.Attribute("addr").Value, item.Attribute("AddrType").Value, para);
                    maList.Add(ma);
                }
                dic.Add(lineElement.Attribute("name").Value, maList);
            }
            return dic;
        }

        /// <summary>
        /// heart beat
        /// </summary>
        private void SetLifebeat_AB(object objLine)
        {
            var line = objLine as Xml_InfoConfig; AllenBradleyNet plcLifebeat = null;
            try
            {
                plcLifebeat = new AllenBradleyNet(line.IP)
                {
                    OffLine = XML_Tool.xml.SysConfig.offlineTest,
                };
                plcLifebeat.ConnectServer();
                var value = false;
                while (true)
                {
                    if (value)
                        setStatusEvent(line.Name, 1);
                    else
                        setStatusEvent(line.Name, 0);
                    ABWrite(abPlc[line.Index], line.HeartBeatAddr,value.ToString(),line.AddrType,0);
                    value = !value;
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, line.Name + " Write heartbeat error:" + ex.Message, 1, true);
                recodePLCStationMessage(string.Empty, line.Name + " The connection is broken and an attempt is made to reconnect...", 0, true);
                if (plcLifebeat != null)
                    plcLifebeat.ConnectClose();
                Thread.Sleep(2000);
                new Thread(new ParameterizedThreadStart(ConnectABPLC)) { IsBackground = true }.Start(line);
            }
        }

        public void OnABPLCDataChanged(MonitorAddress ma, object objValue)
        {
            string itemValue = objValue.ToString().Replace("\0", "");
            ThreadPool.QueueUserWorkItem(new WaitCallback(DealABPLCEvent),
                new ABPLCParameter(ma, itemValue));
        }

        public void OnABEventShowError(string message)
        {
            DoErrorEvent(message);
        }
        #endregion

        #region business
        /// <summary>
        /// deal with error event
        /// </summary>
        /// <param name="message"></param>
        private void DoErrorEvent(string message)
        {
            try
            {
                recodePLCStationMessage(string.Empty, " Control word polling error：" + message, 1,true);
                return;
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, " error：" + ex.Message, 1,true);
            }
        }

        /// <summary>
        /// deal with siemens plc event
        /// </summary>
        /// <param name="state"></param>
        public void DealSiemensPLCEvent(object state)
        {
            var para = (SiemensPLCParameter)state;
            var MA = para.ma;
            var itemValue = para.itemValue;
            var type = MA.Parameter["type"];
            var LineName = MA.Parameter["line"];
            var STName = MA.Parameter["station"];
            var OPCName = MA.Parameter["name"];
            var BackAddr = MA.Parameter["backaddr"];
            var lineObj = XML_Tool.xml.LINE.Single(n => n.Name == LineName);
        }

        /// <summary>
        /// deal with siemens plc event
        /// </summary>
        /// <param name="state"></param>
        public void DealABPLCEvent(object state)
        {
            try
            {
                var para = (ABPLCParameter)state;
                var MA = para.ma;
                var itemValue = para.itemValue;
                var type = MA.Parameter["type"];
                var LineName = MA.Parameter["line"];
                var STName = MA.Parameter["station"];
                var OPCName = MA.Parameter["name"];
                var BackAddr = MA.Parameter["backaddr"];
                var lineObj = XML_Tool.xml.LINE.Single(n => n.Name == LineName);
                var stationObj = XML_Tool.xml.StationConfig.Single(n => n.Name == STName);

                #region 总成绑定
                if (type == "DataRecord" && OPCName == "总成绑定" && itemValue == "1")
                {
                    try
                    {
                        #region 读取plc地址里的值
                        timeAddFlag = true;
                        int stepNo = 1;
                        string sn = string.Empty;
                        Stopwatch sw = new Stopwatch();
                        var stObj = lineObj.STATION.Single(n => n.Name == STName);
                        var opcitem = stObj.Opcitem.SingleOrDefault(n => n.Name == OPCName);
                        var tag = opcitem.Tag.SingleOrDefault(n => n.Tag == int.Parse(itemValue));
                        if (tag == null) return;
                        recodePLCStationMessage(LineName + STName, " Start assembly binding", 0, true);
                        var dataList = tag.Dataitem;
                        sw.Start();
                        string dbColumnStr = string.Empty, dbValueStr = string.Empty, logInfo = string.Empty;
                        foreach (var item in dataList)
                        {
                            dbColumnStr += "[" + item.ColmnName + "]" + ",";
                            dbValueStr += ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + "','";
                            logInfo += item.ColmnName + " : " + ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + " , ";
                            if (item.ColmnName == "SN")
                            {
                                sn = ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)).ToString();
                            }
                        }
                        sw.Stop();
                        sw.Reset();
                        #endregion

                        #region 总成号为空，报警
                        if (string.IsNullOrEmpty(sn))
                        {
                            recodePLCStationMessage(LineName + STName, " The assembly number is empty and the verification fails.！", 0, true);
                            ABWrite(abPlc[lineObj.Index], BackAddr, "2", "int",0);//fail
                            return;
                        }
                        #endregion

                        #region 获取配方，数据写入缓存
                        DataTable productionDt = crafts_Production_Bll.Select_All_Production_Table();
                        bool loadFlag = false;
                        for (int i = 0; i < productionDt.Rows.Count; i++)
                        {
                            if (sn.Contains(productionDt.Rows[i]["ProductionRule"].ToString()))
                            {
                                loadFlag = Recipe_Bll.LoadRecipes(productionDt.Rows[i]["ProductionName"].ToString(), STName);
                            }
                        }
                        if (!loadFlag)
                        {
                            recodePLCStationMessage(LineName + STName, "SN：" + sn + " , Can't recruit the product corresponding to the assembly, please check the formula！", 0, true);
                            ABWrite(abPlc[lineObj.Index], BackAddr, "12", opcitem.AddrType,0);//fail
                            return;
                        }
                        Recipe_Bll.WriteCacheStationInfo(STName, "Step", "1");
                        Recipe_Bll.WriteCacheStationInfo(STName, "SN", sn);
                        #endregion

                        #region 处理数据
                        if (stationObj.Index != 1)
                        {
                            int proIndex = XML_Tool.xml.StationConfig.Single(n => n.Name == STName).Index - 1;
                            string stationStatus = trace_StationStatus_Bll.Select_State__CurStationInfo_Table(XML_Tool.xml.StationConfig.Single(n => n.Index == proIndex).Name, sn);
                            if (stationStatus == "1")
                            {
                                recodePLCStationMessage(LineName + STName, "SN：" + sn + " , Verification pass！", 0, true);
                                ABWrite(abPlc[lineObj.Index], BackAddr, "11", opcitem.AddrType, 0);//success
                                Recipe_Bll.Business(LineName, STName, stepNo + 1);
                            }
                            else
                            {
                                recodePLCStationMessage(LineName + STName, "SN：" + sn + " , Verification failed！", 0, true);
                                ABWrite(abPlc[lineObj.Index], BackAddr, "12", opcitem.AddrType, 0);//fail
                                #region 清空缓存
                                Recipe_Bll.ResetCacheStationInfo(STName);
                                Recipe_Bll.ResetCacheStationRecipeInfo(STName);
                                #endregion
                            }
                        }
                        else
                        {
                            recodePLCStationMessage(LineName + STName, "SN：" + sn + " , First station verification passed！", 0, true);
                            ABWrite(abPlc[lineObj.Index], BackAddr, "11", opcitem.AddrType, 0);//success
                            Recipe_Bll.Business(LineName, STName, stepNo + 1);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        recodePLCStationMessage(LineName + STName, " There is a problem with the assembly binding, exception information：" + ex.Message, 1, true);
                    }
                }
                #endregion

                #region 物料追溯
                if (type == "DataRecord" && OPCName == "物料记录" && itemValue == "1")
                {
                    try
                    {
                        int stepNo = Convert.ToInt32(Recipe_Bll.GetCacheStationInfo(STName, "Step"));
                        string sn = Recipe_Bll.GetCacheStationInfo(STName, "SN");
                        Crafts_Recipe_Modle crafts_Recipe_Modle = Recipe_Bll.GetSingleRecipe(STName, stepNo);

                        #region 读取plc地址里的值
                        Stopwatch sw = new Stopwatch();
                        var stObj = lineObj.STATION.Single(n => n.Name == STName);
                        var opcitem = stObj.Opcitem.SingleOrDefault(n => n.Name == OPCName);
                        var tag = opcitem.Tag.SingleOrDefault(n => n.Tag == int.Parse(itemValue));
                        if (tag == null) return;
                        recodePLCStationMessage(LineName + STName, " SN：" + sn + ",Start material data record", 0, true);
                        var dataList = tag.Dataitem;
                        sw.Start();
                        string dbColumnStr = string.Empty, dbValueStr = string.Empty, logInfo = string.Empty, barCode = string.Empty;
                        foreach (var item in dataList)
                        {
                            dbColumnStr += "[" + item.ColmnName + "]" + ",";
                            dbValueStr += ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + "','";
                            logInfo += item.ColmnName + " : " + ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + " , ";
                            if (item.ColmnName == "SN")
                            {
                                barCode = ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)).ToString();
                            }
                        }
                        sw.Stop();
                        sw.Reset();
                        #endregion

                        #region 校验扫描条码是否正确
                        if (crafts_Recipe_Modle.IsCheck == 1)
                        {
                            if (!barCode.Contains(crafts_Recipe_Modle.CheckRule))
                            {
                                recodePLCStationMessage(LineName + STName, " SN：" + sn + " , Material barcode：" + barCode + " , Verification rule：" + crafts_Recipe_Modle.CheckRule + " ，Verification failed！", 0, true);
                                ABWrite(abPlc[lineObj.Index], BackAddr, "2", "int",0);//fail
                                return;
                            }
                        }
                        #endregion

                        #region 追溯数据处理
                        if (crafts_Recipe_Modle.Istrace == 1)
                        {
                            string count = trace_Keypart_Bll.Select_Count__Material_Table(STName, sn, barCode);
                            if (count != "0")
                            {
                                trace_Keypart_Bll.Delete_Con_Material_Table(STName, sn, barCode);
                                recodePLCStationMessage(LineName + STName, " Data：" + logInfo + " existed，" + "Incomplete data cleared！", 0, true);
                            }
                            trace_Keypart_Modle.ComponentName = crafts_Recipe_Modle.ComponentName;
                            trace_Keypart_Modle.ComponentBarcode = barCode;
                            trace_Keypart_Modle.RecordTime = DateTime.Now.ToString();
                            trace_Keypart_Modle.SN = sn;
                            trace_Keypart_Modle.Station = STName;
                            if (trace_Keypart_Bll.Insert_Condition_Material_Table(trace_Keypart_Modle) > 0)
                            {
                                ABWrite(abPlc[lineObj.Index], BackAddr, "1", "int",0);//success
                            }
                            else
                            {
                                ABWrite(abPlc[lineObj.Index], BackAddr, "2", "int",0);//fail
                            }
                            recodePLCStationMessage(LineName + STName, logInfo + " Material data record completed！", 0, true);
                            Recipe_Bll.Business(LineName, STName, stepNo + 1);
                        }
                        else
                        {
                            recodePLCStationMessage(LineName + STName, logInfo + " ，No traceback required！", 0, true);
                            ABWrite(abPlc[lineObj.Index], BackAddr, "1", "int",0);//success
                            Recipe_Bll.Business(LineName, STName, stepNo + 1);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        recodePLCStationMessage(LineName + STName, " Material traceability problems, abnormal information：" + ex.Message, 1, true);
                    }
                }
                #endregion

                #region 拧紧追溯
                if (type == "DataRecord" && OPCName == "拧紧记录" && itemValue == "1" || itemValue == "5" || itemValue == "22")
                {
                    try
                    {
                        var stObj = lineObj.STATION.Single(n => n.Name == STName);
                        var opcitem = stObj.Opcitem.SingleOrDefault(n => n.Name == OPCName);

                        #region 重新给使能
                        if (itemValue == "5")
                        {
                            ABWrite(abPlc[lineObj.Index], BackAddr, "21", opcitem.AddrType, 0);
                            return;
                        }
                        if(itemValue == "0")return;
                        #endregion

                        string st = Recipe_Bll.GetCacheStationInfo(STName, "Step");
                        if (string.IsNullOrEmpty(st))
                        {
                            return;
                        }
                        int stepNo = Convert.ToInt32(Recipe_Bll.GetCacheStationInfo(STName, "Step"));
                        string sn = Recipe_Bll.GetCacheStationInfo(STName, "SN");
                        Crafts_Recipe_Modle crafts_Recipe_Modle = Recipe_Bll.GetSingleRecipe(STName, stepNo);

                        #region 进入下一步
                        if (itemValue == "22")
                        {
                            Recipe_Bll.Business(LineName, STName, stepNo + 1);
                            return;
                        }
                        #endregion

                        #region 无需追溯，直接通过
                        if (crafts_Recipe_Modle.Istrace == 0)
                        {
                            if (boltCurNumber < crafts_Recipe_Modle.BlotNumber)
                            {
                                recodePLCStationMessage(LineName + STName, "SN：" + sn + ",Formula number " + stepNo + " ，" + boltCurNumber + "No bolts are traced！", 0, true);
                                return;
                            }
                            else
                            {
                                boltCurNumber = 0;
                                recodePLCStationMessage(LineName + STName, "SN：" + sn + ",Formula number " + stepNo + " ，" + boltCurNumber + "No bolts are traced！进入下一步", 0, true);
                                Recipe_Bll.Business(LineName, STName, stepNo + 1);
                                return;
                            }
                        }
                        #endregion

                        #region 读取plc地址里的值
                        Stopwatch sw = new Stopwatch();
                        var tag = opcitem.Tag.SingleOrDefault(n => n.Tag == int.Parse(itemValue));
                        if (tag == null) return;
                        recodePLCStationMessage(LineName + STName, "SN：" + sn + ",Start tightening the data record", 0, true);
                        var dataList = tag.Dataitem;
                        sw.Start();
                        string dbColumnStr = string.Empty, dbValueStr = string.Empty, logInfo = string.Empty;
                        string result = string.Empty, torgue = string.Empty, angle = string.Empty;
                        foreach (var item in dataList)
                        {
                            dbColumnStr += "[" + item.ColmnName + "]" + ",";
                            dbValueStr += ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + "','";
                            logInfo += item.ColmnName + " : " + ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + " , ";
                            if (item.ColmnName == "Result")
                            {
                                result = ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)).ToString();
                            }
                            if (item.ColmnName == "BoltValue")
                            {
                                torgue = ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)).ToString();
                            }
                            if (item.ColmnName == "BoltAngle")
                            {
                                angle = ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)).ToString();
                            }
                        }
                        dbColumnStr = dbColumnStr + "[BoltName]" + "," + "[BoltNo]" + "," + "[SN]" + ",";
                        dbValueStr = dbValueStr + crafts_Recipe_Modle.ComponentName + "','" + boltCurNumber + "','" + sn + "','";
                        sw.Stop();
                        sw.Reset();
                        #endregion

                        #region 处理追溯数据
                        if (result != "2")
                        {
                            boltCurNumber++;//螺栓数量自加1
                            string count = trace_Bolt_Bll.Select_Count__Bolt_Table(STName, sn, boltCurNumber);
                            if (count != "0")
                            {
                                trace_Bolt_Bll.Delete_Con_Bolt_Table(STName, sn, boltCurNumber);
                                recodePLCStationMessage(LineName + STName, "Data：" + logInfo + "Already exists, incomplete data has been cleared！", 0, true);
                            }
                        }
                        if (trace_Bolt_Bll.Insert_Condition_Bolt_Table(tag.TableName, dbColumnStr, dbValueStr, STName) > 0)
                        {
                            ABWrite(abPlc[lineObj.Index], BackAddr, "11", opcitem.AddrType, 0);//success
                            recodePLCStationMessage(LineName + STName, " Tighten back success！", 0, true);
                        }
                        else
                        {
                            ABWrite(abPlc[lineObj.Index], BackAddr, "12", opcitem.AddrType, 0);//fail
                        }
                        recodePLCStationMessage(LineName + STName, logInfo + " Tighten the data record to complete！", 0, true);

                        //最后一颗螺栓进入下一步
                        if (boltCurNumber - 1 == crafts_Recipe_Modle.BlotNumber)
                        {
                            boltCurNumber = 0;
                            recodePLCStationMessage(LineName + STName, "SN：" + sn + ",Formula number " + stepNo + " ，" + boltCurNumber + " bolt are traced back!", 0, true);
                            Recipe_Bll.Business(LineName, STName, stepNo + 1);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        recodePLCStationMessage(LineName + STName, "Tighten back to the problem, abnormal information：" + ex.Message, 1, true);
                    }
                }
                #endregion

                #region 测量追溯
                if (type == "DataRecord" && OPCName.Contains("测量记录") && itemValue == "1")
                {
                    try
                    {
                        #region 局部变量
                        string st = Recipe_Bll.GetCacheStationInfo(STName, "Step");
                        if (string.IsNullOrEmpty(st))
                        {
                            return;
                        }
                        int stepNo = Convert.ToInt32(Recipe_Bll.GetCacheStationInfo(STName, "Step"));
                        string sn = Recipe_Bll.GetCacheStationInfo(STName, "SN");
                        Crafts_Recipe_Modle crafts_Recipe_Modle = Recipe_Bll.GetSingleRecipe(STName, stepNo);
                        #endregion

                        #region 无需追溯，直接通过
                        if (crafts_Recipe_Modle.Istrace == 0)
                        {
                            recodePLCStationMessage(LineName + STName, "SN：" + sn + ",Step:" + stepNo + ",Formula number " + stepNo + " ，" + boltCurNumber + " No bolts are traced back!", 0, false);
                            Recipe_Bll.Business(LineName, STName, stepNo + 1);
                            return;
                        }
                        #endregion

                        #region 读取plc地址里的值
                        Thread.Sleep(3000);
                        string testName = Recipe_Bll.GetTestType(crafts_Recipe_Modle.ComponentName);
                        Stopwatch sw = new Stopwatch();
                        var stObj = lineObj.STATION.Single(n => n.Name == STName);
                        var opcitem = stObj.Opcitem.SingleOrDefault(n => n.Name == OPCName);
                        var tag = opcitem.Tag.SingleOrDefault(n => n.Tag == int.Parse(itemValue));
                        if (tag == null) return;
                        recodePLCStationMessage(LineName + STName, "SN：" + sn + ",Start measuring data records", 0, false);
                        var dataList = tag.Dataitem;
                        sw.Start();
                        string dbColumnStr = string.Empty, dbValueStr = string.Empty, logInfo = string.Empty, result = string.Empty;
                        foreach (var item in dataList)
                        {
                            dbColumnStr += "[" + item.ColmnName + "]" + ",";
                            dbValueStr += ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + "','";
                            logInfo += item.ColmnName + " : " + ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)) + " , ";
                            if (item.ColmnName == "MeasureResult")
                            {
                                result = ABRead(abPlc[lineObj.Index], item.Addr, item.AddrType, ushort.Parse(item.AddrLength)).ToString();
                                recodePLCStationMessage(LineName + STName, "Measure name :" + testName + ",Step:" + stepNo + ", Result:" + result, 0, true);
                            }
                        }
                        sw.Stop();
                        sw.Reset();
                        #endregion

                        #region 检测星云插入到数据库的数据
                        string count = Trace_Measure_Bll.Select_Count_Measure_Table(STName, sn, opcitem.OperationDesc);
                        if (int.Parse(count) == 0)
                        {
                            recodePLCStationMessage(LineName + STName, "SN：" + sn + ",Step:" + stepNo + ",test name " + testName + " , need tace: " + XML_Tool.xml.TestDBConfig.Count + ",really trace :" + count + " failed!", 1, false);
                            ABWrite(abPlc[lineObj.Index], BackAddr, "12", opcitem.AddrType, 0);
                            return;
                        }
                        #endregion

                        #region 处理追溯结果
                        if (result == "1")
                        {
                            ABWrite(abPlc[lineObj.Index], BackAddr, "11", opcitem.AddrType, 0);//success
                            recodePLCStationMessage(LineName + STName, "Measure name :" + testName + ",Step:" + stepNo + ", Measurement data recording completed！", 0, false);
                            Recipe_Bll.Business(LineName, STName, stepNo + 1);
                        }
                        else
                        {
                            ABWrite(abPlc[lineObj.Index], BackAddr, "11", opcitem.AddrType, 0);//fail
                            recodePLCStationMessage(LineName + STName, "Measure name :" + testName + ",Step:" + stepNo + ", Measurement data recording completed！The result is NG！", 0, true);
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        recodePLCStationMessage(LineName + STName, "Measurement traceability problems, abnormal information ：" + ex.Message, 0, true);
                    }
                }
                #endregion

                #region 报警处理
                if ((type == "Alarm" && OPCName == "模块故障" && itemValue != "0")
                    || (type == "Alarm" && OPCName != "模块故障" && itemValue == "true"))
                {
                    var dateTime = DateTime.Now;
                    var dateTimeInt = long.Parse(dateTime.ToString("yyMMddHHmmss"));
                    Line_StationAlarm_Bll.Insert(dateTimeInt, dateTime.ToString(), "", MA.Parameter["addr"], STName, "DeviceCheck_Alarm", OPCName);
                }
                #endregion
            }
            catch (Exception ex)
            {
                recodePLCStationMessage(string.Empty, " PLC business processing problems, abnormal information：" + ex.Message, 0, true);
            }
        }
        #endregion

        /// <summary>
        /// 计时器
        /// </summary>
        public static void Timer()
        {
            do
            {
                if (timeAddFlag)
                {
                    timeAdd++;
                    Thread.Sleep(1000);
                }
                else
                {
                    timeAdd = 0;
                }
            } while (true);
        }
    }
}
